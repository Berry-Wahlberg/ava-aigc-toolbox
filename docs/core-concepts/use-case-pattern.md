# Use Case Pattern

## Introduction

The Use Case Pattern is a design pattern that encapsulates a single business operation or workflow. In the AVA AIGC Toolbox, use cases form the core of the Application layer, providing a clear, testable, and maintainable way to implement business logic.

## What is a Use Case?

A use case represents a specific action that a user can perform with the application. It encapsulates all the logic required to execute that action, including validation, data retrieval, business rule enforcement, and data persistence.

## Benefits of the Use Case Pattern

1. **Separation of Concerns**: Each use case focuses on a single business operation
2. **Testability**: Use cases can be tested in isolation with mock dependencies
3. **Maintainability**: Small, focused use cases are easier to understand and modify
4. **Flexibility**: Use cases can be composed to create more complex workflows
5. **Clear Interface**: Use cases provide a well-defined API for the presentation layer
6. **Business Focus**: Use cases are named and structured around business operations, not technical implementation

## Use Case Structure in AVA AIGC Toolbox

### 1. Base Use Case Classes

All use cases inherit from one of two base classes:

```csharp
/// <summary>
/// Base class for use cases that don't require input parameters
/// </summary>
/// <typeparam name="TOutput">The type of output produced by the use case</typeparam>
public abstract class UseCase<TOutput>
{
    protected UseCase()
    {
    }
    
    /// <summary>
    /// Executes the use case
    /// </summary>
    /// <returns>The result of the use case execution</returns>
    public abstract Task<TOutput> ExecuteAsync();
}

/// <summary>
/// Base class for use cases that require input parameters
/// </summary>
/// <typeparam name="TInput">The type of input required by the use case</typeparam>
/// <typeparam name="TOutput">The type of output produced by the use case</typeparam>
public abstract class UseCase<TInput, TOutput>
{
    protected UseCase()
    {
    }
    
    /// <summary>
    /// Executes the use case with the given input
    /// </summary>
    /// <param name="input">The input parameters for the use case</param>
    /// <returns>The result of the use case execution</returns>
    public abstract Task<TOutput> ExecuteAsync(TInput input);
}
```

### 2. Use Case Organization

Use cases are organized by feature area in the `UseCases` directory:

```
src/Application/UseCases/
├── Albums/            # Album-related use cases
├── Folders/           # Folder-related use cases  
├── Images/            # Image-related use cases
├── Tags/              # Tag-related use cases
└── BaseUseCases.cs    # Base classes for all use cases
```

### 3. Use Case Naming Convention

Use cases follow a consistent naming convention:

```
{Action}{Entity}{UseCase}.cs
```

**Examples:**

- `GetAllImagesUseCase.cs`
- `AddTagToImageUseCase.cs`
- `GetImagesByAlbumIdUseCase.cs`

### 4. Input/Output Models

Use cases use dedicated input and output models to encapsulate data:

```csharp
/// <summary>
/// Input model for AddTagToImageUseCase
/// </summary>
public class AddTagToImageInput
{
    public int ImageId { get; set; }
    public string TagName { get; set; }
}
```

## Use Case Implementation

### 1. Constructor Injection

Use cases receive their dependencies via constructor injection:

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

### 2. ExecuteAsync Method

The `ExecuteAsync` method contains the core business logic:

```csharp
public override async Task<IEnumerable<Image>> ExecuteAsync()
{
    // 1. Retrieve all images from the repository
    var images = await _imageRepository.GetAllAsync();
    
    // 2. Any additional business logic would go here
    // For example, sorting, filtering, or transformation
    
    // 3. Return the result
    return images.OrderByDescending(i => i.CreatedAt);
}
```

### 3. Validation

Input validation is performed at the beginning of the `ExecuteAsync` method:

```csharp
public override async Task<bool> ExecuteAsync(AddTagToImageInput input)
{
    // Validate input
    if (input.ImageId <= 0)
        throw new ArgumentException("ImageId must be greater than zero", nameof(input.ImageId));
    
    if (string.IsNullOrWhiteSpace(input.TagName))
        throw new ArgumentException("TagName cannot be empty", nameof(input.TagName));
    
    // Rest of the implementation
}
```

### 4. Error Handling

Use cases can handle errors explicitly and return appropriate results, or they can throw exceptions that are caught by the presentation layer:

```csharp
public override async Task<Image> ExecuteAsync(int imageId)
{
    var image = await _imageRepository.GetByIdAsync(imageId);
    
    if (image == null)
        throw new NotFoundException($"Image with ID {imageId} not found");
    
    return image;
}
```

## Use Case Examples

### 1. Simple Use Case: Get All Images

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

### 2. Use Case with Input: Add Tag to Image

```csharp
public class AddTagToImageUseCase : UseCase<AddTagToImageInput, bool>
{
    private readonly IImageTagRepository _imageTagRepository;
    private readonly ITagRepository _tagRepository;
    private readonly IImageRepository _imageRepository;
    
    public AddTagToImageUseCase(
        IImageTagRepository imageTagRepository,
        ITagRepository tagRepository,
        IImageRepository imageRepository)
    {
        _imageTagRepository = imageTagRepository;
        _tagRepository = tagRepository;
        _imageRepository = imageRepository;
    }
    
    public override async Task<bool> ExecuteAsync(AddTagToImageInput input)
    {
        // Validate input
        if (input.ImageId <= 0 || string.IsNullOrWhiteSpace(input.TagName))
            return false;
        
        // Check if image exists
        var image = await _imageRepository.GetByIdAsync(input.ImageId);
        if (image == null)
            return false;
        
        // Get or create tag
        var tag = await _tagRepository.GetByNameAsync(input.TagName) ??
                  new Tag(input.TagName);
        
        if (tag.Id == 0)
            await _tagRepository.AddAsync(tag);
        
        // Check if relationship already exists
        var existingRelationship = await _imageTagRepository.GetByImageIdAndTagIdAsync(
            input.ImageId, tag.Id);
        
        if (existingRelationship != null)
            return true; // Relationship already exists
        
        // Create image-tag relationship
        var imageTag = new ImageTag(input.ImageId, tag.Id);
        await _imageTagRepository.AddAsync(imageTag);
        
        return true;
    }
}
```

### 3. Complex Use Case: Import Images from Folder

```csharp
public class ImportImagesFromFolderUseCase : UseCase<ImportImagesInput, ImportImagesResult>
{
    private readonly IFolderRepository _folderRepository;
    private readonly IImageRepository _imageRepository;
    private readonly IImageService _imageService;
    
    public ImportImagesFromFolderUseCase(
        IFolderRepository folderRepository,
        IImageRepository imageRepository,
        IImageService imageService)
    {
        _folderRepository = folderRepository;
        _imageRepository = imageRepository;
        _imageService = imageService;
    }
    
    public override async Task<ImportImagesResult> ExecuteAsync(ImportImagesInput input)
    {
        // Validate input
        if (!Directory.Exists(input.FolderPath))
            throw new DirectoryNotFoundException($"Folder not found: {input.FolderPath}");
        
        // Create result object to track import progress
        var result = new ImportImagesResult
        {
            TotalImages = 0,
            ImportedImages = 0,
            FailedImages = 0,
            Errors = new List<string>()
        };
        
        // Get or create folder in database
        var folder = await _folderRepository.GetByPathAsync(input.FolderPath) ??
                     new Folder(input.FolderPath);
        
        if (folder.Id == 0)
            await _folderRepository.AddAsync(folder);
        
        // Get all image files from the folder
        var imageFiles = _imageService.GetImageFiles(input.FolderPath);
        result.TotalImages = imageFiles.Count;
        
        // Import each image
        foreach (var filePath in imageFiles)
        {
            try
            {
                // Check if image already exists
                var existingImage = await _imageRepository.GetByFilePathAsync(filePath);
                if (existingImage != null)
                {
                    if (input.OverwriteExisting)
                    {
                        // Update existing image
                        await UpdateExistingImage(existingImage, filePath);
                        result.ImportedImages++;
                    }
                    continue; // Skip if not overwriting
                }
                
                // Create new image
                var imageInfo = _imageService.GetImageInfo(filePath);
                var image = new Image(
                    filePath,
                    Path.GetFileName(filePath),
                    imageInfo.FileSize,
                    imageInfo.Width,
                    imageInfo.Height
                );
                
                image.FolderId = folder.Id;
                
                // Extract AI metadata if available
                var aiMetadata = _imageService.ExtractAIMetadata(filePath);
                if (aiMetadata != null)
                {
                    image.Prompt = aiMetadata.Prompt;
                    image.NegativePrompt = aiMetadata.NegativePrompt;
                    image.Steps = aiMetadata.Steps;
                    // Set other metadata properties
                }
                
                // Save image to database
                await _imageRepository.AddAsync(image);
                result.ImportedImages++;
            }
            catch (Exception ex)
            {
                result.FailedImages++;
                result.Errors.Add($"Failed to import {filePath}: {ex.Message}");
            }
        }
        
        return result;
    }
    
    private async Task UpdateExistingImage(Image existingImage, string filePath)
    {
        // Implementation for updating existing images
    }
}
```

## Use Case Execution Flow

1. **Presentation Layer**: The view model calls the use case with appropriate input
2. **Input Validation**: The use case validates the input parameters
3. **Data Retrieval**: The use case retrieves any required data from repositories
4. **Business Logic**: The use case executes the core business logic
5. **Data Persistence**: The use case saves any changes to repositories
6. **Result Return**: The use case returns the result to the presentation layer
7. **UI Update**: The view model updates the UI with the result

## Testing Use Cases

Use cases are highly testable due to their dependency injection design:

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
        var expectedImages = new List<Image>
        {
            new Image("path1.jpg", "image1.jpg", 1000, 100, 100),
            new Image("path2.jpg", "image2.jpg", 2000, 200, 200)
        };
        
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

## Best Practices for Use Cases

1. **Single Responsibility**: Each use case should focus on a single business operation
2. **Small Size**: Keep use cases small and focused
3. **Clear Naming**: Use descriptive names that reflect the business operation
4. **Input Validation**: Validate all input parameters at the beginning of the use case
5. **Error Handling**: Implement appropriate error handling and return meaningful results
6. **No UI Logic**: Use cases should not contain any UI-related logic
7. **No Infrastructure Details**: Use cases should depend on abstractions, not concrete implementations
8. **Testability**: Design use cases to be easily testable with mock dependencies
9. **Consistent Return Types**: Use consistent return types for similar use cases
10. **Documentation**: Document the purpose and behavior of each use case

## Conclusion

The Use Case Pattern is a fundamental building block of the AVA AIGC Toolbox architecture. By encapsulating business operations in focused, testable use cases, we've created a maintainable and flexible codebase that can easily adapt to changing requirements.

The use case pattern ensures that our business logic is well-organized, easy to understand, and decoupled from the presentation and infrastructure layers, which is essential for a large-scale application.

---

*Last updated: January 2026*
