# Application Layer Skills

## 1. Core Responsibility
- Implements use cases that orchestrate business logic by coordinating between repositories and domain objects, acting as the application's main business logic layer.

## 2. Core Development Rules
1. **Naming Conventions**: 
   - Use case class name: `{Operation}{EntityName}UseCase` (e.g., `GetAllImagesUseCase`, `AddAlbumUseCase`)
   - File structure: Organize by domain in `UseCases/{Domain}/` folders (e.g., `UseCases/Images/`)
   - Base class: All use cases must inherit from `BaseUseCases<T>`
2. **Dependency Rules**: 
   - Only depend on Core layer repository interfaces
   - No direct infrastructure or presentation layer dependencies
   - Constructor injection for all dependencies
3. **Execution Method**: 
   - Implement `ExecuteAsync()` method with business logic
   - Method must be async (return Task<T>)
   - No public methods other than inherited `ExecuteAsync()`
4. **Dependency Injection**: 
   - Register all use cases as Transient in `App.axaml.cs`
   - Use `services.AddTransient<UseCaseType>()`
5. **Return Type**: 
   - Return Core layer domain objects only
   - No DTOs or infrastructure-specific types
   - For void operations, return Task<Unit> or similar

## 3. Common Patterns
### Use Case Base Pattern
```csharp
public class OperationEntityNameUseCase : BaseUseCases<ReturnType>
{
    private readonly IRepositoryInterface _repository;
    
    // Constructor injection of dependencies
    public OperationEntityNameUseCase(IRepositoryInterface repository)
    {
        _repository = repository;
    }
    
    // Core business logic implementation
    public override async Task<ReturnType> ExecuteAsync()
    {
        // Orchestrate business logic by coordinating repository calls
        var entities = await _repository.GetAllAsync();
        
        // Apply business rules and transformations
        var result = entities.Where(e => e.IsActive).ToList();
        
        return result;
    }
}
```

## 4. Capability List
- Use case pattern implementation for business operations
- Business rule enforcement and validation
- Coordination between multiple repositories
- Data transformation and orchestration
- Async business logic execution

## 5. Skill Loading Rules
- Load `Application/UseCases/` skills for use case management
- Load domain-specific skills from `UseCases/{Domain}/` folders (Albums, Folders, Images, Tags)