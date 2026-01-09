# Tags Use Cases Skills

## 1. Core Responsibility
- Implements business operations related to tag management, including tag creation, retrieval, and image-tag association management.

## 2. Core Development Rules
1. **Naming Conventions**: 
   - Use case class name: `{Operation}TagUseCase.cs` or `{Operation}TagToImageUseCase.cs`
   - Example: `AddTagUseCase.cs`, `AddTagToImageUseCase.cs`
2. **Repository Usage**: 
   - Primary repositories: `ITagRepository` for tag operations, `IImageTagRepository` for image-tag relationships
   - No direct dependencies on image repositories
3. **Implementation Standards**: 
   - Inherit from `BaseUseCases<T>`
   - Return only Tag or IEnumerable<Tag> domain objects
   - Handle invalid tag/image IDs with descriptive exceptions
   - Use constructor injection for all dependencies
4. **Domain-Specific Rules**: 
   - Tag names must be unique and non-empty
   - Maximum 50 tags per image
   - Tag names limited to 50 characters
5. **Dependency Injection**: 
   - Register all tag use cases as Transient in `App.axaml.cs`

## 3. Common Patterns
### Image Tagging Use Case Pattern
```csharp
public class AddTagToImageUseCase : BaseUseCases<bool>
{
    private readonly IImageTagRepository _imageTagRepository;
    private readonly int _imageId;
    private readonly int _tagId;
    
    public AddTagToImageUseCase(IImageTagRepository imageTagRepository, int imageId, int tagId)
    {
        _imageTagRepository = imageTagRepository;
        _imageId = imageId;
        _tagId = tagId;
    }
    
    public override async Task<bool> ExecuteAsync()
    {
        // Validate inputs
        if (_imageId <= 0 || _tagId <= 0)
            throw new ArgumentException("Invalid image or tag ID");
        
        // Add tag to image
        await _imageTagRepository.AddTagToImageAsync(_imageId, _tagId);
        return true;
    }
}
```

## 4. Capability List
- Tag creation and retrieval operations
- Image-tag association and dissociation
- Tag filtering by image
- Multiple tag management per image

## 5. Skill Loading Rules
- No subdirectories in Tags, all skills loaded from this file