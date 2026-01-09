# Coding Standards

## Overview
This document outlines the coding standards for the AVA AIGC Toolbox project. All contributors must follow these guidelines to ensure code consistency and maintainability.

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

### Code Style

#### Indentation
- Use 4 spaces for indentation (not tabs)
- Align code blocks consistently

#### Line Length
- Keep lines under 120 characters when possible
- Break long lines logically

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
      // Implementation here
  }
  ```

## Architecture Standards

### Clean Architecture
- Follow clean architecture principles
- Dependencies flow from outer to inner layers
- Core layer has no dependencies on other layers

### Use Case Pattern
- Create a separate use case for each business operation
- Use cases should be simple and focused
- Use cases should only depend on repository interfaces

### Repository Pattern
- Implement repository interfaces from the Core layer
- Repositories should handle all data access
- Repositories should be injected into use cases

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
  ```

### Views
- Use XAML for UI definitions
- Bind to ViewModel properties
- Keep code-behind minimal
- Example:
  ```xaml
  <TextBlock Text="{Binding ImageName}" />
  <Button Content="Save" Command="{Binding SaveImageCommand}" />
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
      
      // Implementation
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
      
      [Column("FileName")]
      public string FileName { get; set; }
      
      // Other properties
  }
  ```

## Testing Standards

### Unit Tests
- Write unit tests for use cases
- Mock repository dependencies
- Use NUnit or xUnit for testing framework

### Integration Tests
- Test database operations with real SQLite database
- Test end-to-end functionality

## File Organization

### Project Structure
- Follow the existing project structure
- Place new files in appropriate directories
- Keep related files together

### Naming Files
- Use descriptive names for files
- Follow naming conventions for use cases, repositories, etc.
- Example: `GetAllImagesUseCase.cs`, `SQLiteImageRepository.cs`

## Git Standards

### Commit Messages
- Use clear, descriptive commit messages
- Start with a verb
- Example: "Add GetAllImagesUseCase", "Fix image tagging bug"

### Branching
- Use feature branches for new features
- Use bugfix branches for bug fixes
- Keep branches focused on a single issue

### Pull Requests
- Include descriptive title and description
- Reference related issues
- Ensure all tests pass

## Tooling

### IDE
- Use Visual Studio or Visual Studio Code
- Install recommended extensions:
  - C# extension
  - Avalonia extension
  - XML Documentation Comments

### Build Tools
- Use .NET CLI for building and running
- Example commands:
  - `dotnet build` - Build the project
  - `dotnet run --project src/Presentation/AIGenManager.Presentation.csproj` - Run the application
  - `dotnet test` - Run tests

## Conclusion
Following these coding standards will help maintain a high-quality codebase that is easy to understand, modify, and extend. All contributors are expected to adhere to these guidelines.