# Tags Use Cases Skills

## Overview
This document defines the skills for working with the Tags use cases in the AVA AIGC Toolbox. These use cases handle all tag-related functionality, including creation, association with images, and retrieval.

## 1. Workflow-based Skills

### Tag Management Workflow
- **Type**: Workflow-based
- **Description**: Complete process for managing tags and their associations
- **Steps**:
  1. Create a tag using `AddTagUseCase`
  2. Get all tags using `GetAllTagsUseCase`
  3. Add tag to image using `AddTagToImageUseCase`
  4. Get tags for an image using `GetTagsByImageIdUseCase`
  5. Remove tag from image using `RemoveTagFromImageUseCase`
- **Implementation**: Follow the sequence in existing tag use cases

### Image Tagging Workflow
- **Type**: Workflow-based
- **Description**: Process for tagging images
- **Steps**:
  1. Select an image
  2. Get all available tags
  3. Choose tags to add
  4. Add tags to the image
  5. Verify tags were added correctly
- **Implementation**: Combine tag use cases with image selection

## 2. Task-based Skills

### Tag Operations
- **Type**: Task-based
- **Description**: Collection of tag-related operations
- **Operations**:
  - AddTag: `AddTagUseCase.cs` - Creates a new tag
  - GetAllTags: `GetAllTagsUseCase.cs` - Retrieves all tags
  - GetTagsByImageId: `GetTagsByImageIdUseCase.cs` - Gets tags for a specific image
  - AddTagToImage: `AddTagToImageUseCase.cs` - Associates a tag with an image
  - RemoveTagFromImage: `RemoveTagFromImageUseCase.cs` - Removes a tag association

### Tag Use Case Dependencies
- **Type**: Task-based
- **Description**: Dependencies required by tag use cases
- **Dependencies**:
  - `ITagRepository`: For tag data access
  - `IImageTagRepository`: For image-tag relationship data access
  - `DatabaseContext`: For database operations

## 3. Reference/Guidelines

### Tag Use Case Implementation Guidelines
- **Type**: Reference
- **Description**: Standards for implementing tag use cases
- **Guidelines**:
  - All tag use cases must inherit from `BaseUseCases<T>`
  - Use `ITagRepository` for tag data operations
  - Use `IImageTagRepository` for image-tag relationship operations
  - Return domain objects (Tag, IEnumerable<Tag>, etc.)
  - Handle invalid tag/image IDs appropriately
  - Implement proper error handling
- **Example**: `AddTagUseCase.cs`

### Tag Naming Conventions
- **Type**: Reference
- **Description**: Naming standards for tag-related components
- **Guidelines**:
  - Tag use cases: `{Operation}TagUseCase.cs` or `{Operation}TagToImageUseCase.cs`
  - Tag entity: `Tag.cs`
  - Tag repository: `ITagRepository.cs` and `SQLiteTagRepository.cs`
  - Image-tag repository: `IImageTagRepository.cs` and `SQLiteImageTagRepository.cs`

## 4. Capabilities-based Skills

### Tag Management System
- **Type**: Capabilities-based
- **Description**: Complete tag management functionality
- **Capabilities**:
  - Tag creation and retrieval
  - Image-tag association management
  - Tag filtering by image
  - Tag statistics and counts
- **Implementation**: All tag use cases in this directory

### Image Tagging System
- **Type**: Capabilities-based
- **Description**: Functionality for tagging images
- **Capabilities**:
  - Adding multiple tags to images
  - Removing tags from images
  - Viewing tags for specific images
  - Filtering images by tags (future)
- **Implementation**: `AddTagToImageUseCase.cs`, `RemoveTagFromImageUseCase.cs`, and `GetTagsByImageIdUseCase.cs`

## How to Use These Skills

### For Working with Tag Use Cases
1. Identify the tag operation needed
2. Use the appropriate use case class
3. Inject the required repositories
4. Call the `ExecuteAsync` method with appropriate parameters
5. Handle the returned results

### For Adding New Tag Functionality
1. Create a new use case class following naming conventions
2. Inherit from `BaseUseCases<T>` with appropriate return type
3. Inject necessary repositories
4. Implement business logic in `ExecuteAsync` method
5. Register in DI container
6. Test thoroughly

### For Image Tagging
1. Get an image ID from image selection
2. Use `GetAllTagsUseCase` to get available tags
3. Select tags to add
4. Call `AddTagToImageUseCase.ExecuteAsync(imageId, tagId)` for each tag
5. Verify with `GetTagsByImageIdUseCase`

This skills document provides a framework for effectively working with the Tags use cases. Follow these guidelines to ensure consistent and maintainable tag-related functionality.