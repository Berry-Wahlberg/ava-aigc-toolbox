# Repository Ports Skills

## 1. Core Responsibility
- Defines repository interfaces that specify data access contracts, enabling dependency inversion and separating domain logic from infrastructure implementation.

## 2. Core Development Rules
1. **Naming Conventions**: 
   - Interface name: `I{EntityName}Repository` (e.g., `IImageRepository`, `ITagRepository`)
   - Method names: PascalCase verb + EntityName (optional) + Async suffix
   - Example: `GetAllImagesAsync`, `AddAlbumAsync`
   - Parameter names: Descriptive, camelCase (e.g., `imageId`, `folderPath`)
2. **Interface Design**: 
   - Focus on single entity type per repository
   - Include only necessary CRUD and domain-specific query methods
   - All methods must be async (return Task<T> or Task)
   - Return domain objects only, never infrastructure-specific types
   - No implementation details in interfaces
3. **CRUD Method Requirements**: 
   - Mandatory: `GetByIdAsync(int id)`, `GetAllAsync()`
   - Mandatory: `AddAsync(T entity)`, `UpdateAsync(T entity)`, `DeleteAsync(int id)`
   - CRUD methods follow consistent naming pattern
4. **Domain-Specific Queries**: 
   - Add only queries required by business use cases
   - Use method names that reflect business intent, not technical implementation
   - Example: `GetImagesByTagAsync(int tagId)` instead of `GetImagesWhereTagIdEqualsAsync(int tagId)`
5. **Interface Stability**: 
   - Changes to existing interfaces must maintain backward compatibility
   - Add new methods instead of modifying existing ones
   - Document breaking changes if unavoidable

## 3. Common Patterns
### Basic Repository Interface Pattern
```csharp
public interface IEntityRepository
{
    // Basic CRUD operations
    Task<Entity> GetByIdAsync(int id);
    Task<IEnumerable<Entity>> GetAllAsync();
    Task AddAsync(Entity entity);
    Task UpdateAsync(Entity entity);
    Task DeleteAsync(int id);
    
    // Domain-specific query method
    Task<IEnumerable<Entity>> GetByPropertyAsync(string propertyValue);
}
```

### Relationship Query Pattern
```csharp
public interface IImageRepository
{
    // Basic CRUD
    Task<Image> GetByIdAsync(int imageId);
    Task<IEnumerable<Image>> GetAllAsync();
    Task AddAsync(Image image);
    Task UpdateAsync(Image image);
    Task DeleteAsync(int imageId);
    
    // Relationship-specific queries
    Task<IEnumerable<Image>> GetByFolderIdAsync(int folderId);
    Task<IEnumerable<Image>> GetByAlbumIdAsync(int albumId);
    Task<IEnumerable<Image>> GetByTagIdAsync(int tagId);
}
```

## 4. Capability List
- Repository interface definition and design
- Data access abstraction for domain layer
- Async method signature requirements
- Domain-specific query method specification
- Entity-specific CRUD operation definition
- Relationship query pattern implementation

## 5. Skill Loading Rules
- No subdirectories in Ports, all skills loaded from this file