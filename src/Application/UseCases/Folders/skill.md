# Folders Use Cases Skills

## Overview
This document defines the skills for working with the Folders use cases in the AVA AIGC Toolbox. These use cases handle all folder-related functionality, including retrieval of folders and folder structure.

## 1. Workflow-based Skills

### Folder Navigation Workflow
- **Type**: Workflow-based
- **Description**: Process for navigating the folder structure
- **Steps**:
  1. Get root folders using `GetRootFoldersUseCase`
  2. Display root folders in the UI
  3. When a folder is selected, get child folders (future)
  4. Retrieve images in the selected folder using `GetImagesByFolderIdUseCase`
- **Implementation**: Follow the sequence in existing folder use cases

### Folder Image Browsing Workflow
- **Type**: Workflow-based
- **Description**: Process for browsing images by folder
- **Steps**:
  1. Get all folders using `GetAllFoldersUseCase`
  2. Select a specific folder
  3. Retrieve images in that folder using `GetImagesByFolderIdUseCase`
  4. Display the images in the UI
- **Implementation**: `GetAllFoldersUseCase.cs` and external `GetImagesByFolderIdUseCase.cs`

## 2. Task-based Skills

### Folder Operations
- **Type**: Task-based
- **Description**: Collection of folder-related operations
- **Operations**:
  - GetAllFolders: `GetAllFoldersUseCase.cs` - Retrieves all folders
  - GetRootFolders: `GetRootFoldersUseCase.cs` - Retrieves top-level folders

### Folder Use Case Dependencies
- **Type**: Task-based
- **Description**: Dependencies required by folder use cases
- **Dependencies**:
  - `IFolderRepository`: For folder data access
  - `DatabaseContext`: For database operations

## 3. Reference/Guidelines

### Folder Use Case Implementation Guidelines
- **Type**: Reference
- **Description**: Standards for implementing folder use cases
- **Guidelines**:
  - All folder use cases must inherit from `BaseUseCases<T>`
  - Use `IFolderRepository` for all folder data operations
  - Return domain objects (IEnumerable<Folder>)
  - Implement proper error handling
- **Example**: `GetRootFoldersUseCase.cs`

### Folder Naming Conventions
- **Type**: Reference
- **Description**: Naming standards for folder-related components
- **Guidelines**:
  - Folder use cases: `{Operation}FoldersUseCase.cs`
  - Folder entity: `Folder.cs`
  - Folder repository: `IFolderRepository.cs` and `SQLiteFolderRepository.cs`

## 4. Capabilities-based Skills

### Folder Navigation System
- **Type**: Capabilities-based
- **Description**: Complete folder navigation functionality
- **Capabilities**:
  - Root folder retrieval
  - Full folder structure access
  - Folder hierarchy management
  - Integration with image browsing
- **Implementation**: All folder use cases in this directory

### Folder Image Integration
- **Type**: Capabilities-based
- **Description**: Functionality for integrating folders with images
- **Capabilities**:
  - Folder-based image filtering
  - Image count per folder
  - Folder navigation for images
  - Hierarchical image organization
- **Implementation**: Folder use cases combined with image use cases

## How to Use These Skills

### For Working with Folder Use Cases
1. Identify the folder operation needed
2. Use the appropriate use case class
3. Inject the required repository (`IFolderRepository`)
4. Call the `ExecuteAsync` method
5. Handle the returned folder collection

### For Adding New Folder Functionality
1. Create a new use case class following naming conventions
2. Inherit from `BaseUseCases<T>` with appropriate return type
3. Inject necessary repositories
4. Implement business logic in `ExecuteAsync` method
5. Register in DI container
6. Test thoroughly

### For Folder-Image Integration
1. Use `GetRootFoldersUseCase` or `GetAllFoldersUseCase` to get folders
2. Pass the selected folder ID to `GetImagesByFolderIdUseCase`
3. Display the resulting images in the UI
4. Update the UI when folder selection changes

This skills document provides a framework for effectively working with the Folders use cases. Follow these guidelines to ensure consistent and maintainable folder-related functionality.