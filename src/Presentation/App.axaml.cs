using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Data.Core;
using Avalonia.Data.Core.Plugins;
using System;
using System.IO;
using System.Linq;
using System.Reflection;
using Avalonia.Markup.Xaml;
using Microsoft.Extensions.DependencyInjection;
using BerryAIGCToolbox.ViewModels;
using BerryAIGCToolbox.Views;
using AIGenManager.Core.Application.Ports;
using AIGenManager.Core.Domain.Services;
using AIGenManager.Infrastructure.Repositories;
using AIGenManager.Infrastructure.Data;
using AIGenManager.Application.UseCases.Images;
using AIGenManager.Application.UseCases.Folders;
using AIGenManager.Infrastructure.Services;

namespace BerryAIGCToolbox;

public partial class App : Avalonia.Application
{
    public IServiceProvider? ServiceProvider { get; private set; }

    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
        
        // Setup global exception handling
        SetupGlobalExceptionHandling();
    }

    public override void OnFrameworkInitializationCompleted()
    {
        try
        {
            // Configure dependency injection
            ConfigureServices();

            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                // Avoid duplicate validations from both Avalonia and CommunityToolkit. 
                // More info: https://docs.avaloniaui.net/docs/guides/development-guides/data-validation#manage-validationplugins
                DisableAvaloniaDataAnnotationValidation();
                desktop.MainWindow = new MainWindow
                {
                    DataContext = ServiceProvider!.GetRequiredService<MainWindowViewModel>(),
                };
                
                // Set the static reference to the main window for view models to access
                ViewModelBase.MainWindow = desktop.MainWindow;
            }

            base.OnFrameworkInitializationCompleted();
        }
        catch (Exception ex)
        {
            LogError("Error during framework initialization", ex);
            throw;
        }
    }

    private void ConfigureServices()
    {
        try
        {
            var services = new ServiceCollection();

            // Database context
            var appDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "BerryAIGCToolbox");
            Directory.CreateDirectory(appDataPath);
            var dbPath = Path.Combine(appDataPath, "berry-aigc-toolbox.db");
            
            LogInfo($"Database path: {dbPath}");
            services.AddSingleton(new DatabaseContext(dbPath));
            
            // SQLite connection
            services.AddSingleton(sp =>
            {
                var dbContext = sp.GetRequiredService<DatabaseContext>();
                return dbContext.GetConnection();
            });

            // Repositories
            services.AddSingleton<IImageRepository, SQLiteImageRepository>();
            services.AddSingleton<IFolderRepository, SQLiteFolderRepository>();
            services.AddSingleton<ITagRepository, SQLiteTagRepository>();
            services.AddSingleton<IImageTagRepository, SQLiteImageTagRepository>();
            services.AddSingleton<IAlbumRepository, SQLiteAlbumRepository>();

            // Services for metadata extraction and thumbnail generation
            services.AddSingleton<IFolderScanner, FolderScanner>();
            services.AddSingleton<PngMetadataExtractor>();
            services.AddSingleton<IMetadataExtractionService, MetadataExtractionService>();
            services.AddSingleton<IThumbnailGenerationService, ThumbnailGenerationService>();
            services.AddSingleton<IImageImportService, ImageImportService>();

            // Use cases
            services.AddTransient<GetAllImagesUseCase>();
            services.AddTransient<GetImagesByFolderIdUseCase>();
            services.AddTransient<GetAllFoldersUseCase>();
            services.AddTransient<GetRootFoldersUseCase>();
            services.AddTransient<AIGenManager.Application.UseCases.Folders.ScanFolderUseCase>();
            services.AddTransient<GetImportStatisticsUseCase>();
            
            // Tag use cases
            services.AddTransient<AIGenManager.Application.UseCases.Tags.GetAllTagsUseCase>();
            services.AddTransient<AIGenManager.Application.UseCases.Tags.GetTagsByImageIdUseCase>();
            services.AddTransient<AIGenManager.Application.UseCases.Tags.AddTagUseCase>();
            services.AddTransient<AIGenManager.Application.UseCases.Tags.AddTagToImageUseCase>();
            services.AddTransient<AIGenManager.Application.UseCases.Tags.RemoveTagFromImageUseCase>();
            
            // Album use cases
            services.AddTransient<AIGenManager.Application.UseCases.Albums.GetAllAlbumsUseCase>();
            services.AddTransient<AIGenManager.Application.UseCases.Albums.GetAlbumByIdUseCase>();
            services.AddTransient<AIGenManager.Application.UseCases.Albums.GetImagesByAlbumIdUseCase>();
            services.AddTransient<AIGenManager.Application.UseCases.Albums.AddAlbumUseCase>();
            services.AddTransient<AIGenManager.Application.UseCases.Albums.AddImageToAlbumUseCase>();

            // ViewModels
            services.AddTransient<MainWindowViewModel>();
            services.AddTransient<ImportWizardViewModel>();

            ServiceProvider = services.BuildServiceProvider();
            
            LogInfo("Dependency injection configured successfully");
        }
        catch (Exception ex)
        {
            LogError("Error configuring services", ex);
            throw;
        }
    }

    private void DisableAvaloniaDataAnnotationValidation()
    {
        // Get an array of plugins to remove
        var dataValidationPluginsToRemove =
            BindingPlugins.DataValidators.OfType<DataAnnotationsValidationPlugin>().ToArray();

        // remove each entry found
        foreach (var plugin in dataValidationPluginsToRemove)
        {
            BindingPlugins.DataValidators.Remove(plugin);
        }
    }

    private void SetupGlobalExceptionHandling()
    {
        // Handle unhandled exceptions
        AppDomain.CurrentDomain.UnhandledException += (sender, e) =>
        {
            LogError("Unhandled exception in AppDomain", e.ExceptionObject as Exception);
        };

        // Handle task scheduler exceptions
        System.Threading.Tasks.TaskScheduler.UnobservedTaskException += (sender, e) =>
        {
            LogError("Unobserved task exception", e.Exception);
            e.SetObserved();
        };
    }

    private void LogError(string message, Exception? exception = null)
    {
        var logMessage = $"[ERROR] {message}";
        if (exception != null)
        {
            logMessage += $"\nException: {exception.Message}";
            logMessage += $"\nStack Trace: {exception.StackTrace}";
        }
        
        System.Diagnostics.Debug.WriteLine(logMessage);
        
        // Also write to a log file for persistent error tracking
        try
        {
            var logPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "BerryAIGCToolbox", "error.log");
            var logDir = Path.GetDirectoryName(logPath);
            if (!string.IsNullOrEmpty(logDir) && !Directory.Exists(logDir))
            {
                Directory.CreateDirectory(logDir);
            }
            
            var logEntry = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {logMessage}\n";
            File.AppendAllText(logPath, logEntry);
        }
        catch
        {
            // Ignore logging errors to prevent infinite loops
        }
    }

    private void LogInfo(string message)
    {
        var logMessage = $"[INFO] {message}";
        System.Diagnostics.Debug.WriteLine(logMessage);
    }
}
