# Domain-Driven Design (DDD)

## Introduction

Domain-Driven Design (DDD) is an approach to software development that emphasizes collaboration between technical and domain experts to create a deep understanding of the problem domain. The AVA AIGC Toolbox applies DDD principles to ensure the software accurately models the AI-generated image management domain.

## Key DDD Concepts

### 1. Ubiquitous Language

The ubiquitous language is a common language shared by all team members, including developers, domain experts, and stakeholders. It's used in code, documentation, and conversations to ensure everyone has the same understanding of the domain.

**Example Terms in AVA AIGC Toolbox:**

| Term | Definition |
|------|------------|
| **Image** | An AI-generated image file with associated metadata |
| **Folder** | A filesystem directory containing images |
| **Album** | A user-created collection of images (may cross folder boundaries) |
| **Tag** | A keyword used to categorize and search for images |
| **Model** | An AI model used to generate images |
| **Metadata** | Information about an image, including AI generation parameters |

### 2. Domain Model

The domain model is a conceptual representation of the domain, consisting of entities, value objects, aggregates, and domain services. It captures the core business logic and rules.

### 3. Entities

Entities are objects that have a distinct identity and lifecycle. They encapsulate business logic and enforce invariants.

**Examples in AVA AIGC Toolbox:**

- `Image`
- `Folder`
- `Album`
- `Tag`
- `Model`

**Key Characteristics:**

- Have a unique identifier
- Are mutable
- Encapsulate business logic
- Enforce invariants

**Example Entity:**

```csharp
public class Image
{
    public int Id { get; private set; }
    public string FilePath { get; private set; }
    public string FileName { get; private set; }
    // Other properties...
    
    public void UpdateMetadata(string newFileName)
    {
        // Validate and update metadata
    }
}
```

### 4. Value Objects

Value objects are immutable objects that represent descriptive aspects of the domain without identity. They are defined by their attributes.

**Examples in AVA AIGC Toolbox:**

- `TagCount`
- `ImageDimensions` (conceptual, not yet implemented)

**Key Characteristics:**

- Immutable
- No unique identifier
- Defined by their attributes
- Can be used as attributes of entities
- Implement equality based on attribute values

**Example Value Object:**

```csharp
public class TagCount
{
    public string TagName { get; }
    public int Count { get; }
    
    public TagCount(string tagName, int count)
    {
        // Validation logic
    }
    
    // Equality based on attributes
    public override bool Equals(object obj)
    {
        // Implementation
    }
    
    public override int GetHashCode()
    {
        // Implementation
    }
}
```

### 5. Aggregates and Aggregate Roots

An aggregate is a cluster of related entities and value objects that are treated as a single unit for data changes. The aggregate root is the main entity that acts as the entry point to the aggregate.

**Aggregates in AVA AIGC Toolbox:**

1. **Image Aggregate**
   - Root: `Image`
   - Related entities: None (ImageTag is a separate aggregate)
   - Value objects: None

2. **Album Aggregate**
   - Root: `Album`
   - Related entities: None (album-image relationships are handled separately)
   - Value objects: None

3. **Tag Aggregate**
   - Root: `Tag`
   - Related entities: None (ImageTag is a separate aggregate)
   - Value objects: None

4. **Folder Aggregate**
   - Root: `Folder`
   - Related entities: None (folder-image relationships are direct)
   - Value objects: None

5. **ImageTag Aggregate**
   - Root: `ImageTag` (join entity)
   - Related entities: Links to `Image` and `Tag` aggregates

**Aggregate Rules:**

- All changes to aggregate members must go through the aggregate root
- Aggregate roots maintain invariants for the entire aggregate
- References between aggregates should be by identity only

### 6. Repositories

Repositories are abstractions that provide access to aggregates. They encapsulate the logic for retrieving and persisting aggregates.

**Repository Interfaces in AVA AIGC Toolbox:**

- `IImageRepository`
- `IAlbumRepository`
- `ITagRepository`
- `IFolderRepository`
- `IImageTagRepository`

**Repository Responsibilities:**

- Retrieve aggregates by identity
- Persist new aggregates
- Update existing aggregates
- Delete aggregates
- Provide query methods for common use cases

**Example Repository Method:**

```csharp
public interface IImageRepository
{
    Task<Image> GetByIdAsync(int id);
    Task<IEnumerable<Image>> GetByFolderIdAsync(int folderId);
    Task AddAsync(Image image);
    // Other methods...
}
```

### 7. Domain Services

Domain services implement business logic that doesn't naturally belong to any single entity or value object. They coordinate multiple aggregates to perform complex business operations.

**Example Domain Service (Conceptual):**

```csharp
public class ImageTaggingService
{
    private readonly IImageRepository _imageRepository;
    private readonly ITagRepository _tagRepository;
    private readonly IImageTagRepository _imageTagRepository;
    
    public ImageTaggingService(
        IImageRepository imageRepository,
        ITagRepository tagRepository,
        IImageTagRepository imageTagRepository)
    {
        _imageRepository = imageRepository;
        _tagRepository = tagRepository;
        _imageTagRepository = imageTagRepository;
    }
    
    public async Task AddTagsToImageAsync(int imageId, IEnumerable<string> tagNames)
    {
        // Implementation that coordinates multiple aggregates
    }
}
```

### 8. Application Services (Use Cases)

Application services, known as use cases in the AVA AIGC Toolbox, implement application-specific business logic. They orchestrate the execution of domain logic but don't contain core business rules themselves.

**Example Use Case:**

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
        // 1. Validate input
        if (input.ImageId <= 0 || string.IsNullOrWhiteSpace(input.TagName))
            return false;
        
        // 2. Get existing image
        var image = await _imageRepository.GetByIdAsync(input.ImageId);
        if (image == null)
            return false;
        
        // 3. Get or create tag
        var tag = await _tagRepository.GetByNameAsync(input.TagName) ??
                  new Tag(input.TagName);
        
        if (tag.Id == 0)
            await _tagRepository.AddAsync(tag);
        
        // 4. Create image-tag relationship
        var imageTag = new ImageTag(input.ImageId, tag.Id);
        await _imageTagRepository.AddAsync(imageTag);
        
        return true;
    }
}
```

## DDD Implementation in AVA AIGC Toolbox

### 1. Project Structure

The project structure reflects DDD principles:

```
src/
├── Core/                # Domain layer
│   ├── Domain/          # Entities, value objects, domain services
│   │   ├── Entities/    # Core business entities
│   │   └── ValueObjects/ # Value objects
│   └── Application/     # Repository interfaces (ports)
│       └── Ports/       # Repository interfaces
├── Application/         # Application layer (use cases)
├── Infrastructure/      # Infrastructure layer (repository implementations)
└── Presentation/        # Presentation layer
```

### 2. Invariants

Invariants are enforced in entity constructors and methods:

```csharp
public class Image
{
    public Image(string filePath, string fileName, long fileSize, int width, int height)
    {
        if (string.IsNullOrWhiteSpace(filePath))
            throw new ArgumentException("File path cannot be empty");
        
        if (fileSize <= 0)
            throw new ArgumentException("File size must be greater than zero");
        
        if (width <= 0 || height <= 0)
            throw new ArgumentException("Dimensions must be positive");
        
        // Set properties
    }
}
```

### 3. Repository Pattern

Repository interfaces are defined in the Core layer and implemented in the Infrastructure layer:

```csharp
// Core layer - interface
export interface IImageRepository
{
    Task<Image> GetByIdAsync(int id);
    // Other methods
}

// Infrastructure layer - implementation
public class SQLiteImageRepository : IImageRepository
{
    public async Task<Image> GetByIdAsync(int id)
    {
        // Implementation using SQLite
    }
    // Other methods
}
```

### 4. Aggregate Design

Aggregates are designed to be small and focused, with clear boundaries:

- Each major domain concept is its own aggregate
- Relationships between aggregates are managed through identities
- Invariants are enforced within the aggregate

## Benefits of DDD in AVA AIGC Toolbox

1. **Better Alignment with Business Needs**: DDD ensures the software accurately models the domain
2. **Improved Communication**: Ubiquitous language reduces misunderstandings between team members
3. **Maintainability**: Clear boundaries and well-defined aggregates make the codebase easier to understand and modify
4. **Flexibility**: Decoupled layers allow for easier changes to implementation details
5. **Testability**: Domain logic can be tested in isolation
6. **Scalability**: Well-designed aggregates support scaling the system

## Challenges and Trade-offs

1. **Complexity**: DDD adds some overhead compared to simpler architectures
2. **Learning Curve**: Team members need to understand DDD concepts
3. **Performance Considerations**: Repository pattern and aggregate boundaries may introduce performance overhead
4. **Over-Engineering Risk**: It's possible to over-apply DDD concepts to simple problems

## Conclusion

Domain-Driven Design provides a solid foundation for the AVA AIGC Toolbox, ensuring the software accurately models the AI-generated image management domain. By applying DDD principles, we've created a maintainable, flexible, and testable codebase that aligns well with business needs.

As the project evolves, we'll continue to refine the domain model and apply DDD principles to new features and functionality.

---

*Last updated: January 2026*
