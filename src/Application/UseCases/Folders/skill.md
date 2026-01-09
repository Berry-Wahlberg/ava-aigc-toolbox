# Folders Use Cases Skills

## 1. Core Responsibility
- Implements business operations related to folder management, including retrieval of folder structures and integration with image browsing functionality.

## 2. Core Development Rules
1. **Naming Conventions**: 
   - Use case class name: `{Operation}FoldersUseCase.cs`
   - Example: `GetAllFoldersUseCase.cs`, `GetRootFoldersUseCase.cs`
2. **Repository Usage**: 
   - Primary repository: `IFolderRepository` for all folder operations
   - No direct image repository dependencies
3. **Implementation Standards**: 
   - Inherit from `BaseUseCases<T>`
   - Return only IEnumerable<Folder> domain objects
   - Proper error handling for invalid folder operations
   - Use constructor injection for all dependencies
4. **Domain-Specific Rules**: 
   - Root folders have null or empty ParentId
   - Folder names must be unique within their parent folder
   - Maximum folder depth: 10 levels
5. **Dependency Injection**: 
   - Register all folder use cases as Transient in `App.axaml.cs`

## 3. Common Patterns
### Folder Retrieval Use Case Pattern
```csharp
public class GetRootFoldersUseCase : BaseUseCases<IEnumerable<Folder>>
{
    private readonly IFolderRepository _folderRepository;
    
    public GetRootFoldersUseCase(IFolderRepository folderRepository)
    {
        _folderRepository = folderRepository;
    }
    
    public override async Task<IEnumerable<Folder>> ExecuteAsync()
    {
        // Retrieve all folders and filter to only root folders
        var allFolders = await _folderRepository.GetAllAsync();
        return allFolders.Where(folder => string.IsNullOrEmpty(folder.ParentId)).ToList();
    }
}
```

## 4. Capability List
- Root folder retrieval for navigation
- Complete folder structure access
- Folder hierarchy management
- Integration with image browsing workflows
- Support for folder-based image organization

## 5. Skill Loading Rules
- No subdirectories in Folders, all skills loaded from this file