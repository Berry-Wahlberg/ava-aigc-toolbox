# Albums Use Cases Skills

## 1. Core Responsibility
- Implements business operations related to album management, including creation, retrieval, and image association with albums.

## 2. Core Development Rules
1. **Naming Conventions**: 
   - Use case class name: `{Operation}AlbumUseCase` or `{Operation}ImageToAlbumUseCase`
   - Example: `AddAlbumUseCase.cs`, `AddImageToAlbumUseCase.cs`
2. **Repository Usage**: 
   - Primary repository: `IAlbumRepository` for all album operations
   - Additional repository: `IImageRepository` for image-related album operations
3. **Implementation Standards**: 
   - Inherit from `BaseUseCases<T>`
   - Return only Album or IEnumerable<Image> domain objects
   - Handle invalid album IDs with descriptive exceptions
   - Use constructor injection for all dependencies
4. **Domain-Specific Rules**: 
   - Album name must be unique and non-empty
   - Album creation requires only name (other fields optional)
   - Image-album associations require valid image and album IDs
   - Maximum 1000 images per album
5. **Dependency Injection**: 
   - Register all album use cases as Transient in `App.axaml.cs`

## 3. Common Patterns
### Album Creation Use Case Pattern
```csharp
public class AddAlbumUseCase : BaseUseCases<Album>
{
    private readonly IAlbumRepository _albumRepository;
    
    public AddAlbumUseCase(IAlbumRepository albumRepository)
    {
        _albumRepository = albumRepository;
    }
    
    public override async Task<Album> ExecuteAsync(Album album)
    {
        // Validate album input
        if (string.IsNullOrWhiteSpace(album.Name))
            throw new ArgumentException("Album name cannot be empty");
        
        // Check for duplicate album name
        var existingAlbums = await _albumRepository.GetAllAsync();
        if (existingAlbums.Any(a => a.Name == album.Name))
            throw new InvalidOperationException("Album with this name already exists");
        
        // Create the album
        return await _albumRepository.AddAsync(album);
    }
}
```

## 4. Capability List
- Album creation and retrieval operations
- Image-album association management
- Album image retrieval by album ID
- Album metadata management

## 5. Skill Loading Rules
- No subdirectories in Albums, all skills loaded from this file