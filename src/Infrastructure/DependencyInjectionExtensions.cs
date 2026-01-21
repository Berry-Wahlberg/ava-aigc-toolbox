using AIGenManager.Core.Application.Ports;
using AIGenManager.Core.Domain.Services;
using AIGenManager.Infrastructure.Data;
using AIGenManager.Infrastructure.Repositories;
using AIGenManager.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;
using System.IO;

namespace AIGenManager.Infrastructure
{
    public static class DependencyInjectionExtensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            // Database context
            var appDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "AIGenManager");
            Directory.CreateDirectory(appDataPath);
            var dbPath = Path.Combine(appDataPath, "aigenmanager.db");
            services.AddSingleton(new DatabaseContext(dbPath));
            
            // SQLite connection
            services.AddSingleton(sp =>
            {
                var dbContext = sp.GetRequiredService<DatabaseContext>();
                return dbContext.GetConnection();
            });

            // Services
            services.AddSingleton<PngMetadataExtractor>();
            services.AddSingleton<FolderScanner>();

            // Repositories
            services.AddSingleton<IImageRepository, SQLiteImageRepository>();
            services.AddSingleton<IFolderRepository, SQLiteFolderRepository>();
            services.AddSingleton<ITagRepository, SQLiteTagRepository>();
            services.AddSingleton<IImageTagRepository, SQLiteImageTagRepository>();
            services.AddSingleton<IAlbumRepository, SQLiteAlbumRepository>();

            // Services
            services.AddSingleton<IMetadataExtractionService, MetadataExtractionService>();
            services.AddSingleton<IImageImportService, ImageImportService>();
            services.AddSingleton<FileSystemService>();

            return services;
        }
    }
}