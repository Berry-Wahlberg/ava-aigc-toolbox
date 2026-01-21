# Use Cases Skills

## 1. Core Responsibility
- Organizes use cases by domain (Albums, Folders, Images, Tags) and provides the base use case framework for consistent implementation of business operations.

## 2. Core Development Rules
1. **Domain Organization**: 
   - All use cases must be placed in their respective domain subdirectory
   - Subdirectories: `Albums/`, `Folders/`, `Images/`, `Tags/`
   - Create new domain subdirectory only for distinct business domains
2. **Naming Conventions**: 
   - Use case class: `{Operation}{EntityName}UseCase.cs` (e.g., `GetAllImagesUseCase.cs`)
   - Start with operation verb (Get, Add, Update, Delete, etc.)
   - PascalCase with "UseCase" suffix
3. **Base Class Requirements**: 
   - All use cases must inherit from `BaseUseCases<T>`
   - Base class provides common functionality and consistent execution pattern
4. **Implementation Standards**: 
   - Single business operation per use case
   - Small, focused classes (under 100 lines)
   - Constructor injection for all dependencies
   - Return only domain objects
   - Proper error handling with descriptive exceptions
5. **Dependency Rules**: 
   - Only depend on Core layer repository interfaces
   - No infrastructure or presentation layer dependencies

## 3. Common Patterns
### Base Use Case Class Pattern
```csharp
public abstract class BaseUseCases<T>
{
    // Common properties and methods for all use cases
    protected readonly ILogger _logger;
    
    protected BaseUseCases()
    {
        // Default constructor for cases without dependencies
    }
    
    // Core execution method that all use cases must implement
    public abstract Task<T> ExecuteAsync();
}
```

## 4. Capability List
- Domain-based use case organization
- Consistent use case implementation framework
- Base class for common use case functionality
- Support for various business operations across domains

## 5. Skill Loading Rules
- Load `UseCases/Albums/` skills for album-related business operations
- Load `UseCases/Folders/` skills for folder-related business operations
- Load `UseCases/Images/` skills for image-related business operations
- Load `UseCases/Tags/` skills for tag-related business operations