# Coding Standards

This document outlines the coding standards and best practices for the AVA AIGC Toolbox project. All contributors must follow these guidelines to ensure code consistency and maintainability.

## Overview

Consistent coding standards are essential for:
- Improving code readability and understandability
- Reducing the learning curve for new team members
- Minimizing bugs and errors
- Facilitating code reviews
- Ensuring long-term maintainability

## C# Coding Standards

### Naming Conventions

#### Classes and Interfaces
- Use PascalCase for class names
- Use PascalCase for interface names, prefixed with `I`
- Example: `ImageRepository`, `IImageRepository`

#### Methods and Properties
- Use PascalCase for methods
- Use PascalCase for properties
- Example: `GetAllImages()`, `ImageId`

#### Variables and Parameters
- Use camelCase for variables and parameters
- Example: `imageName`, `folderPath`

#### Constants
- Use SCREAMING_SNAKE_CASE for constants
- Example: `MAX_IMAGE_SIZE`

#### Private Fields
- Use camelCase with underscore prefix for private fields
- Example: `_imageRepository`, `_folderService`

#### Enums
- Use PascalCase for enum types
- Use PascalCase for enum values
- Example:
  ```csharp
  public enum ImageType
  {
      Image,
      Video,
      Other
  }
  ```

#### Namespaces
- Use PascalCase for namespace segments
- Use reverse domain name notation for root namespaces
- Example: `AIGenManager.Core.Domain.Entities`

#### Files and Directories
- Use PascalCase for file names, matching the class name they contain
- Use PascalCase for directory names
- Example: `Image.cs`, `Domain/Entities/`

### Code Style

#### Indentation
- Use 4 spaces for indentation (not tabs)
- Align code blocks consistently

#### Line Length
- Keep lines under 120 characters when possible
- Break long lines logically
- Prefer breaking after commas or operators
- Example:
  ```csharp
  // Good
  var images = await _imageRepository.GetByFolderIdAsync(
      folderId,
      includeMetadata: true,
      sortBy: ImageSortBy.CreatedDate,
      sortOrder: SortOrder.Descending);
  
  // Bad
  var images = await _imageRepository.GetByFolderIdAsync(folderId, includeMetadata: true, sortBy: ImageSortBy.CreatedDate, sortOrder: SortOrder.Descending);
  ```

#### Braces
- Use Allman style braces (each brace on its own line)
- Example:
  ```csharp
  public class MyClass
  {
      public void MyMethod()
      {
          // Code here
      }
  }
  ```

#### Comments
- Use XML documentation for public APIs
- Use single-line comments for internal explanations
- Avoid unnecessary comments
- Example:
  ```csharp
  /// <summary>
  /// Gets all images from the database
  /// </summary>
  /// <returns>List of images</returns>
  public async Task<IEnumerable<Image>> GetAllImagesAsync()
  {
      // This method returns all images without any filtering
      return await _dbContext.Images.ToListAsync();
  }
  ```

#### Empty Lines
- Use a single empty line between methods
- Use a single empty line between logical blocks within a method
- Avoid consecutive empty lines

#### Using Statements
- Sort using statements alphabetically
- Group using statements by namespace type (System.* first, then external libraries, then project-specific)
- Example:
  ```csharp
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Threading.Tasks;
  
  using Microsoft.EntityFrameworkCore;
  
  using AIGenManager.Core.Domain.Entities;
  using AIGenManager.Core.Application.Ports;
  ```

### Code Structure

#### Class Organization
1. Private fields
2. Public properties
3. Constructors
4. Public methods
5. Private methods
6. Static methods

#### Method Structure
- Validate parameters first
- Check for edge cases early
- Keep methods focused on a single responsibility
- Avoid long methods (prefer methods under 50 lines)

### Best Practices

#### Null Handling
- Use null-conditional operators (`?.`, `??`) when appropriate
- Validate nullable parameters
- Use `[NotNull]` and `[CanBeNull]` attributes for documentation
- Example:
  ```csharp
  public async Task<Image> GetImageByIdAsync(int id)
  {
      var image = await _imageRepository.GetByIdAsync(id);
      return image ?? throw new NotFoundException($"Image with ID {id} not found");
  }
  ```

#### Async/Await
- Use `async/await` for all asynchronous operations
- Name async methods with `Async` suffix
- Avoid mixing synchronous and asynchronous code unnecessarily
- Example:
  ```csharp
  // Good
  public async Task<IEnumerable<Image>> GetImagesAsync()
  {
      return await _imageRepository.GetAllAsync();
  }
  
  // Bad
  public IEnumerable<Image> GetImages()
  {
      return _imageRepository.GetAllAsync().Result;
  }
  ```

#### Dependency Injection
- Use constructor injection for all dependencies
- Avoid service locator pattern
- Example:
  ```csharp
  // Good
  public class ImageService
  {
      private readonly IImageRepository _imageRepository;
      
      public ImageService(IImageRepository imageRepository)
      {
          _imageRepository = imageRepository;
      }
  }
  
  // Bad
  public class ImageService
  {
      private readonly IImageRepository _imageRepository;
      
      public ImageService()
      {
          _imageRepository = ServiceLocator.Get<IImageRepository>();
      }
  }
  ```

#### Error Handling
- Use specific exception types rather than generic `Exception`
- Include meaningful error messages
- Avoid catching exceptions you can't handle
- Example:
  ```csharp
  // Good
  if (string.IsNullOrWhiteSpace(filePath))
      throw new ArgumentException("File path cannot be empty", nameof(filePath));
  
  // Bad
  try
  {
      // Code that might fail
  }
  catch (Exception ex)
  {
      Console.WriteLine("An error occurred");
  }
  ```

#### LINQ Usage
- Use method syntax for LINQ queries
- Avoid overly complex LINQ statements
- Use meaningful variable names for LINQ results
- Example:
  ```csharp
  // Good
  var recentImages = await _dbContext.Images
      .Where(i => i.CreatedDate > DateTime.UtcNow.AddDays(-7))
      .OrderByDescending(i => i.CreatedDate)
      .ToListAsync();
  
  // Bad
  var images = await _dbContext.Images.Where(i => i.CreatedDate > DateTime.UtcNow.AddDays(-7)).OrderByDescending(i => i.CreatedDate).ToListAsync();
  ```

## Architecture Standards

### Clean Architecture
- Follow Clean Architecture principles
- Dependencies flow from outer to inner layers
- Core layer has no dependencies on other layers
- Example layer dependencies:
  - Presentation → Application → Core ← Infrastructure

### Use Case Pattern
- Create a separate use case for each business operation
- Use cases should be simple and focused
- Use cases should only depend on repository interfaces
- Example:
  ```csharp
  public class GetAllImagesUseCase : UseCase<IEnumerable<Image>>
  {
      private readonly IImageRepository _imageRepository;
      
      public GetAllImagesUseCase(IImageRepository imageRepository)
      {
          _imageRepository = imageRepository;
      }
      
      public override async Task<IEnumerable<Image>> ExecuteAsync()
      {
          return await _imageRepository.GetAllAsync();
      }
  }
  ```

### Repository Pattern
- Implement repository interfaces from the Core layer
- Repositories should handle all data access
- Repositories should be injected into use cases
- Example:
  ```csharp
  public class SQLiteImageRepository : IImageRepository
  {
      private readonly DatabaseContext _dbContext;
      
      public SQLiteImageRepository(DatabaseContext dbContext)
      {
          _dbContext = dbContext;
      }
      
      // Implementation methods
  }
  ```

## MVVM Standards

### ViewModels
- Inherit from `ViewModelBase`
- Use `ObservableProperty` attribute for bindable properties
- Use `RelayCommand` or `AsyncRelayCommand` for commands
- Example:
  ```csharp
  [ObservableProperty]
  private string _imageName;
  
  [RelayCommand]
  private void SaveImage()
  {
      // Implementation here
  }
  
  [RelayCommand]
  private async Task LoadImagesAsync()
  {
      // Implementation here
  }
  ```

### Views
- Use XAML for UI definitions
- Bind to ViewModel properties
- Keep code-behind minimal
- Example:
  ```xaml
  <TextBlock Text="{Binding ImageName}" />
  <Button Content="Save" Command="{Binding SaveImageCommand}" />
  <Button Content="Load" Command="{Binding LoadImagesCommand}" />
  ```

### Code-Behind
- Avoid business logic in code-behind
- Use code-behind only for UI-specific logic
- Example:
  ```csharp
  public partial class MainWindow : Window
  {
      public MainWindow()
      {
          InitializeComponent();
          // UI-specific initialization only
      }
      
      private void Window_Closed(object sender, EventArgs e)
      {
          // UI-specific cleanup
      }
  }
  ```

## Dependency Injection

### Registration
- Register all dependencies in `ConfigureServices` method in `App.axaml.cs`
- Use appropriate lifetimes:
  - `Transient`: For use cases and view models
  - `Singleton`: For repositories and database context
  - `Scoped`: For per-request dependencies (not commonly used in desktop apps)

### Usage
- Inject dependencies via constructor
- Avoid service locator pattern
- Example:
  ```csharp
  public class GetAllImagesUseCase : UseCase<IEnumerable<Image>>
  {
      private readonly IImageRepository _imageRepository;
      
      public GetAllImagesUseCase(IImageRepository imageRepository)
      {
          _imageRepository = imageRepository;
      }
      
      // ExecuteAsync implementation
  }
  ```

## Database Standards

### SQLite
- Use SQLite for database storage
- Define entities with SQLite attributes
- Use parameterized queries to prevent SQL injection
- Example:
  ```csharp
  [Table("Images")]
  public class Image
  {
      [PrimaryKey, AutoIncrement]
      public int Id { get; set; }
      
      [Column("FilePath")]
      public string Path { get; set; }
      
      // Other properties
  }
  ```

### Entity Framework Core
- Use Entity Framework Core for ORM
- Follow EF Core best practices
- Use migrations for database schema changes
- Example:
  ```csharp
  public class DatabaseContext : DbContext
  {
      public DbSet<Image> Images { get; set; }
      public DbSet<Folder> Folders { get; set; }
      
      protected override void OnModelCreating(ModelBuilder modelBuilder)
      {
          // Configure relationships
          modelBuilder.Entity<ImageTag>()
              .HasKey(it => new { it.ImageId, it.TagId });
      }
  }
  ```

## Testing Standards

### Unit Tests
- Write unit tests for use cases
- Mock repository dependencies
- Use NUnit or xUnit for testing framework
- Example:
  ```csharp
  [TestFixture]
  public class GetAllImagesUseCaseTests
  {
      private GetAllImagesUseCase _useCase;
      private Mock<IImageRepository> _mockImageRepository;
      
      [SetUp]
      public void SetUp()
      {
          _mockImageRepository = new Mock<IImageRepository>();
          _useCase = new GetAllImagesUseCase(_mockImageRepository.Object);
      }
      
      [Test]
      public async Task ExecuteAsync_ReturnsImagesFromRepository()
      {
          // Arrange
          var expectedImages = new List<Image> { /* test images */ };
          _mockImageRepository.Setup(repo => repo.GetAllAsync())
              .ReturnsAsync(expectedImages);
          
          // Act
          var result = await _useCase.ExecuteAsync();
          
          // Assert
          Assert.That(result, Is.EqualTo(expectedImages));
          _mockImageRepository.Verify(repo => repo.GetAllAsync(), Times.Once);
      }
  }
  ```

### Integration Tests
- Test database operations with real SQLite database
- Test end-to-end functionality
- Example:
  ```csharp
  [TestFixture]
  public class SQLiteImageRepositoryTests
  {
      private SQLiteImageRepository _repository;
      private DatabaseContext _dbContext;
      
      [SetUp]
      public void SetUp()
      {
          // Use in-memory database
          var connectionString = "DataSource=:memory:";
          _dbContext = new DatabaseContext(connectionString);
          _dbContext.Database.OpenConnection();
          _dbContext.Database.EnsureCreated();
          
          _repository = new SQLiteImageRepository(_dbContext);
      }
      
      [Test]
      public async Task AddAsync_PersistsImage()
      {
          // Arrange
          var image = new Image("test.jpg", "test.jpg");
          
          // Act
          await _repository.AddAsync(image);
          
          // Assert
          var retrieved = await _repository.GetByIdAsync(image.Id);
          Assert.That(retrieved, Is.Not.Null);
          Assert.That(retrieved.FileName, Is.EqualTo("test.jpg"));
      }
  }
  ```

## File Organization

### Project Structure
- Follow the existing project structure
- Place new files in appropriate directories
- Keep related files together
- Example:
  ```
src/
├── Core/                # Domain models and interfaces
├── Application/         # Use cases and application logic
├── Infrastructure/      # Data access and external integrations
└── Presentation/        # UI components
  ```

### Naming Files
- Use descriptive names for files
- Follow naming conventions for use cases, repositories, etc.
- Example: `GetAllImagesUseCase.cs`, `SQLiteImageRepository.cs`

## Git Standards

### Commit Messages
- Use clear, descriptive commit messages
- Start with a verb
- Keep the first line under 50 characters
- Use the body for detailed explanations if needed
- Example: "Add GetAllImagesUseCase", "Fix image tagging bug", "Update coding standards document"

### Branching
- Use feature branches for new features
- Use bugfix branches for bug fixes
- Keep branches focused on a single issue
- Example branch names: `feature/add-album-support`, `bugfix/fix-image-import`, `docs/update-readme`

### Pull Requests
- Include descriptive title and description
- Reference related issues
- Ensure all tests pass
- Request review from appropriate team members
- Example PR title: "Implement album management features"

## Tooling

### IDE
- Use Visual Studio 2022 or Visual Studio Code
- Install recommended extensions:
  - C# extension
  - Avalonia extension
  - XML Documentation Comments
  - GitLens (for Git integration)
  - EditorConfig for VS Code

### Build Tools
- Use .NET CLI for building and running
- Example commands:
  - `dotnet build` - Build the project
  - `dotnet run --project src/Presentation/AIGenManager.Presentation.csproj` - Run the application
  - `dotnet test` - Run tests
  - `dotnet format` - Format code according to standards

### Code Analysis
- Use Roslyn analyzers for static code analysis
- Enable warnings as errors in the build configuration
- Use StyleCop or similar tools for style enforcement

## Documentation

### Code Documentation
- Use XML documentation for all public APIs
- Include summary, parameters, return values, and exceptions
- Example:
  ```csharp
  /// <summary>
  /// Gets an image by its unique identifier
  /// </summary>
  /// <param name="id">The unique identifier of the image</param>
  /// <returns>The image with the specified identifier</returns>
  /// <exception cref="NotFoundException">Thrown when no image is found with the specified identifier</exception>
  public async Task<Image> GetByIdAsync(int id)
  {
      // Implementation
  }
  ```

### README Files
- Include README.md files for major directories
- Document the purpose and usage of components
- Example: `src/Application/README.md` explaining use case organization

## Review Checklist

Before submitting code for review, ensure it meets these standards:
- [ ] Follows naming conventions
- [ ] Uses proper indentation and formatting
- [ ] Has appropriate comments and documentation
- [ ] Follows architectural principles
- [ ] Is properly tested
- [ ] Has meaningful commit messages
- [ ] Passes all build and test checks

## Conclusion

Following these coding standards will help maintain a high-quality codebase that is easy to understand, modify, and extend. All contributors are expected to adhere to these guidelines and help enforce them through code reviews.

---

*Last updated: January 2026*