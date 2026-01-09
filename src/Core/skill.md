# Core Layer Skills

## 1. Core Responsibility
- Defines domain models, value objects, and repository interfaces forming the application's foundational business logic layer.

## 2. Core Development Rules
1. **Naming Conventions**: 
   - Entities: Singular PascalCase (e.g., `Image`)
   - Value Objects: Singular PascalCase (e.g., `TagCount`)
   - Repositories: `I` + EntityName + `Repository` (e.g., `IImageRepository`)
   - Methods: PascalCase verbs (e.g., `GetAllAsync`)
2. **Domain-Driven Design**: 
   - Entities: Objects with identity, implement business logic internally
   - Value Objects: Immutable data structures, define equality by value
   - Avoid anemic domain models (no empty entity classes)
3. **Repository Interfaces**: 
   - Define only necessary CRUD and domain-specific query methods
   - Return domain objects, never infrastructure-specific types
   - No direct database or external service dependencies
4. **Dependency Rules**: 
   - Core layer must not depend on any other layer
   - All dependencies must flow inward

## 3. Common Patterns
### Domain Entity Pattern
```csharp
public class EntityName
{
    public int Id { get; private set; } // Identity property
    public string PropertyName { get; private set; }
    
    // Private constructor for ORM, public factory method for creation
    private EntityName() {}
    
    public static EntityName Create(string propertyName)
    {
        // Validate inputs and enforce invariants
        if (string.IsNullOrWhiteSpace(propertyName))
            throw new ArgumentException("PropertyName cannot be empty");
        
        return new EntityName
        {
            PropertyName = propertyName
        };
    }
    
    // Business logic methods
    public void UpdateProperty(string newValue)
    {
        // Validate and update
        PropertyName = newValue;
    }
}
```

### Repository Interface Pattern
```csharp
public interface IEntityRepository
{
    Task<EntityName> GetByIdAsync(int id);
    Task<IEnumerable<EntityName>> GetAllAsync();
    Task AddAsync(EntityName entity);
    Task UpdateAsync(EntityName entity);
    Task DeleteAsync(int id);
    
    // Domain-specific query method
    Task<IEnumerable<EntityName>> GetByPropertyAsync(string propertyValue);
}
```

## 4. Capability List
- Domain modeling and entity definition
- Value object implementation with immutable design
- Business rule enforcement within domain objects
- Repository interface abstraction for data access
- Clear entity relationship management
- Domain-specific query definition

## 5. Skill Loading Rules
- Load `Core/Domain/` skills for domain modeling and value objects
- Load `Core/Application/Ports/` skills for repository interfaces