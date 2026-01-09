# Use Cases Skills

## Overview
This document defines the skills for working with the Use Cases directory of the AVA AIGC Toolbox. The Use Cases directory contains the application logic organized by domain, implementing the use case pattern for each business operation.

## 1. Workflow-based Skills

### Use Case Organization Workflow
- **Type**: Workflow-based
- **Description**: Process for organizing use cases by domain
- **Steps**:
  1. Identify the domain for the use case (Albums, Folders, Images, Tags)
  2. Create or use the existing domain subdirectory
  3. Implement the use case class inheriting from `BaseUseCases<T>`
  4. Add necessary repository dependencies
  5. Implement the business logic in `ExecuteAsync` method
  6. Register the use case in DI container
  7. Test the use case
- **Implementation**: Follow the pattern in existing domain directories

### Use Case Testing Workflow
- **Type**: Workflow-based
- **Description**: Process for testing use cases
- **Steps**:
  1. Create a test class for the use case
  2. Mock the required repository dependencies
  3. Set up test data
  4. Execute the use case
  5. Verify the results
  6. Test edge cases
- **Implementation**: Use xUnit or NUnit for testing

## 2. Task-based Skills

### Use Case Domain Operations
- **Type**: Task-based
- **Description**: Operations for working with use case domains
- **Operations**:
  - CreateDomainDirectory: Create a new domain subdirectory for use cases
  - AddUseCaseToDomain: Add a new use case to an existing domain
  - OrganizeUseCases: Restructure use cases by domain
  - UpdateDomainUseCases: Modify multiple use cases in a domain

### Use Case Categories
- **Type**: Task-based
- **Description**: Organization of use cases by business domain
- **Categories**:
  - Albums: Use cases for album management
  - Folders: Use cases for folder navigation and management
  - Images: Use cases for image retrieval and management
  - Tags: Use cases for tag creation and management

### Base Use Case Operations
- **Type**: Task-based
- **Description**: Operations for working with the BaseUseCases class
- **Operations**:
  - InheritFromBaseUseCase: Create a use case inheriting from `BaseUseCases<T>`
  - ImplementExecuteMethod: Add business logic to the `ExecuteAsync` method
  - UseGenericReturnType: Define the generic return type for the use case
  - HandleExceptions: Implement exception handling in use cases

## 3. Reference/Guidelines

### Use Case Naming Conventions
- **Type**: Reference
- **Description**: Standards for naming use cases
- **Guidelines**:
  - Use PascalCase with "UseCase" suffix
  - Start with the operation verb (Get, Add, Update, Delete)
  - Include the entity name if applicable
  - Example: `GetAllImagesUseCase.cs`, `AddTagToImageUseCase.cs`

### Use Case Implementation Guidelines
- **Type**: Reference
- **Description**: Best practices for implementing use cases
- **Guidelines**:
  - Each use case should represent a single business operation
  - Use cases should be small and focused
  - Use constructor injection for dependencies
  - Only inject the repositories needed for the operation
  - Return domain objects, not DTOs
  - Implement proper error handling
- **Example**: `src/Application/UseCases/Images/GetAllImagesUseCase.cs`

### BaseUseCases Usage Guidelines
- **Type**: Reference
- **Description**: Standards for using the BaseUseCases class
- **Guidelines**:
  - All use cases must inherit from `BaseUseCases<T>`
  - Use the generic type parameter for the return type
  - Implement the abstract `ExecuteAsync` method
  - Use the base class for common functionality
- **Example**: `src/Application/UseCases/BaseUseCases.cs`

## 4. Capabilities-based Skills

### Use Case Framework
- **Type**: Capabilities-based
- **Description**: Complete use case framework functionality
- **Capabilities**:
  - Generic use case base class
  - Async execution support
  - Dependency injection integration
  - Domain-based organization
  - Testable design
  - Business logic encapsulation
- **Implementation**: `src/Application/UseCases/BaseUseCases.cs`

### Domain Use Case Collections
- **Type**: Capabilities-based
- **Description**: Collection of use cases organized by domain
- **Capabilities**:
  - Album management operations
  - Folder navigation and management
  - Image retrieval and manipulation
  - Tag creation and association
  - Cross-domain use case coordination
- **Implementation**: Domain subdirectories in `src/Application/UseCases/`

## How to Use These Skills

### For Adding New Use Cases
1. Identify the appropriate domain directory
2. Create the use case class following naming conventions
3. Inherit from `BaseUseCases<T>` with the appropriate return type
4. Add repository dependencies via constructor
5. Implement the `ExecuteAsync` method with business logic
6. Register the use case in the DI container
7. Test thoroughly

### For Modifying Existing Use Cases
1. Locate the use case in its domain directory
2. Make changes to the business logic
3. Ensure the changes don't break existing functionality
4. Update tests if needed
5. Verify the use case still works correctly

### For Organizing Use Cases
1. Evaluate if existing domain categories are appropriate
2. Create new domain directories if needed
3. Move use cases to their appropriate domains
4. Update DI container registrations if necessary
5. Update any references to the moved use cases

This skills document provides a framework for effectively working with the Use Cases directory of the AVA AIGC Toolbox. Follow these guidelines to ensure consistent and maintainable use case implementation.