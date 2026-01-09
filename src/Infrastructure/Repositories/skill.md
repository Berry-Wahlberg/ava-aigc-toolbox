# Repositories Skills

## Overview
This document defines the skills for working with Repositories in the AVA AIGC Toolbox. The Repositories directory contains the concrete implementations of the repository interfaces defined in the Core layer.

## 1. Workflow-based Skills

### Repository Implementation Workflow
- **Type**: Workflow-based
- **Description**: Complete process for implementing repository interfaces
- **Steps**:
  1. Identify the repository interface to implement
  2. Create a concrete class with SQLite prefix
  3. Implement all interface methods
  4. Use SQLite-net for database operations
  5. Handle exceptions appropriately
  6. Test the implementation thoroughly
- **Implementation**: Follow the pattern in existing repositories (e.g., `SQLiteImageRepository.cs`)

### CRUD Implementation Workflow
- **Type**: Workflow-based
- **Description**: Process for implementing CRUD operations in repositories
- **Steps**:
  1. Implement GetAllAsync to retrieve all entities
  2. Implement GetByIdAsync to retrieve a single entity
  3. Implement AddAsync to create new entities
  4. Implement UpdateAsync to modify existing entities
  5. Implement DeleteAsync to remove entities
  6. Add domain-specific query methods
- **Implementation**: See `SQLiteTagRepository.cs` for CRUD example

## 2. Task-based Skills

### Repository Operations
- **Type**: Task-based
- **Description**: Collection of operations for working with repositories
- **Operations**:
  - ImplementRepositoryInterface: Create a concrete repository class
  - WriteSQLQueries: Implement database queries using SQLite-net
  - HandleDatabaseExceptions: Implement error handling
  - TestRepositoryMethods: Verify repository functionality
  - OptimizeQueries: Improve query performance

### Available Repositories
- **Type**: Task-based
- **Description**: List of existing repository implementations
- **Repositories**:
  - `SQLiteAlbumRepository`: Implementation of `IAlbumRepository`
  - `SQLiteFolderRepository`: Implementation of `IFolderRepository`
  - `SQLiteImageRepository`: Implementation of `IImageRepository`
  - `SQLiteImageTagRepository`: Implementation of `IImageTagRepository`
  - `SQLiteTagRepository`: Implementation of `ITagRepository`

## 3. Reference/Guidelines

### Repository Implementation Guidelines
- **Type**: Reference
- **Description**: Standards for implementing repositories
- **Guidelines**:
  - Name repositories with database type prefix (e.g., `SQLiteImageRepository`)
  - Use constructor injection for database context
  - Implement all methods from the corresponding interface
  - Use parameterized queries to prevent SQL injection
  - Handle null returns appropriately
  - Implement proper error handling
  - Use async methods for all database operations
- **Example**: `SQLiteImageRepository.cs`

### SQLite-net Usage Guidelines
- **Type**: Reference
- **Description**: Best practices for using SQLite-net in repositories
- **Guidelines**:
  - Use `SQLiteConnection` for database operations
  - Use `Table<T>()` for basic queries
  - Use `Query<T>()` for complex queries
  - Use `InsertAsync()` for adding entities
  - Use `UpdateAsync()` for modifying entities
  - Use `DeleteAsync()` for removing entities
- **Example**: Repository methods in various repository classes

## 4. Capabilities-based Skills

### Data Access Layer
- **Type**: Capabilities-based
- **Description**: Complete data access functionality
- **Capabilities**:
  - CRUD operations for all entities
  - Complex query support
  - Transaction management
  - Connection pooling (via DatabaseContext)
  - Error handling and recovery
- **Implementation**: All repository classes in this directory

### SQLite Repository System
- **Type**: Capabilities-based
- **Description**: SQLite-specific repository functionality
- **Capabilities**:
  - SQLite database interaction
  - Table creation and management
  - Index optimization
  - Query building and execution
  - Entity mapping
- **Implementation**: Repository classes using SQLite-net

## How to Use These Skills

### For Implementing New Repositories
1. Follow the **Repository Implementation Workflow**
2. Apply **Repository Implementation Guidelines**
3. Use SQLite-net for database operations
4. Test all CRUD operations
5. Add domain-specific query methods as needed

### For Modifying Existing Repositories
1. Identify the repository to modify
2. Follow existing implementation patterns
3. Add or update methods as required
4. Test thoroughly with various scenarios
5. Ensure backward compatibility

### For Troubleshooting Repository Issues
1. Check database connection string
2. Verify query syntax
3. Test with sample data
4. Check for proper exception handling
5. Optimize queries if needed

This skills document provides a framework for effectively working with repositories in the AVA AIGC Toolbox. Follow these guidelines to ensure consistent, maintainable, and efficient data access implementation.