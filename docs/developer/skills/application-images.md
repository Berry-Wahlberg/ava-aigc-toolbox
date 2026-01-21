# Images Use Cases Skills

## 1. Core Responsibility
- Implements business operations related to image management, including retrieval by various criteria and integration with folder, tag, and album systems.

## 2. Core Development Rules
1. **Naming Conventions**: 
   - Use case class name: `{Operation}ImagesUseCase.cs` or `{Operation}ImagesBy{Criteria}UseCase.cs`
   - Example: `GetAllImagesUseCase.cs`, `GetImagesByFolderIdUseCase.cs`
2. **Repository Usage**: 
   - Primary repository: `IImageRepository` for all image operations
   - No direct dependencies on other domain repositories
3. **Implementation Standards**: 
   - Inherit from `BaseUseCases<T>`
   - Return only IEnumerable<Image> domain objects
   - Handle invalid folder IDs with descriptive exceptions
   - Use constructor injection for all dependencies
4. **Domain-Specific Rules**: 
   - Image file paths must be valid and accessible
   - Images must belong to exactly one folder
   - Maximum image size: 10MB per image
5. **Dependency Injection**: 
   - Register all image use cases as Transient in `App.axaml.cs`

## 3. Common Patterns
### Image Retrieval Use Case Pattern
```csharp
public class GetImagesByFolderIdUseCase : BaseUseCases<IEnumerable<Image>>
{
    private readonly IImageRepository _imageRepository;
    private readonly int _folderId;
    
    public GetImagesByFolderIdUseCase(IImageRepository imageRepository, int folderId)
    {
        _imageRepository = imageRepository;
        _folderId = folderId;
    }
    
    public override async Task<IEnumerable<Image>> ExecuteAsync()
    {
        // Validate input
        if (_folderId <= 0)
            throw new ArgumentException("Invalid folder ID");
        
        // Retrieve images by folder ID
        return await _imageRepository.GetImagesByFolderIdAsync(_folderId);
    }
}
```

## 4. Capability List
- All-images retrieval functionality
- Folder-based image filtering
- Image metadata access and management
- Integration with folder, tag, and album systems
- Large image collection handling

## 5. Skill Loading Rules
- No subdirectories in Images, all skills loaded from this file