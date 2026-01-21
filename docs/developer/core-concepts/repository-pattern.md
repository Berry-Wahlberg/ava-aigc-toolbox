# Repository Pattern

## Introduction

The Repository Pattern is a design pattern that abstracts the data access layer, providing a collection-like interface for accessing domain entities. In the AVA AIGC Toolbox, repositories act as intermediaries between the application layer (use cases) and the data persistence layer (database), allowing use cases to retrieve and persist entities without knowing the implementation details of the data storage.

## What is a Repository?

A repository is an abstraction that encapsulates the logic for retrieving, storing, and updating domain entities. It provides a clean, consistent interface for the application layer to interact with data sources, hiding the complexities of database operations, ORM frameworks, and SQL queries.

## Benefits of the Repository Pattern

1. **Separation of Concerns**: Separates data access logic from business logic
2. **Testability**: Allows use cases to be tested with mock repositories
3. **Flexibility**: Enables easy swapping of data storage implementations (e.g., SQLite to PostgreSQL)
4. **Consistency**: Provides a uniform interface for accessing different types of entities
5. **Abstraction**: Hides complex data access details from the application layer
6. **Maintainability**: Centralizes data access logic, making it easier to modify and maintain

## Repository Structure in AVA AIGC Toolbox

### 1. Repository Interfaces (Ports)

Repository interfaces are defined in the Core layer (domain layer), following the Dependency Rule of Clean Architecture. They specify the operations that can be performed on domain entities.

**Example Repository Interface:**

```csharp
public interface IImageRepository
{
    // CRUD operations
    Task<Image> GetByIdAsync(int id);
    Task<IEnumerable<Image>> GetAllAsync();
    Task AddAsync(Image image);
    Task UpdateAsync(Image image);
    Task DeleteAsync(int id);
    
    // Query operations
    Task<IEnumerable<Image>> GetByFolderIdAsync(int folderId);
    Task<IEnumerable<Image>> GetByAlbumIdAsync(int albumId);
    Task<Image> GetByFilePathAsync(string filePath);
    Task<int> GetTotalCountAsync();
}
```

### 2. Repository Implementations (Adapters)

Repository implementations are located in the Infrastructure layer and provide concrete implementations of the repository interfaces. They handle the actual data access logic using the database technology (SQLite in the case of AVA AIGC Toolbox).

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
        return await _dbContext.Images.FindAsync(id);
    }
    
    public async Task<IEnumerable<Image>> GetAllAsync()
    {
        return await _dbContext.Images.ToListAsync();
    }
    
    public async Task AddAsync(Image image)
    {
        await _dbContext.Images.AddAsync(image);
        await _dbContext.SaveChangesAsync();
    }
    
    public async Task UpdateAsync(Image image)
    {
        _dbContext.Images.Update(image);
        await _dbContext.SaveChangesAsync();
    }
    
    public async Task DeleteAsync(int id)
    {
        var image = await GetByIdAsync(id);
        if (image != null)
        {
            _dbContext.Images.Remove(image);
            await _dbContext.SaveChangesAsync();
        }
    }
    
    public async Task<IEnumerable<Image>> GetByFolderIdAsync(int folderId)
    {
        return await _dbContext.Images
            .Where(i => i.FolderId == folderId)
            .ToListAsync();
    }
    
    // Implement other methods...
}
```

## Repository Naming Convention

Repositories follow a consistent naming convention:

- **Interfaces**: `I{Entity}Repository.cs` (e.g., `IImageRepository.cs`)
- **Implementations**: `{Database}{Entity}Repository.cs` (e.g., `SQLiteImageRepository.cs`)

## Repository Operations

### 1. CRUD Operations

All repositories provide basic CRUD (Create, Read, Update, Delete) operations:

| Operation | Description |
|-----------|-------------|
| **Create** | Add a new entity to the data store |
| **Read** | Retrieve entities by ID, query, or other criteria |
| **Update** | Modify an existing entity |
| **Delete** | Remove an entity from the data store |

### 2. Query Operations

In addition to basic CRUD operations, repositories provide domain-specific query methods that return entities based on various criteria:

```csharp
// Get images by folder
Task<IEnumerable<Image>> GetByFolderIdAsync(int folderId);

// Get images by tag
Task<IEnumerable<Image>> GetByTagIdAsync(int tagId);

// Get images created in a date range
Task<IEnumerable<Image>> GetByDateRangeAsync(DateTime startDate, DateTime endDate);

// Search images by filename or metadata
Task<IEnumerable<Image>> SearchAsync(string searchTerm);
```

## Repository Registration

Repositories are registered with the dependency injection container in the application entry point:

```csharp
private void ConfigureServices(IServiceCollection services)
{
    // Register database context
    services.AddSingleton<DatabaseContext>(provider => 
        new DatabaseContext("Data Source=aigenmanager.db"));
    
    // Register repositories
    services.AddSingleton<IImageRepository, SQLiteImageRepository>();
    services.AddSingleton<IFolderRepository, SQLiteFolderRepository>();
    services.AddSingleton<IAlbumRepository, SQLiteAlbumRepository>();
    services.AddSingleton<ITagRepository, SQLiteTagRepository>();
    services.AddSingleton<IImageTagRepository, SQLiteImageTagRepository>();
    
    // Register other services...
}
```

## Usage in Use Cases

Repositories are injected into use cases via constructor injection:

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
        // Validation
        if (folderId <= 0)
            throw new ArgumentException("FolderId must be greater than zero", nameof(folderId));
        
        // Use repository to get images
        return await _imageRepository.GetByFolderIdAsync(folderId);
    }
}
```

## Transaction Management

In the AVA AIGC Toolbox, transactions are managed at the repository level, with each repository method being responsible for its own transaction:

```csharp
public async Task AddAsync(Image image)
{
    await _dbContext.Images.AddAsync(image);
    await _dbContext.SaveChangesAsync(); // Commits the transaction
}
```

For more complex operations that require multiple repository calls to be atomic, transactions can be managed explicitly:

```csharp
public async Task<Image> CreateImageWithTagsAsync(Image image, IEnumerable<string> tagNames)
{
    using var transaction = await _dbContext.Database.BeginTransactionAsync();
    
    try
    {
        // Add image
        await _dbContext.Images.AddAsync(image);
        await _dbContext.SaveChangesAsync();
        
        // Add tags and relationships
        foreach (var tagName in tagNames)
        {
            var tag = await _tagRepository.GetByNameAsync(tagName) ??
                     new Tag(tagName);
            
            if (tag.Id == 0)
            {
                await _dbContext.Tags.AddAsync(tag);
                await _dbContext.SaveChangesAsync();
            }
            
            var imageTag = new ImageTag(image.Id, tag.Id);
            await _dbContext.ImageTags.AddAsync(imageTag);
            await _dbContext.SaveChangesAsync();
        }
        
        await transaction.CommitAsync();
        return image;
    }
    catch (Exception)
    {
        await transaction.RollbackAsync();
        throw;
    }
}
```

## Repository Best Practices

### 1. Design Small, Focused Interfaces

Repository interfaces should be small and focused, containing only the methods that are actually needed by the application:

```csharp
// Good: Small, focused interface
public interface ITagRepository
{
    Task<Tag> GetByIdAsync(int id);
    Task<Tag> GetByNameAsync(string name);
    Task<IEnumerable<Tag>> GetAllAsync();
    Task AddAsync(Tag tag);
    Task UpdateAsync(Tag tag);
    Task DeleteAsync(int id);
}

// Bad: Large, unfocused interface with unused methods
public interface ITagRepository
{
    // CRUD operations
    Task<Tag> GetByIdAsync(int id);
    Task<Tag> GetByNameAsync(string name);
    Task<IEnumerable<Tag>> GetAllAsync();
    Task AddAsync(Tag tag);
    Task UpdateAsync(Tag tag);
    Task DeleteAsync(int id);
    
    // Unused methods
    Task<int> GetTagCountAsync();
    Task<IEnumerable<Tag>> GetTagsWithCountAsync();
    Task<IEnumerable<Tag>> GetPopularTagsAsync(int limit);
    Task<IEnumerable<Tag>> SearchTagsAsync(string searchTerm);
}
```

### 2. Return Domain Entities, Not DTOs

Repositories should return domain entities, not Data Transfer Objects (DTOs). The transformation from entities to DTOs should happen at a higher layer (e.g., in the presentation layer or in use cases).

```csharp
// Good: Returns domain entity
public async Task<Image> GetByIdAsync(int id)
{
    return await _dbContext.Images.FindAsync(id);
}

// Bad: Returns DTO directly
public async Task<ImageDto> GetImageDtoByIdAsync(int id)
{
    var image = await _dbContext.Images.FindAsync(id);
    return new ImageDto
    {
        Id = image.Id,
        FileName = image.FileName,
        // Other properties...
    };
}
```

### 3. Keep Repositories Technology-Agnostic

Repository interfaces should not leak implementation details of the data storage technology. They should be defined in terms of domain concepts, not database concepts.

```csharp
// Good: Technology-agnostic interface
public interface IImageRepository
{
    Task<IEnumerable<Image>> GetByFolderIdAsync(int folderId);
}

// Bad: Leaks database implementation details
public interface IImageRepository
{
    Task<IEnumerable<Image>> GetImagesWhereFolderIdEqualsAsync(int folderId);
    Task<IEnumerable<Image>> ExecuteSqlQueryAsync(string sql, params object[] parameters);
}
```

### 4. Use Async Methods

All repository methods that perform I/O operations should be asynchronous to avoid blocking the main thread:

```csharp
// Good: Async method
public async Task<Image> GetByIdAsync(int id)
{
    return await _dbContext.Images.FindAsync(id);
}

// Bad: Synchronous method
public Image GetById(int id)
{
    return _dbContext.Images.Find(id);
}
```

### 5. Implement Pagination for Large Result Sets

For methods that return large collections, implement pagination to improve performance:

```csharp
// Good: Pagination support
public async Task<(IEnumerable<Image>, int)> GetPaginatedAsync(int page, int pageSize)
{
    var totalCount = await _dbContext.Images.CountAsync();
    var images = await _dbContext.Images
        .Skip((page - 1) * pageSize)
        .Take(pageSize)
        .ToListAsync();
    
    return (images, totalCount);
}

// Bad: No pagination (returns all images)
public async Task<IEnumerable<Image>> GetAllAsync()
{
    return await _dbContext.Images.ToListAsync();
}
```

## Testing Repositories

### 1. Unit Testing Use Cases with Mock Repositories

Use cases can be tested with mock repositories, allowing them to be tested in isolation without a real database:

```csharp
[TestFixture]
public class GetImagesByFolderIdUseCaseTests
{
    private GetImagesByFolderIdUseCase _useCase;
    private Mock<IImageRepository> _mockImageRepository;
    
    [SetUp]
    public void SetUp()
    {
        _mockImageRepository = new Mock<IImageRepository>();
        _useCase = new GetImagesByFolderIdUseCase(_mockImageRepository.Object);
    }
    
    [Test]
    public async Task ExecuteAsync_ReturnsImagesForValidFolderId()
    {
        // Arrange
        var folderId = 1;
        var expectedImages = new List<Image>
        {
            new Image("path1.jpg", "image1.jpg", 1000, 100, 100) { Id = 1, FolderId = folderId },
            new Image("path2.jpg", "image2.jpg", 2000, 200, 200) { Id = 2, FolderId = folderId }
        };
        
        _mockImageRepository.Setup(repo => repo.GetByFolderIdAsync(folderId))
            .ReturnsAsync(expectedImages);
        
        // Act
        var result = await _useCase.ExecuteAsync(folderId);
        
        // Assert
        Assert.That(result, Is.EqualTo(expectedImages));
        _mockImageRepository.Verify(repo => repo.GetByFolderIdAsync(folderId), Times.Once);
    }
}
```

### 2. Integration Testing Repositories

Repositories can be tested with a real database to ensure that the data access logic works correctly:

```csharp
[TestFixture]
public class SQLiteImageRepositoryTests
{
    private SQLiteImageRepository _repository;
    private DatabaseContext _dbContext;
    private string _connectionString;
    
    [SetUp]
    public void SetUp()
    {
        // Use in-memory SQLite database for testing
        _connectionString = "DataSource=:memory:";
        _dbContext = new DatabaseContext(_connectionString);
        _dbContext.Database.OpenConnection();
        _dbContext.Database.EnsureCreated();
        
        _repository = new SQLiteImageRepository(_dbContext);
    }
    
    [TearDown]
    public void TearDown()
    {
        _dbContext.Database.CloseConnection();
        _dbContext.Dispose();
    }
    
    [Test]
    public async Task AddAsync_PersistsImage()
    {
        // Arrange
        var image = new Image("test.jpg", "test.jpg", 1000, 100, 100);
        
        // Act
        await _repository.AddAsync(image);
        
        // Assert
        var retrievedImage = await _repository.GetByIdAsync(image.Id);
        Assert.That(retrievedImage, Is.Not.Null);
        Assert.That(retrievedImage.FilePath, Is.EqualTo(image.FilePath));
    }
}
```

## Repository Pattern vs. Other Data Access Patterns

### Repository Pattern vs. Data Access Object (DAO)

- **Repository Pattern**: Focuses on domain entities and provides a collection-like interface
- **DAO Pattern**: Focuses on database operations and provides a low-level interface to the database

The Repository Pattern is more aligned with Domain-Driven Design, as it operates on domain entities and hides database implementation details.

### Repository Pattern vs. Active Record

- **Repository Pattern**: Separates domain entities from data access logic
- **Active Record**: Combines domain entities with data access logic (entities have save(), update(), delete() methods)

The Repository Pattern provides better separation of concerns, making it more suitable for complex applications with rich domain models.

## Conclusion

The Repository Pattern is a fundamental component of the AVA AIGC Toolbox architecture, providing a clean, consistent interface for accessing domain entities. By abstracting the data access layer, the Repository Pattern enables the application layer to focus on business logic, while maintaining flexibility and testability.

The implementation of the Repository Pattern in the AVA AIGC Toolbox follows Clean Architecture principles, with repository interfaces defined in the Core layer and implementations in the Infrastructure layer. This ensures that the domain layer remains independent of external dependencies, allowing for easy modification and extension of the application.

---

*Last updated: January 2026*