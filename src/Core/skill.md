# Core Layer Skills

## Overview
This document defines the skills for working with the Core layer of the AVA AIGC Toolbox. The Core layer contains the domain models, value objects, and repository interfaces that form the foundation of the application.

## 1. Workflow-based Skills

### Domain Model Development Workflow
- **Type**: Workflow-based
- **Description**: Complete process for developing new domain models
- **Steps**:
  1. Identify the domain entity or value object to create
  2. Define the properties and relationships
  3. Implement constructor and business logic
  4. Create repository interface if needed
  5. Update infrastructure layer with implementation
  6. Test the domain model
- **Implementation**: Follow the pattern in existing entities (e.g., `Image.cs`)

## 2. Task-based Skills

### Domain Model Operations
- **Type**: Task-based
- **Description**: Collection of operations for working with domain models
- **Operations**:
  - CreateEntity: Create a new domain entity class
  - CreateValueObject: Create a new value object class
  - DefineProperties: Add properties with appropriate access modifiers
  - ImplementBusinessLogic: Add methods for domain-specific behavior
  - CreateRepositoryInterface: Define repository interface for data access
  - UpdateRelationships: Manage relationships between entities

### Core Components
- **Type**: Task-based
- **Description**: Key components of the Core layer
- **Components**:
  - Domain Entities: `src/Core/Domain/Entities/`
  - Value Objects: `src/Core/Domain/ValueObjects/`
  - Repository Interfaces: `src/Core/Application/Ports/`

## 3. Reference/Guidelines

### Domain-Driven Design Guidelines
- **Type**: Reference
- **Description**: Principles for effective domain modeling
- **Guidelines**:
  - Use entities for objects with identity
  - Use value objects for immutable data structures
  - Implement business logic within domain objects
  - Avoid anemic domain models
  - Define clear relationships between entities
- **Example**: `src/Core/Domain/Entities/Image.cs`

### Repository Interface Guidelines
- **Type**: Reference
- **Description**: Standards for defining repository interfaces
- **Guidelines**:
  - Name interfaces with `I` prefix followed by entity name and "Repository"
  - Include basic CRUD operations
  - Use domain objects as parameters and return types
  - Define methods for common queries
  - Keep interfaces focused and cohesive
- **Example**: `src/Core/Application/Ports/IImageRepository.cs`

### Naming Conventions
- **Type**: Reference
- **Description**: Naming standards for Core layer components
- **Guidelines**:
  - Entities: Singular PascalCase (e.g., `Image`, `Tag`)
  - Value Objects: Singular PascalCase (e.g., `TagCount`)
  - Repositories: `I` + EntityName + `Repository` (e.g., `IImageRepository`)
  - Methods: PascalCase with clear action verbs (e.g., `GetAllAsync`, `AddAsync`)

## 4. Capabilities-based Skills

### Domain Model Layer
- **Type**: Capabilities-based
- **Description**: Complete domain modeling functionality
- **Capabilities**:
  - Entity definition and management
  - Value object implementation
  - Business rule enforcement
  - Relationship management
  - Domain event handling
- **Implementation**: `src/Core/Domain/` directory structure

### Repository Interface Layer
- **Type**: Capabilities-based
- **Description**: Abstraction layer for data access
- **Capabilities**:
  - Data access abstraction
  - Query definition
  - Transaction management
  - Repository pattern implementation
- **Implementation**: `src/Core/Application/Ports/` directory

## How to Use These Skills

### For New Domain Model Development
1. Follow the **Domain Model Development Workflow**
2. Refer to **Domain-Driven Design Guidelines**
3. Create appropriate repository interfaces if needed
4. Update infrastructure layer with concrete implementations

### For Modifying Existing Models
1. Identify the domain model to modify
2. Ensure changes maintain business integrity
3. Update related repository interfaces if needed
4. Update infrastructure implementations
5. Test thoroughly

### For Extending Functionality
1. Define new repository methods in existing interfaces
2. Implement the methods in the infrastructure layer
3. Create use cases to expose the new functionality
4. Update the dependency injection configuration

This skills document provides a framework for effectively working with the Core layer of the AVA AIGC Toolbox. Follow these guidelines to ensure a robust and maintainable domain model.