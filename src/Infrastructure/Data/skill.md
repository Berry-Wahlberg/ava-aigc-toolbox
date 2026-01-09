# Database Context Skills

## 1. Core Responsibility
- Manages database connections, schema creation, and transaction support for the application, providing a centralized interface for repository implementations to access the SQLite database.

## 2. Core Development Rules
1. **Naming Conventions**: 
   - Class name: `DatabaseContext.cs`
   - Database file: `aigenmanager.db`
   - Transaction methods: `BeginTransaction`, `CommitTransaction`, `RollbackTransaction`
2. **Database Configuration**: 
   - Location: `%APPDATA%/AIGenManager/aigenmanager.db` (Windows) or `~/.local/share/AIGenManager/aigenmanager.db` (macOS/Linux)
   - Connection string: Managed internally, no external configuration
3. **Implementation Standards**: 
   - Implement IDisposable for proper resource cleanup
   - Create tables automatically on first connection if missing
   - Use async methods for all database operations
   - Properly handle database locks and exceptions
4. **Connection Management**: 
   - Return fresh connections for each operation
   - Ensure connections are properly disposed
   - Use connection pooling where available
5. **Transaction Rules**: 
   - Support explicit transactions with proper commit/rollback
   - No nested transactions
   - Auto-rollback on exceptions

## 3. Common Patterns
### Database Context Implementation Pattern
```csharp
public class DatabaseContext : IDisposable
{
    private readonly string _databasePath;
    private SQLiteConnection _connection;
    
    public DatabaseContext()
    {
        // Determine database path based on platform
        _databasePath = GetDatabasePath();
        InitializeDatabase();
    }
    
    public SQLiteConnection GetConnection()
    {
        return new SQLiteConnection(_databasePath);
    }
    
    private void InitializeDatabase()
    {
        using var connection = GetConnection();
        
        // Create tables for all entities
        connection.CreateTable<Entity1>();
        connection.CreateTable<Entity2>();
        // Add more entities as needed
    }
    
    public void Dispose()
    {
        _connection?.Dispose();
    }
    
    private string GetDatabasePath()
    {
        // Platform-specific database path logic
        // ...
    }
}
```

## 4. Capability List
- Database creation and initialization
- Connection management and pooling
- Automatic table creation from entities
- Transaction support (begin, commit, rollback)
- Error handling and exception management
- SQLite data type mapping

## 5. Skill Loading Rules
- No subdirectories in Data, all skills loaded from this file