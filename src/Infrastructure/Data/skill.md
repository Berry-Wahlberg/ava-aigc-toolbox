# Database Context Skills

## Overview
This document defines the skills for working with the Database Context in the AVA AIGC Toolbox. The Data directory contains the database context that manages connections and schema for the SQLite database.

## 1. Workflow-based Skills

### Database Setup Workflow
- **Type**: Workflow-based
- **Description**: Complete process for setting up and initializing the database
- **Steps**:
  1. Create or locate the database file
  2. Initialize the database context
  3. Create database tables if they don't exist
  4. Set up indexes and constraints
  5. Verify database connectivity
- **Implementation**: Follow the pattern in `DatabaseContext.cs`

### Database Migration Workflow
- **Type**: Workflow-based
- **Description**: Process for updating the database schema
- **Steps**:
  1. Update domain entities with new properties
  2. Modify the DatabaseContext to handle schema changes
  3. Implement migration logic if needed
  4. Test the migration process
  5. Update documentation
- **Implementation**: `DatabaseContext.cs` (future migration support)

## 2. Task-based Skills

### Database Context Operations
- **Type**: Task-based
- **Description**: Collection of operations for working with the database context
- **Operations**:
  - CreateDatabaseContext: Initialize a new database context
  - GetConnection: Obtain a SQLite connection
  - CreateTables: Generate database tables from entities
  - InitializeSchema: Set up indexes and constraints
  - ManageTransactions: Handle database transactions
  - CleanupResources: Properly dispose of database resources

### Database Configuration
- **Type**: Task-based
- **Description**: Database configuration options
- **Configuration**:
  - Database Location: `%APPDATA%/AIGenManager/aigenmanager.db` (Windows) or `~/.local/share/AIGenManager/aigenmanager.db` (macOS/Linux)
  - Connection String: Managed by DatabaseContext
  - SQLite Version: SQLite-net compatibility

## 3. Reference/Guidelines

### Database Context Implementation Guidelines
- **Type**: Reference
- **Description**: Standards for implementing database context
- **Guidelines**:
  - Implement IDisposable for proper resource cleanup
  - Manage database connections efficiently
  - Create tables automatically if they don't exist
  - Handle database errors appropriately
  - Use appropriate connection string handling
  - Implement proper transaction management
- **Example**: `DatabaseContext.cs`

### SQLite Usage Guidelines
- **Type**: Reference
- **Description**: Best practices for using SQLite in the context
- **Guidelines**:
  - Use parameterized queries to prevent SQL injection
  - Use async methods where available
  - Implement connection pooling if needed
  - Handle database locks appropriately
  - Use transactions for multiple related operations

### Naming Conventions
- **Type**: Reference
- **Description**: Naming standards for database components
- **Guidelines**:
  - Database context: `DatabaseContext.cs`
  - Database file: `aigenmanager.db`
  - Connection methods: PascalCase with clear action verbs
  - Transaction methods: `BeginTransaction`, `CommitTransaction`, `RollbackTransaction`

## 4. Capabilities-based Skills

### Database Management System
- **Type**: Capabilities-based
- **Description**: Complete database management functionality
- **Capabilities**:
  - Database creation and initialization
  - Connection management
  - Schema management
  - Transaction support
  - Error handling
  - Resource management
- **Implementation**: `DatabaseContext.cs`

### SQLite Integration
- **Type**: Capabilities-based
- **Description**: SQLite-specific functionality
- **Capabilities**:
  - SQLite connection handling
  - Table creation from entities
  - SQLite data types mapping
  - SQLite-specific query optimization
  - SQLite transaction support
- **Implementation**: `DatabaseContext.cs` using SQLite-net

## How to Use These Skills

### For Database Setup
1. Follow the **Database Setup Workflow**
2. Use the `DatabaseContext` class to manage connections
3. Verify database initialization
4. Test basic database operations

### For Database Schema Changes
1. Update domain entities first
2. Follow the **Database Migration Workflow**
3. Update the DatabaseContext if needed
4. Test the migration process

### For Working with Database Connections
1. Obtain a connection via `DatabaseContext.GetConnection()`
2. Use the connection for database operations
3. Ensure the connection is properly disposed
4. Use transactions for multiple related operations

This skills document provides a framework for effectively working with the Database Context in the AVA AIGC Toolbox. Follow these guidelines to ensure reliable and efficient database management.