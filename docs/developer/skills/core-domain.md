# Domain Layer Skills

## 1. Core Responsibility
- Defines domain entities, value objects, and their relationships, encapsulating the application's core business logic and invariants.

## 2. Core Development Rules
1. **Naming Conventions**: 
   - Entities: Singular PascalCase (e.g., `Image`, `Tag`)
   - Value Objects: Singular PascalCase (e.g., `TagCount`)
   - Properties: PascalCase with descriptive names (e.g., `CreatedDate`, `Name`)
   - Methods: PascalCase verbs with clear intent (e.g., `AddTag`, `UpdateName`)
2. **Entity Design**: 
   - Must have an Id property as primary identifier
   - Enforce valid state via constructors and factory methods
   - Implement business logic within the entity
   - Use private setters for most properties to control state changes
   - Navigation properties are optional, use sparingly
3. **Value Object Design**: 
   - Must be immutable (readonly properties, no public setters)
   - Override Equals() and GetHashCode() for value-based equality
   - Implement explicit conversion operators if needed
   - No identity property (Id)
4. **Relationship Rules**: 
   - One-to-One: Use foreign key in dependent entity
   - One-to-Many: Navigation property in principal entity, foreign key in dependent
   - Many-to-Many: Use join entity with foreign keys to both entities
   - Avoid circular references
5. **Aggregate Design**: 
   - Group related entities and value objects into aggregates
   - Identify a single aggregate root
   - All operations on aggregate members must go through the root

## 3. Common Patterns
### Value Object Pattern
```csharp
public class ValueObjectName : IEquatable<ValueObjectName>
{
    public string Property1 { get; } // Readonly property
    public int Property2 { get; }     // Readonly property
    
    // Public constructor with validation
    public ValueObjectName(string property1, int property2)
    {
        if (string.IsNullOrWhiteSpace(property1))
            throw new ArgumentException("Property1 cannot be empty");
        
        Property1 = property1;
        Property2 = property2;
    }
    
    // Value-based equality implementation
    public bool Equals(ValueObjectName other)
    {
        if (other is null) return false;
        return Property1 == other.Property1 && Property2 == other.Property2;
    }
    
    public override bool Equals(object obj) => Equals(obj as ValueObjectName);
    public override int GetHashCode() => HashCode.Combine(Property1, Property2);
}
```

### Entity Relationship Pattern (One-to-Many)
```csharp
// Principal entity
public class Album
{
    public int Id { get; private set; }
    public string Name { get; private set; }
    
    // Navigation property to dependent entities
    public List<Image> Images { get; private set; } = new();
    
    // Business logic to maintain relationship invariant
    public void AddImage(Image image)
    {
        if (image == null) throw new ArgumentNullException(nameof(image));
        if (!Images.Contains(image))
        {
            Images.Add(image);
            // Additional business logic if needed
        }
    }
}

// Dependent entity
public class Image
{
    public int Id { get; private set; }
    public string FilePath { get; private set; }
    
    // Foreign key to principal entity
    public int AlbumId { get; private set; }
    
    // Navigation property back to principal (optional)
    public Album Album { get; private set; }
}
```

## 4. Capability List
- Domain modeling and entity definition
- Value object implementation with immutable design
- Entity relationship design and management
- Business rule enforcement within domain objects
- Invariant preservation
- Aggregate root design and management
- Business logic encapsulation

## 5. Skill Loading Rules
- Load `Domain/Entities/` skills for entity-specific implementation details
- Load `Domain/ValueObjects/` skills for value object-specific patterns