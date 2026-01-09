# Images Use Cases Skills

## Overview
This document defines the skills for working with the Images use cases in the AVA AIGC Toolbox. These use cases handle all image-related functionality, including retrieval and management of AI-generated images.

## 1. Workflow-based Skills

### Image Retrieval Workflow
- **Type**: Workflow-based
- **Description**: Process for retrieving images by different criteria
- **Steps**:
  1. Decide on retrieval criteria (all images, by folder)
  2. Use the appropriate use case (`GetAllImagesUseCase` or `GetImagesByFolderIdUseCase`)
  3. Call the `ExecuteAsync` method with required parameters
  4. Handle the returned image collection
  5. Display or process the images as needed
- **Implementation**: Follow the sequence in existing image use cases

### Image Browsing Workflow
- **Type**: Workflow-based
- **Description**: Complete process for browsing images in the application
- **Steps**:
  1. Start with either all images or root folders
  2. If browsing by folder, get root folders first
  3. Select a folder and retrieve its images
  4. View image details when an image is selected
  5. Navigate between folders or albums
- **Implementation**: Combine folder and image use cases

## 2. Task-based Skills

### Image Operations
- **Type**: Task-based
- **Description**: Collection of image-related operations
- **Operations**:
  - GetAllImages: `GetAllImagesUseCase.cs` - Retrieves all images
  - GetImagesByFolderId: `GetImagesByFolderIdUseCase.cs` - Retrieves images in a specific folder

### Image Use Case Dependencies
- **Type**: Task-based
- **Description**: Dependencies required by image use cases
- **Dependencies**:
  - `IImageRepository`: For image data access
  - `DatabaseContext`: For database operations

## 3. Reference/Guidelines

### Image Use Case Implementation Guidelines
- **Type**: Reference
- **Description**: Standards for implementing image use cases
- **Guidelines**:
  - All image use cases must inherit from `BaseUseCases<T>`
  - Use `IImageRepository` for all image data operations
  - Return domain objects (IEnumerable<Image>)
  - Handle invalid folder IDs appropriately
  - Implement proper error handling
- **Example**: `GetAllImagesUseCase.cs`

### Image Naming Conventions
- **Type**: Reference
- **Description**: Naming standards for image-related components
- **Guidelines**:
  - Image use cases: `{Operation}ImagesUseCase.cs` or `{Operation}ImagesBy{Criteria}UseCase.cs`
  - Image entity: `Image.cs`
  - Image repository: `IImageRepository.cs` and `SQLiteImageRepository.cs`

## 4. Capabilities-based Skills

### Image Retrieval System
- **Type**: Capabilities-based
- **Description**: Complete image retrieval functionality
- **Capabilities**:
  - All-images retrieval
  - Folder-based image filtering
  - Image metadata access
  - Large image collection handling
- **Implementation**: All image use cases in this directory

### Image Management Integration
- **Type**: Capabilities-based
- **Description**: Functionality for integrating images with other systems
- **Capabilities**:
  - Integration with folder system
  - Integration with tagging system
  - Integration with album system
  - Cross-domain data access
- **Implementation**: Image use cases combined with other domain use cases

## How to Use These Skills

### For Working with Image Use Cases
1. Identify the image operation needed
2. Use the appropriate use case class
3. Inject the required repository (`IImageRepository`)
4. Call the `ExecuteAsync` method with appropriate parameters
5. Handle the returned image collection

### For Adding New Image Functionality
1. Create a new use case class following naming conventions
2. Inherit from `BaseUseCases<T>` with appropriate return type
3. Inject necessary repositories
4. Implement business logic in `ExecuteAsync` method
5. Register in DI container
6. Test thoroughly

### For Image-Folder Integration
1. Use `GetRootFoldersUseCase` to get root folders
2. When a folder is selected, use `GetImagesByFolderIdUseCase` with the folder ID
3. Display the resulting images in the UI
4. Update the image collection when folder selection changes

This skills document provides a framework for effectively working with the Images use cases. Follow these guidelines to ensure consistent and maintainable image-related functionality.