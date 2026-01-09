# Repositories Skills

## 1. Core Responsibility
- Implements concrete repository classes that provide SQLite-based data access for all domain entities, following the repository interfaces defined in the Core layer.

## 2. Core Development Rules
1. **Naming Conventions**: 
   - Repository class name: `SQLite{EntityName}Repository` (e.g., `SQLiteImageRepository`, `SQLiteTagRepository`)
   - Method names: Match exactly the interface methods from Core layer
2. **Repository Implementation**: 
   - Implement all methods from the corresponding Core layer interface
   - All methods must be async (return Task<T> or Task)
   - Use parameterized queries to prevent SQL injection
   - Handle null returns appropriately with descriptive exceptions
3. **Database Usage**: 
   - Use `SQLiteConnection` obtained from `DatabaseContext`
   - Use `Table<T>()` for simple queries, `Query<T>()` for complex queries
   - Use `InsertAsync()`, `UpdateAsync()`, `DeleteAsync()` for CRUD operations
   - Proper connection disposal with `using` statements
4. **Dependency Injection**: 
   - Constructor injection of `DatabaseContext` only
   - No other dependencies allowed
   - Register all repositories as Transient in `App.axaml.cs`
5. **Error Handling**: 
   - Catch and wrap SQLite exceptions in domain-friendly exceptions
   - Provide clear error messages for debugging
   - Log exceptions appropriately

## 3. Common Patterns
### CRUD Repository Implementation Pattern
```csharp
public class SQLiteEntityNameRepository : IEntityRepository
{
    private readonly DatabaseContext _dbContext;
    
    public SQLiteEntityNameRepository(DatabaseContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task<EntityName> GetByIdAsync(int id)
    {
        using var connection = _dbContext.GetConnection();
        return await connection.Table<EntityName>().FirstOrDefaultAsync(e => e.Id == id);
    }
    
    public async Task<IEnumerable<EntityName>> GetAllAsync()
    {
        using var connection = _dbContext.GetConnection();
        return await connection.Table<EntityName>().ToListAsync();
    }
    
    public async Task AddAsync(EntityName entity)
    {
        using var connection = _dbContext.GetConnection();
        await connection.InsertAsync(entity);
    }
    
    public async Task UpdateAsync(EntityName entity)
    {
        using var connection = _dbContext.GetConnection();
        await connection.UpdateAsync(entity);
    }
    
    public async Task DeleteAsync(int id)
    {
        using var connection = _dbContext.GetConnection();
        await connection.DeleteAsync<EntityName>(id);
    }
    
    // Domain-specific query example
    public async Task<IEnumerable<EntityName>> GetByPropertyAsync(string propertyValue)
    {
        using var connection = _dbContext.GetConnection();
        return await connection.Table<EntityName>()
            .Where(e => e.PropertyName == propertyValue)
            .ToListAsync();
    }
}
```

## 4. Capability List
- SQLite-based implementation of all Core layer repository interfaces
- CRUD operations for all domain entities
- Complex query support using SQLite-net
- Transaction management for related operations
- Error handling and exception wrapping
- Connection pooling via DatabaseContext

## 5. Skill Loading Rules
- No subdirectories in Repositories, all skills loaded from this file