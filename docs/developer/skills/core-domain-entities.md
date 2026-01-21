# Domain Entities Skills

## Overview
This document defines the skills for working with Domain Entities in the AVA AIGC Toolbox. The Entities directory contains the core business objects that represent the main concepts of the application.

## 1. Workflow-based Skills

### Entity Development Workflow
- **Type**: Workflow-based
- **Description**: Complete process for developing domain entities
- **Steps**:
  1. Define the entity class with appropriate properties
  2. Implement constructors to enforce valid state
  3. Add business logic methods
  4. Include SQLite annotations for persistence
  5. Define relationships with other entities
  6. Validate the entity against business rules
- **Implementation**: Follow the pattern in existing entities (e.g., `Image.cs`)

### Entity Validation Workflow
- **Type**: Workflow-based
- **Description**: Process for validating domain entities
- **Steps**:
  1. Identify business rules for the entity
  2. Implement validation methods within the entity
  3. Call validation methods in constructors and setters
  4. Handle validation errors appropriately
  5. Test validation with various input scenarios
- **Implementation**: Use constructor validation as shown in `Image.cs`

## 2. Task-based Skills

### Entity Operations
- **Type**: Task-based
- **Description**: Collection of operations for working with domain entities
- **Operations**:
  - CreateEntityClass: Define a new entity class
  - AddProperties: Define properties with appropriate data types
  - ImplementConstructors: Create constructors to enforce valid state
  - AddBusinessLogic: Implement methods for domain-specific behavior
  - AddSQLiteAnnotations: Include attributes for database persistence
  - DefineRelationships: Establish connections with other entities
  - ImplementValidation: Add validation logic for business rules

### Available Entities
- **Type**: Task-based
- **Description**: List of existing domain entities
- **Entities**:
  - `Album`: Represents a collection of images
  - `Folder`: Represents a filesystem folder containing images
  - `Image`: Represents an AI-generated image
  - `ImageTag`: Represents the many-to-many relationship between images and tags
  - `ImageType`: Enum for image types
  - `Model`: Represents an AI model used for generation
  - `Tag`: Represents a tag for categorizing images

## 3. Reference/Guidelines

### Entity Design Standards
- **Type**: Reference
- **Description**: Standards for designing domain entities
- **Guidelines**:
  - Each entity must have an Id property as the primary key
  - Use appropriate data types for all properties
  - Implement constructors that enforce valid state
  - Add business logic methods to maintain invariants
  - Keep entities focused on a single responsibility
  - Use nullable reference types where appropriate
- **Example**: `Image.cs`

### SQLite Annotation Guidelines
- **Type**: Reference
- **Description**: Standards for SQLite annotations
- **Guidelines**:
  - Use `[Table("TableName")]` attribute to specify database table name
  - Use `[PrimaryKey, AutoIncrement]` for Id properties
  - Use `[Column("ColumnName")]` if column name differs from property name
  - Use `[Ignore]` for properties that shouldn't be persisted
  - Use appropriate SQLite data type attributes when needed
- **Example**: `Image.cs` (future annotations)

### Naming Conventions
- **Type**: Reference
- **Description**: Naming standards for domain entities
- **Guidelines**:
  - Entity classes: Singular PascalCase (e.g., `Image`, `Tag`)
  - Properties: PascalCase (e.g., `ImageId`, `CreatedDate`)
  - Primary key: `Id` (e.g., `ImageId` for foreign keys)
  - SQLite tables: Plural snake_case (e.g., `images`, `tags`)
  - Enums: PascalCase with singular name (e.g., `ImageType`)

## 4. Capabilities-based Skills

### Entity System
- **Type**: Capabilities-based
- **Description**: Complete entity functionality
- **Capabilities**:
  - Entity definition and management
  - Property validation
  - Business logic implementation
  - Relationship management
  - SQLite persistence support
  - Invariant maintenance
- **Implementation**: All entity classes in this directory

### Image Entity Capabilities
- **Type**: Capabilities-based
- **Description**: Specific capabilities of the Image entity
- **Capabilities**:
  - AI metadata storage (prompt, negative prompt, steps, etc.)
  - Image organization (folders, albums)
  - Tagging support
  - Rating and favoriting
  - File system integration
- **Implementation**: `Image.cs`

### Relationship Management
- **Type**: Capabilities-based
- **Description**: Management of entity relationships
- **Capabilities**:
  - One-to-many relationships (Folder → Image)
  - Many-to-many relationships (Image ↔ Tag via ImageTag)
  - Foreign key management
  - Navigation property support
- **Implementation**: Entity relationships defined in various entities

## How to Use These Skills

### For Creating New Entities
1. Follow the **Entity Development Workflow**
2. Apply **Entity Design Standards**
3. Add appropriate SQLite annotations
4. Implement business logic and validation
5. Define relationships with other entities
6. Test thoroughly

### For Working with Existing Entities
1. Understand the entity's properties and relationships
2. Use the entity's business logic methods
3. Respect the entity's invariants and validation rules
4. Follow the existing design patterns
5. Don't bypass entity validation

### For Extending Existing Entities
1. Add new properties with appropriate data types
2. Update constructors to handle new properties
3. Add validation for new properties
4. Implement any necessary business logic
5. Update SQLite annotations if needed
6. Test the changes thoroughly

This skills document provides a framework for effectively working with Domain Entities in the AVA AIGC Toolbox. Follow these guidelines to ensure consistent, maintainable, and business-aligned entity design.