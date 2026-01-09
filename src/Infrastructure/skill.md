# Infrastructure Layer Skills

## Overview
This document defines the skills for working with the Infrastructure layer of the AVA AIGC Toolbox. The Infrastructure layer contains the concrete implementations of repository interfaces, database context, and other external dependencies.

## 1. Workflow-based Skills

### Repository Implementation Workflow
- **Type**: Workflow-based
- **Description**: Complete process for implementing repository interfaces
- **Steps**:
  1. Identify the repository interface to implement
  2. Create a new repository class in the appropriate directory
  3. Implement all interface methods
  4. Use SQLite-net for database operations
  5. Handle database connections and transactions
  6. Test the repository implementation
- **Implementation**: Follow the pattern in existing repositories (e.g., `SQLiteImageRepository.cs`)

### Database Migration Workflow
- **Type**: Workflow-based
- **Description**: Process for updating the database schema
- **Steps**:
  1. Update domain entities with new properties
  2. Modify the DatabaseContext to handle schema changes
  3. Implement migration logic if needed
  4. Test the migration process
  5. Update documentation
- **Implementation**: `src/Infrastructure/Data/DatabaseContext.cs`

## 2. Task-based Skills

### Infrastructure Operations
- **Type**: Task-based
- **Description**: Collection of operations for working with the Infrastructure layer
- **Operations**:
  - ImplementRepository: Create a concrete repository implementation
  - ConfigureDatabase: Set up database connections and context
  - WriteSQLQueries: Implement database queries using SQLite-net
  - HandleTransactions: Manage database transactions
  - TestRepository: Verify repository functionality
  - UpdateSchema: Modify database schema to match domain changes

### Infrastructure Components
- **Type**: Task-based
- **Description**: Key components of the Infrastructure layer
- **Components**:
  - Database Context: `src/Infrastructure/Data/DatabaseContext.cs`
  - Repositories: `src/Infrastructure/Repositories/`
  - Database Migrations: `src/Infrastructure/Data/` (future)

## 3. Reference/Guidelines

### Repository Implementation Guidelines
- **Type**: Reference
- **Description**: Standards for implementing repositories
- **Guidelines**:
  - Name repositories with database type prefix (e.g., `SQLiteImageRepository`)
  - Implement all methods from the corresponding interface
  - Use SQLite-net for database operations
  - Handle exceptions appropriately
  - Use parameterized queries to prevent SQL injection
  - Implement proper connection management
- **Example**: `src/Infrastructure/Repositories/SQLiteImageRepository.cs`

### Database Context Guidelines
- **Type**: Reference
- **Description**: Standards for database context implementation
- **Guidelines**:
  - Manage database connections
  - Handle schema creation and updates
  - Provide access to database connections for repositories
  - Implement proper disposal of resources
  - Use appropriate connection string handling
- **Example**: `src/Infrastructure/Data/DatabaseContext.cs`

### SQLite-net Usage Guidelines
- **Type**: Reference
- **Description**: Best practices for using SQLite-net
- **Guidelines**:
  - Use `SQLiteConnection` for database operations
  - Annotate entities with SQLite attributes
  - Use async methods where available
  - Handle database locks appropriately
  - Implement proper error handling

## 4. Capabilities-based Skills

### Data Access Layer
- **Type**: Capabilities-based
- **Description**: Complete data access functionality
- **Capabilities**:
  - SQLite database management
  - Repository pattern implementation
  - CRUD operations for all entities
  - Query building and execution
  - Transaction management
  - Connection pooling and management
- **Implementation**: `src/Infrastructure/Repositories/` directory

### Database Infrastructure
- **Type**: Capabilities-based
- **Description**: Database system infrastructure
- **Capabilities**:
  - Database creation and initialization
  - Schema management and migrations
  - Connection management
  - Backup and restore functionality
  - Performance optimization
- **Implementation**: `src/Infrastructure/Data/DatabaseContext.cs`

## How to Use These Skills

### For New Repository Implementation
1. Follow the **Repository Implementation Workflow**
2. Refer to **Repository Implementation Guidelines**
3. Use SQLite-net for database operations
4. Test thoroughly with various scenarios

### For Database Schema Changes
1. Update domain entities first
2. Follow the **Database Migration Workflow**
3. Update DatabaseContext if needed
4. Test the migration process

### For Troubleshooting
1. Check database connection string
2. Verify repository implementation matches interface
3. Test SQL queries directly if needed
4. Check for proper exception handling
5. Verify database file permissions

This skills document provides a framework for effectively working with the Infrastructure layer of the AVA AIGC Toolbox. Follow these guidelines to ensure reliable and maintainable data access implementation.