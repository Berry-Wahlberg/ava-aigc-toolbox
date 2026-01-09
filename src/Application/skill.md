# Application Layer Skills

## Overview
This document defines the skills for working with the Application layer of the AVA AIGC Toolbox. The Application layer contains use cases and application logic that orchestrate the flow of data between the Presentation layer and the Core layer.

## 1. Workflow-based Skills

### Use Case Development Workflow
- **Type**: Workflow-based
- **Description**: Complete process for developing new use cases in the application
- **Steps**:
  1. Identify the business operation to implement
  2. Create a new use case class in the appropriate subdirectory
  3. Implement the ExecuteAsync method with the business logic
  4. Add necessary repository dependencies via constructor
  5. Register the use case in the dependency injection container
  6. Test the use case functionality
- **Implementation**: Follow the pattern in existing use cases (e.g., `GetAllImagesUseCase.cs`)

## 2. Task-based Skills

### Use Case Operations
- **Type**: Task-based
- **Description**: Collection of operations for working with use cases
- **Operations**:
  - CreateUseCase: Create a new use case class inheriting from `BaseUseCases<T>`
  - ImplementExecuteMethod: Add business logic to the ExecuteAsync method
  - InjectDependencies: Add repository dependencies via constructor
  - RegisterInDI: Add use case to the ServiceCollection in `App.axaml.cs`
  - TestUseCase: Verify use case functionality with unit tests

### Use Case Categories
- **Type**: Task-based
- **Description**: Organization of use cases by domain
- **Categories**:
  - Albums: `src/Application/UseCases/Albums/`
  - Folders: `src/Application/UseCases/Folders/`
  - Images: `src/Application/UseCases/Images/`
  - Tags: `src/Application/UseCases/Tags/`

## 3. Reference/Guidelines

### Use Case Best Practices
- **Type**: Reference
- **Description**: Guidelines for implementing effective use cases
- **Guidelines**:
  - Each use case should represent a single business operation
  - Use cases should be named clearly (e.g., `AddAlbumUseCase.cs`)
  - Use cases should only depend on repository interfaces from the Core layer
  - Use cases should return domain objects, not DTOs
  - Use cases should handle business logic, not data access
- **Example**: `src/Application/UseCases/Images/GetAllImagesUseCase.cs`

### Dependency Injection Guidelines
- **Type**: Reference
- **Description**: Standards for injecting dependencies into use cases
- **Guidelines**:
  - Use constructor injection for all dependencies
  - Inject only the specific repository interfaces needed
  - Do not inject concrete implementations
  - Use the appropriate lifetime (transient for use cases)
- **Example**: `src/Application/UseCases/Images/GetAllImagesUseCase.cs` lines 10-13

## 4. Capabilities-based Skills

### Application Logic Layer
- **Type**: Capabilities-based
- **Description**: Complete application logic functionality
- **Capabilities**:
  - Use case pattern implementation
  - Business rule enforcement
  - Data flow orchestration
  - Error handling and validation
  - Transaction management
- **Implementation**: `src/Application/` directory structure

### Use Case Framework
- **Type**: Capabilities-based
- **Description**: Framework for developing and executing use cases
- **Capabilities**:
  - Base use case class (`BaseUseCases.cs`)
  - Generic return type support
  - Async execution pattern
  - Dependency injection integration
- **Implementation**: `src/Application/UseCases/BaseUseCases.cs`

## How to Use These Skills

### For New Use Case Development
1. Follow the **Use Case Development Workflow**
2. Refer to **Use Case Best Practices** for guidance
3. Use the **Use Case Operations** as a checklist
4. Register the new use case in the dependency injection container

### For Modifying Existing Use Cases
1. Identify the use case to modify by category
2. Follow the existing implementation pattern
3. Test thoroughly after changes
4. Update documentation if needed

### For Troubleshooting
1. Check use case dependencies are properly registered
2. Verify repository methods are being called correctly
3. Ensure business logic is sound
4. Test with different input scenarios

This skills document provides a framework for effectively working with the Application layer of the AVA AIGC Toolbox. Follow these guidelines to ensure consistent, maintainable, and effective application logic implementation.