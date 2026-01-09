# Repository Ports Skills

## Overview
This document defines the skills for working with the Repository Ports in the AVA AIGC Toolbox. The Ports directory contains the repository interfaces that define the data access contracts for the application.

## 1. Workflow-based Skills

### Repository Interface Development Workflow
- **Type**: Workflow-based
- **Description**: Complete process for developing repository interfaces
- **Steps**:
  1. Identify the entity for which to create a repository
  2. Define the interface with appropriate methods
  3. Include basic CRUD operations
  4. Add domain-specific query methods
  5. Implement the interface in the Infrastructure layer
  6. Test the implementation
- **Implementation**: Follow the pattern in existing interfaces (e.g., `IImageRepository.cs`)

### Interface Evolution Workflow
- **Type**: Workflow-based
- **Description**: Process for updating existing repository interfaces
- **Steps**:
  1. Identify the need for a new method
  2. Add the method to the existing interface
  3. Update all implementations of the interface
  4. Update any use cases that depend on the interface
  5. Test the changes thoroughly
- **Implementation**: Use semantic versioning principles for interface changes

## 2. Task-based Skills

### Repository Interface Operations
- **Type**: Task-based
- **Description**: Collection of operations for working with repository interfaces
- **Operations**:
  - CreateInterface: Define a new repository interface
  - AddCRUDMethods: Include basic CRUD operations
  - AddQueryMethods: Add domain-specific query methods
  - UpdateInterface: Modify an existing interface
  - ImplementInterface: Create a concrete implementation in Infrastructure
  - TestInterface: Verify interface functionality

### Available Repository Interfaces
- **Type**: Task-based
- **Description**: List of existing repository interfaces
- **Interfaces**:
  - `IAlbumRepository`: For album data access
  - `IFolderRepository`: For folder data access
  - `IImageRepository`: For image data access
  - `IImageTagRepository`: For image-tag relationship data access
  - `ITagRepository`: For tag data access

## 3. Reference/Guidelines

### Repository Interface Design Guidelines
- **Type**: Reference
- **Description**: Standards for designing repository interfaces
- **Guidelines**:
  - Name interfaces with `I` prefix followed by entity name and "Repository"
  - Use async methods for all data access operations
  - Return domain objects, not DTOs
  - Use appropriate return types (single entity, IEnumerable<T>, etc.)
  - Include basic CRUD operations: GetByIdAsync, GetAllAsync, AddAsync, UpdateAsync, DeleteAsync
  - Add domain-specific query methods as needed
  - Keep interfaces focused and cohesive
- **Example**: `IImageRepository.cs`

### Naming Conventions
- **Type**: Reference
- **Description**: Naming standards for repository interfaces
- **Guidelines**:
  - Interface name: `I{EntityName}Repository.cs`
  - Method names: PascalCase with clear action verbs
  - Async suffix: All methods should end with "Async"
  - Example: `GetAllImagesAsync`, `AddAlbumAsync`

### Method Signature Guidelines
- **Type**: Reference
- **Description**: Standards for method signatures
- **Guidelines**:
  - Use appropriate parameters for filtering
  - Return Task<T> for async operations
  - Use nullable reference types where appropriate
  - Include meaningful parameter names
- **Example**: `Task<IEnumerable<Image>> GetImagesByFolderIdAsync(int folderId);`

## 4. Capabilities-based Skills

### Repository Abstraction Layer
- **Type**: Capabilities-based
- **Description**: Complete repository abstraction functionality
- **Capabilities**:
  - Data access abstraction
  - Interface-based design
  - Domain-specific query methods
  - Async data access support
  - Dependency inversion implementation
- **Implementation**: All repository interfaces in this directory

### Domain Data Access Contract
- **Type**: Capabilities-based
- **Description**: Contract definition for data access
- **Capabilities**:
  - Entity-specific CRUD operations
  - Relationship management
  - Query filtering and sorting
  - Transaction support
  - Bulk operation support (future)
- **Implementation**: Combined repository interfaces

## How to Use These Skills

### For Creating New Repository Interfaces
1. Follow the **Repository Interface Development Workflow**
2. Refer to **Repository Interface Design Guidelines**
3. Include basic CRUD operations
4. Add domain-specific query methods
5. Ensure all methods are async

### For Working with Existing Interfaces
1. Identify the appropriate interface for your needs
2. Use the methods defined in the interface
3. Pass the interface to use cases via constructor injection
4. Do not modify interfaces without following the **Interface Evolution Workflow**

### For Implementing Interfaces
1. Create a concrete class in `src/Infrastructure/Repositories/`
2. Implement all methods from the interface
3. Use SQLite-net for database operations
4. Follow the implementation pattern in existing repositories

This skills document provides a framework for effectively working with the Repository Ports in the AVA AIGC Toolbox. Follow these guidelines to ensure consistent and maintainable data access contracts.