# Domain Layer Skills

## Overview
This document defines the skills for working with the Domain layer in the AVA AIGC Toolbox. The Domain layer contains the core business logic, entities, and value objects that form the foundation of the application.

## 1. Workflow-based Skills

### Domain Modeling Workflow
- **Type**: Workflow-based
- **Description**: Complete process for developing domain models
- **Steps**:
  1. Identify domain concepts from business requirements
  2. Determine if a concept is an entity or value object
  3. Define properties and relationships
  4. Implement business logic within the domain objects
  5. Validate the model against business rules
  6. Update repository interfaces if needed
- **Implementation**: Follow the pattern in existing domain models (e.g., `Image.cs`)

### Entity Relationship Design Workflow
- **Type**: Workflow-based
- **Description**: Process for designing relationships between domain entities
- **Steps**:
  1. Identify the entities involved
  2. Determine the relationship type (one-to-one, one-to-many, many-to-many)
  3. Define foreign keys or join entities as needed
  4. Implement navigation properties if appropriate
  5. Ensure relationships follow business rules
- **Implementation**: See `ImageTag.cs` for many-to-many relationship example

## 2. Task-based Skills

### Domain Component Operations
- **Type**: Task-based
- **Description**: Collection of operations for working with domain components
- **Operations**:
  - CreateEntity: Define a new domain entity class
  - CreateValueObject: Define a new value object class
  - AddProperties: Define properties with appropriate access modifiers
  - ImplementBusinessLogic: Add methods for domain-specific behavior
  - DefineRelationships: Establish connections between entities
  - ValidateModel: Ensure the model follows business rules

### Domain Components
- **Type**: Task-based
- **Description**: Key components of the Domain layer
- **Components**:
  - Entities: `src/Core/Domain/Entities/`
  - Value Objects: `src/Core/Domain/ValueObjects/`

## 3. Reference/Guidelines

### Domain-Driven Design Principles
- **Type**: Reference
- **Description**: Core principles for effective domain modeling
- **Guidelines**:
  - **Entities**: Objects with identity that change over time
  - **Value Objects**: Immutable objects defined by their properties
  - **Aggregates**: Clusters of entities and value objects treated as a single unit
  - **Domain Events**: Represent significant changes in the domain
  - **Repositories**: Abstractions for data access
  - **Services**: Operations that don't naturally belong to a single entity

### Entity Design Guidelines
- **Type**: Reference
- **Description**: Standards for designing domain entities
- **Guidelines**:
  - Include an identifier property (usually Id)
  - Use appropriate data types for properties
  - Implement constructors to enforce valid state
  - Add business logic methods to maintain invariants
  - Use navigation properties sparingly
  - Follow the law of Demeter
- **Example**: `src/Core/Domain/Entities/Image.cs`

### Value Object Design Guidelines
- **Type**: Reference
- **Description**: Standards for designing value objects
- **Guidelines**:
  - Make them immutable
  - Override Equals and GetHashCode
  - Implement value-based equality
  - Use them for concepts without identity
  - Prefer value objects over primitive types for domain concepts
- **Example**: `src/Core/Domain/ValueObjects/TagCount.cs`

### Naming Conventions
- **Type**: Reference
- **Description**: Naming standards for domain components
- **Guidelines**:
  - Entities: Singular PascalCase (e.g., `Image`, `Tag`)
  - Value Objects: Singular PascalCase (e.g., `TagCount`)
  - Properties: PascalCase (e.g., `ImageId`, `CreatedDate`)
  - Methods: PascalCase with clear action verbs (e.g., `AddTag`, `UpdateMetadata`)

## 4. Capabilities-based Skills

### Domain Model System
- **Type**: Capabilities-based
- **Description**: Complete domain modeling functionality
- **Capabilities**:
  - Entity definition and management
  - Value object implementation
  - Relationship management
  - Business rule enforcement
  - Domain invariant preservation
  - Aggregate design and management
- **Implementation**: `src/Core/Domain/` directory structure

### Business Logic Layer
- **Type**: Capabilities-based
- **Description**: Core business logic functionality
- **Capabilities**:
  - Business rule validation
  - Domain-specific calculations
  - State transitions
  - Event generation
  - Invariant maintenance
- **Implementation**: Business logic methods within domain entities

## How to Use These Skills

### For Domain Model Development
1. Follow the **Domain Modeling Workflow**
2. Apply **Domain-Driven Design Principles**
3. Use the appropriate component type (entity vs value object)
4. Implement business logic within the domain objects
5. Validate the model against business requirements

### For Working with Existing Domain Models
1. Understand the entity relationships
2. Respect the existing design patterns
3. Follow the established naming conventions
4. Don't break existing business logic
5. Use domain objects as they were intended

### For Extending the Domain Model
1. Identify the new domain concept
2. Determine if it's an entity or value object
3. Define its properties and relationships
4. Implement necessary business logic
5. Update repository interfaces if needed
6. Test the new domain component thoroughly

This skills document provides a framework for effectively working with the Domain layer in the AVA AIGC Toolbox. Follow these guidelines to ensure a robust and maintainable domain model that accurately represents the business domain.