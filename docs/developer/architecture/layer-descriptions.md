# Layer Descriptions

## Overview

This document provides detailed descriptions of each layer in the AVA AIGC Toolbox architecture, including their responsibilities, components, and interactions.

## 1. Core Layer

The Core layer is the innermost layer of the architecture and contains the fundamental business rules and domain models. It is completely independent of all other layers.

### Responsibilities

- Define core business entities and value objects
- Establish business rules and invariants
- Define interfaces for repositories and services (ports)
- Implement domain services that encapsulate complex business logic

### Components

#### 1.1 Domain Entities

Domain entities are the core business objects that represent the fundamental concepts of the application. They encapsulate business rules and invariants, and they are typically mutable.

**Examples in AVA AIGC Toolbox:**

| Entity | Description |
|--------|-------------|
| `Image` | Represents an image file with metadata |
| `Folder` | Represents a filesystem folder containing images |
| `Album` | Represents a user-created collection of images |
| `Tag` | Represents a keyword used to categorize images |
| `ImageTag` | Join entity that links images to tags |
| `Model` | Represents an AI model used to generate images |

**Key Characteristics:**

- Have a unique identifier
- Encapsulate business logic
- Enforce invariants
- Can be persisted to a database

**Example Entity Implementation:**

```csharp
public class Image
{
    public int Id { get; private set; }
    public string FilePath { get; private set; }
    public string FileName { get; private set; }
    public long FileSize { get; private set; }
    public int Width { get; private set; }
    public int Height { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public DateTime UpdatedAt { get; private set; }
    
    // Private constructor for ORM
    private Image() { }
    
    // Public constructor with validation
    public Image(string filePath, string fileName, long fileSize, int width, int height)
    {
        // Enforce invariants
        if (string.IsNullOrWhiteSpace(filePath))
            throw new ArgumentException("File path cannot be empty", nameof(filePath));
        
        if (string.IsNullOrWhiteSpace(fileName))
            throw new ArgumentException("File name cannot be empty", nameof(fileName));
        
        if (fileSize <= 0)
            throw new ArgumentException("File size must be greater than zero", nameof(fileSize));
        
        if (width <= 0 || height <= 0)
            throw new ArgumentException("Width and height must be greater than zero");
        
        FilePath = filePath;
        FileName = fileName;
        FileSize = fileSize;
        Width = width;
        Height = height;
        CreatedAt = DateTime.UtcNow;
        UpdatedAt = DateTime.UtcNow;
    }
    
    // Business method
    public void UpdateMetadata(string newFileName)
    {
        if (string.IsNullOrWhiteSpace(newFileName))
            throw new ArgumentException("File name cannot be empty", nameof(newFileName));
        
        FileName = newFileName;
        UpdatedAt = DateTime.UtcNow;
    }
}
```

#### 1.2 Value Objects

Value objects are immutable objects that represent descriptive aspects of the domain without identity. They are defined by their attributes rather than a unique identifier.

**Examples in AVA AIGC Toolbox:**

| Value Object | Description |
|--------------|-------------|
| `TagCount` | Represents the count of images associated with a tag |
| `ImageDimensions` | Represents the width and height of an image |

**Key Characteristics:**

- Immutable
- No unique identifier
- Defined by their attributes
- Can be used as attributes of entities

**Example Value Object Implementation:**

```csharp
public class TagCount
{
    public string TagName { get; }
    public int Count { get; }
    
    public TagCount(string tagName, int count)
    {
        if (string.IsNullOrWhiteSpace(tagName))
            throw new ArgumentException("Tag name cannot be empty", nameof(tagName));
        
        if (count < 0)
            throw new ArgumentException("Count cannot be negative", nameof(count));
        
        TagName = tagName;
        Count = count;
    }
    
    // Implement equality based on attributes
    public override bool Equals(object obj)
    {
        if (obj is TagCount other)
        {
            return TagName == other.TagName && Count == other.Count;
        }
        return false;
    }
    
    public override int GetHashCode()
    {
        return HashCode.Combine(TagName, Count);
    }
}
```

#### 1.3 Ports (Interfaces)

Ports are interfaces that define the boundaries between the Core layer and other layers. They allow the Core layer to communicate with external systems without creating direct dependencies.

**Repository Ports:**

Repository ports define the interfaces for data access operations. They are implemented by the Infrastructure layer.

**Examples in AVA AIGC Toolbox:**

| Interface | Description |
|-----------|-------------|
| `IImageRepository` | Defines operations for accessing images |
| `IFolderRepository` | Defines operations for accessing folders |
| `IAlbumRepository` | Defines operations for accessing albums |
| `ITagRepository` | Defines operations for accessing tags |
| `IImageTagRepository` | Defines operations for accessing image-tag relationships |

**Example Repository Interface:**

```csharp
public interface IImageRepository
{
    Task<Image> GetByIdAsync(int id);
    Task<IEnumerable<Image>> GetAllAsync();
    Task<IEnumerable<Image>> GetByFolderIdAsync(int folderId);
    Task<IEnumerable<Image>> GetByAlbumIdAsync(int albumId);
    Task AddAsync(Image image);
    Task UpdateAsync(Image image);
    Task DeleteAsync(int id);
    Task<int> GetTotalCountAsync();
}
```

## 2. Application Layer

The Application layer contains the application-specific business logic and orchestrates the flow of data between the Core layer and external systems.

### Responsibilities

- Implement use cases that represent business operations
- Coordinate between repositories and domain entities
- Handle application-specific business rules
- Manage transaction boundaries
- Provide input/output models for the Presentation layer

### Components

#### 2.1 Use Cases

Use cases represent the business operations that the application can perform. Each use case is a discrete unit of work that implements a specific business function.

**Organization:**

Use cases are organized by feature area in the `UseCases` directory:

```
src/Application/UseCases/
├── Albums/
├── Folders/
├── Images/
├── Tags/
└── BaseUseCases.cs
```

**Base Use Case Class:**

All use cases inherit from a base class that provides common functionality:

```csharp
public abstract class UseCase<TOutput>
{
    protected UseCase()
    {
    }
    
    public abstract Task<TOutput> ExecuteAsync();
}

public abstract class UseCase<TInput, TOutput>
{
    protected UseCase()
    {
    }
    
    public abstract Task<TOutput> ExecuteAsync(TInput input);
}
```

**Example Use Case Implementation:**

```csharp
public class GetImagesByFolderIdUseCase : UseCase<int, IEnumerable<Image>>
{
    private readonly IImageRepository _imageRepository;
    
    public GetImagesByFolderIdUseCase(IImageRepository imageRepository)
    {
        _imageRepository = imageRepository;
    }
    
    public override async Task<IEnumerable<Image>> ExecuteAsync(int folderId)
    {
        if (folderId <= 0)
            throw new ArgumentException("Folder ID must be greater than zero", nameof(folderId));
        
        return await _imageRepository.GetByFolderIdAsync(folderId);
    }
}
```

#### 2.2 DTOs (Data Transfer Objects)

DTOs are used to transfer data between layers, especially between the Application layer and Presentation layer. They help to decouple the internal domain model from the external representation.

**Note:** The AVA AIGC Toolbox currently uses domain entities directly in the Presentation layer, but DTOs may be introduced in the future for more complex scenarios.

## 3. Infrastructure Layer

The Infrastructure layer contains implementations of the ports defined in the Core layer, as well as other external dependencies.

### Responsibilities

- Implement repository interfaces for data access
- Handle database operations
- Integrate with external APIs and services
- Provide logging and configuration services
- Implement cross-cutting concerns

### Components

#### 3.1 Database Context

The database context manages the connection to the SQLite database and provides access to the database tables using SQLite.NET.

**Example Database Context Implementation:**

```csharp
public class DatabaseContext : IDisposable
{
    private readonly SQLiteConnection _connection;
    public string DatabasePath { get; }

    public DatabaseContext(string databasePath)
    {
        DatabasePath = databasePath;
        _connection = new SQLiteConnection(databasePath);
        InitializeDatabase();
    }

    private void InitializeDatabase()
    {
        var databaseDir = Path.GetDirectoryName(DatabasePath);
        if (!Directory.Exists(databaseDir))
        {
            Directory.CreateDirectory(databaseDir);
        }

        CreateTables();
        CreateIndexes();
    }

    private void CreateTables()
    {
        _connection.CreateTable<Image>();
        _connection.CreateTable<Folder>();
        _connection.CreateTable<Tag>();
        _connection.CreateTable<ImageTag>();
        _connection.CreateTable<Album>();
        
        // Create AlbumImage table with foreign keys
        var sql = @"
        CREATE TABLE IF NOT EXISTS ""AlbumImage""(
            ""AlbumId""   integer,
            ""ImageId""   integer,
            CONSTRAINT ""FK_AlbumImage_AlbumId"" FOREIGN KEY(""AlbumId"") REFERENCES Album(""Id""),
            CONSTRAINT ""FK_AlbumImage_ImageId"" FOREIGN KEY(""ImageId"") REFERENCES Image(""Id"")
        );
        ";
        _connection.Execute(sql);
    }

    private void CreateIndexes()
    {
        // Image indexes
        _connection.CreateIndex<Image>(image => image.RootFolderId);
        _connection.CreateIndex<Image>(image => image.FolderId);
        _connection.CreateIndex<Image>(image => image.Path, true);
        // Additional indexes...
    }

    public SQLiteConnection GetConnection()
    {
        return _connection;
    }

    public void Dispose()
    {
        _connection.Dispose();
    }
}

#### 3.2 Repository Implementations

Repository implementations provide concrete implementations of the repository interfaces defined in the Core layer using SQLite.NET.

**Example Repository Implementation:**

```csharp
public class SQLiteImageRepository : IImageRepository
{
    private readonly DatabaseContext _dbContext;
    
    public SQLiteImageRepository(DatabaseContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task<Image> GetByIdAsync(int id)
    {
        using var connection = _dbContext.GetConnection();
        return await connection.Table<Image>().Where(i => i.Id == id).FirstOrDefaultAsync();
    }
    
    public async Task<IEnumerable<Image>> GetAllAsync()
    {
        using var connection = _dbContext.GetConnection();
        return await connection.Table<Image>().ToListAsync();
    }
    
    public async Task<IEnumerable<Image>> GetByFolderIdAsync(int folderId)
    {
        using var connection = _dbContext.GetConnection();
        return await connection.Table<Image>()
            .Where(i => i.FolderId == folderId)
            .ToListAsync();
    }
    
    // Implement other methods...
}

## 4. Presentation Layer

The Presentation layer is responsible for handling user interaction and displaying information to the user.

### Responsibilities

- Implement the user interface using Avalonia UI
- Handle user input and events
- Call use cases from the Application layer
- Display results to the user
- Manage the application's lifecycle

### Components

#### 4.1 Views (XAML)

Views are the visual components of the application, defined using XAML (Extensible Application Markup Language). They define the layout and appearance of the user interface.

**Example View (MainWindow.axaml):**

```xaml
<Window xmlns="https://github.com/avaloniaui" 
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:vm="using:AIGenManager.Presentation.ViewModels"
        x:Class="AIGenManager.Presentation.Views.MainWindow"
        Title="AVA AIGC Toolbox">
    
    <Design.DataContext>
        <vm:MainWindowViewModel />
    </Design.DataContext>
    
    <Grid>
        <!-- Sidebar -->
        <Grid.ColumnDefinitions>
            <ColumnDefinition Width="250" />
            <ColumnDefinition Width="*" />
        </Grid.ColumnDefinitions>
        
        <!-- Main content area -->
        <Grid Grid.Column="1">
            <!-- Image grid -->
            <ItemsControl ItemsSource="{Binding Images}">
                <ItemsControl.ItemsPanel>
                    <ItemsPanelTemplate>
                        <WrapPanel Orientation="Horizontal" />
                    </ItemsPanelTemplate>
                </ItemsControl.ItemsPanel>
                <ItemsControl.ItemTemplate>
                    <DataTemplate>
                        <Border Margin="5" Padding="5" BorderBrush="Gray" BorderThickness="1" CornerRadius="5">
                            <StackPanel>
                                <Image Source="{Binding ThumbnailPath}" Width="200" Height="200" Stretch="Uniform" />
                                <TextBlock Text="{Binding FileName}" Margin="0 5 0 0" TextAlignment="Center" />
                            </StackPanel>
                        </Border>
                    </DataTemplate>
                </ItemsControl.ItemTemplate>
            </ItemsControl>
        </Grid>
    </Grid>
</Window>
```

#### 4.2 ViewModels

ViewModels implement the MVVM (Model-View-ViewModel) pattern, acting as intermediaries between the Views and the Application layer. They expose data and commands to the Views.

**Example ViewModel:**

```csharp
public class MainWindowViewModel : ViewModelBase
{
    private readonly GetAllImagesUseCase _getAllImagesUseCase;
    private readonly GetAllFoldersUseCase _getAllFoldersUseCase;
    
    [ObservableProperty]
    private ObservableCollection<Image> _images = new();
    
    [ObservableProperty]
    private ObservableCollection<Folder> _folders = new();
    
    [ObservableProperty]
    private Folder _selectedFolder;
    
    public MainWindowViewModel(
        GetAllImagesUseCase getAllImagesUseCase,
        GetAllFoldersUseCase getAllFoldersUseCase)
    {
        _getAllImagesUseCase = getAllImagesUseCase;
        _getAllFoldersUseCase = getAllFoldersUseCase;
        
        // Initialize data
        _ = InitializeAsync();
    }
    
    private async Task InitializeAsync()
    {
        // Load folders
        var folders = await _getAllFoldersUseCase.ExecuteAsync();
        Folders = new ObservableCollection<Folder>(folders);
        
        // Load all images initially
        await LoadImagesAsync();
    }
    
    [RelayCommand]
    private async Task LoadImagesAsync()
    {
        IEnumerable<Image> images;
        
        if (SelectedFolder != null)
        {
            // Load images for selected folder
            var getImagesByFolderUseCase = App.ServiceProvider.GetRequiredService<GetImagesByFolderIdUseCase>();
            images = await getImagesByFolderUseCase.ExecuteAsync(SelectedFolder.Id);
        }
        else
        {
            // Load all images
            images = await _getAllImagesUseCase.ExecuteAsync();
        }
        
        Images = new ObservableCollection<Image>(images);
    }
    
    // Other commands and methods...
}
```

#### 4.3 App Entry Point

The application entry point is responsible for initializing the application, setting up dependency injection, and launching the main window.

**Example App.axaml.cs:**

```csharp
public partial class App : Avalonia.Application
{
    public IServiceProvider? ServiceProvider { get; private set; }

    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        // Configure dependency injection
        ConfigureServices();

        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            // Disable duplicate validation plugins
            DisableAvaloniaDataAnnotationValidation();
            desktop.MainWindow = new MainWindow
            {
                DataContext = ServiceProvider!.GetRequiredService<MainWindowViewModel>(),
            };
        }

        base.OnFrameworkInitializationCompleted();
    }

    private void ConfigureServices()
    {
        var services = new ServiceCollection();

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

        // Repositories
        services.AddSingleton<IImageRepository, SQLiteImageRepository>();
        services.AddSingleton<IFolderRepository, SQLiteFolderRepository>();
        services.AddSingleton<ITagRepository, SQLiteTagRepository>();
        services.AddSingleton<IImageTagRepository, SQLiteImageTagRepository>();
        services.AddSingleton<IAlbumRepository, SQLiteAlbumRepository>();

        // Use cases
        services.AddTransient<GetAllImagesUseCase>();
        services.AddTransient<GetImagesByFolderIdUseCase>();
        services.AddTransient<GetAllFoldersUseCase>();
        services.AddTransient<GetRootFoldersUseCase>();
        
        // Tag use cases
        services.AddTransient<GetAllTagsUseCase>();
        services.AddTransient<GetTagsByImageIdUseCase>();
        services.AddTransient<AddTagUseCase>();
        services.AddTransient<AddTagToImageUseCase>();
        services.AddTransient<RemoveTagFromImageUseCase>();
        
        // Album use cases
        services.AddTransient<GetAllAlbumsUseCase>();
        services.AddTransient<GetAlbumByIdUseCase>();
        services.AddTransient<GetImagesByAlbumIdUseCase>();
        services.AddTransient<AddAlbumUseCase>();
        services.AddTransient<AddImageToAlbumUseCase>();

        // ViewModels
        services.AddTransient<MainWindowViewModel>();

        ServiceProvider = services.BuildServiceProvider();
    }

    private void DisableAvaloniaDataAnnotationValidation()
    {
        // Disable duplicate validations from both Avalonia and CommunityToolkit
        var dataValidationPluginsToRemove = BindingPlugins.DataValidators
            .OfType<DataAnnotationsValidationPlugin>().ToArray();
        foreach (var plugin in dataValidationPluginsToRemove)
        {
            BindingPlugins.DataValidators.Remove(plugin);
        }
    }
}

## Layer Interactions

### Data Flow Example: Loading Images by Folder

1. **User Interaction**: User selects a folder in the sidebar
2. **ViewModel**: `MainWindowViewModel.SelectedFolder` property changes
3. **Command Execution**: `LoadImagesAsync` command is executed
4. **UseCase Call**: `GetImagesByFolderIdUseCase.ExecuteAsync(folderId)` is called
5. **Repository Call**: Use case calls `IImageRepository.GetByFolderIdAsync(folderId)`
6. **Database Operation**: Repository executes SQL query to fetch images
7. **Result Return**: Images are returned to the use case
8. **ViewModel Update**: Use case result is set to the `Images` property
9. **UI Update**: View automatically updates via data binding

### Dependency Injection Flow

1. **App Initialization**: `App.OnFrameworkInitializationCompleted()` sets up DI container
2. **Service Registration**: All services, use cases, and repositories are registered
3. **Constructor Injection**: Dependencies are injected into constructors
4. **Runtime Resolution**: Services are resolved from the container as needed

## Conclusion

The AVA AIGC Toolbox architecture follows Clean Architecture principles, with clear separation of concerns between layers. This design provides numerous benefits, including:

- **Maintainability**: Clear separation of concerns makes the codebase easier to understand and modify
- **Testability**: Use cases and domain entities can be tested in isolation
- **Flexibility**: External dependencies can be easily swapped
- **Scalability**: The architecture can accommodate new features and changes

By understanding the role and responsibilities of each layer, developers can work more effectively within the codebase and contribute to the project's success.

---

*Last updated: January 2026*
