# Infrastructure Layer Skills

## 1. Core Responsibility
- Provides concrete implementations of repository interfaces, database context, and other external dependencies, acting as the application's bridge to external systems.

## 2. Core Development Rules
1. **Naming Conventions**: 
   - Repository class name: `{DatabaseType}{EntityName}Repository` (e.g., `SQLiteImageRepository`, `SQLiteTagRepository`)
   - Database context: `DatabaseContext.cs`
   - File structure: Organize in `Data/` and `Repositories/` subdirectories
2. **Repository Implementation**: 
   - Implement all methods from the corresponding Core layer interface
   - Use SQLite-net for all database operations
   - All methods must be async (return Task<T> or Task)
   - Use parameterized queries to prevent SQL injection
3. **Database Usage**: 
   - Use `SQLiteConnection` for database operations
   - Annotate entities with SQLite attributes (e.g., `[PrimaryKey]`, `[AutoIncrement]`)
   - Proper connection management and disposal
   - Handle database locks and exceptions appropriately
4. **Dependency Rules**: 
   - Depend only on Core layer interfaces and SQLite-net
   - No presentation layer dependencies
   - Constructor injection for all dependencies
5. **Transaction Management**: 
   - Use explicit transactions for multiple related operations
   - Ensure proper transaction commit/rollback

## 3. Common Patterns
### Repository Implementation Pattern
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
    
    // Implement other interface methods...
}
```

## 4. Capability List
- SQLite database management and connection handling
- Concrete repository implementations for all Core layer interfaces
- Database schema creation and management
- CRUD operations for all domain entities
- Complex query implementation
- Transaction management
- Database migration support

## 5. Skill Loading Rules
- Load `Infrastructure/Data/` skills for database context and schema management
- Load `Infrastructure/Repositories/` skills for repository implementations