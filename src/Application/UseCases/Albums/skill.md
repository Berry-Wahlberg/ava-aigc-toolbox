# Albums Use Cases Skills

## Overview
This document defines the skills for working with the Albums use cases in the AVA AIGC Toolbox. These use cases handle all album-related functionality, including creation, retrieval, and image management within albums.

## 1. Workflow-based Skills

### Album Management Workflow
- **Type**: Workflow-based
- **Description**: Complete process for managing albums and their images
- **Steps**:
  1. Create an album using `AddAlbumUseCase`
  2. Retrieve all albums using `GetAllAlbumsUseCase`
  3. Get a specific album using `GetAlbumByIdUseCase`
  4. Add images to the album using `AddImageToAlbumUseCase`
  5. Retrieve album images using `GetImagesByAlbumIdUseCase`
- **Implementation**: Follow the sequence in existing album use cases

### Album Creation Workflow
- **Type**: Workflow-based
- **Description**: Process for creating a new album and populating it with images
- **Steps**:
  1. Create album with name and metadata
  2. Call `AddAlbumUseCase.ExecuteAsync(album)`
  3. Get the created album ID from the result
  4. Add images to the album using the album ID
  5. Verify album creation and image addition
- **Implementation**: `AddAlbumUseCase.cs` and `AddImageToAlbumUseCase.cs`

## 2. Task-based Skills

### Album Operations
- **Type**: Task-based
- **Description**: Collection of album-related operations
- **Operations**:
  - AddAlbum: `AddAlbumUseCase.cs` - Creates a new album
  - AddImageToAlbum: `AddImageToAlbumUseCase.cs` - Adds an image to an album
  - GetAlbumById: `GetAlbumByIdUseCase.cs` - Retrieves a specific album
  - GetAllAlbums: `GetAllAlbumsUseCase.cs` - Retrieves all albums
  - GetImagesByAlbumId: `GetImagesByAlbumIdUseCase.cs` - Gets images in an album

### Album Use Case Dependencies
- **Type**: Task-based
- **Description**: Dependencies required by album use cases
- **Dependencies**:
  - `IAlbumRepository`: For album data access
  - `IImageRepository`: For image data access in some cases
  - `DatabaseContext`: For database operations

## 3. Reference/Guidelines

### Album Use Case Implementation Guidelines
- **Type**: Reference
- **Description**: Standards for implementing album use cases
- **Guidelines**:
  - All album use cases must inherit from `BaseUseCases<T>`
  - Use `IAlbumRepository` for all album data operations
  - Return domain objects (Album, IEnumerable<Image>, etc.)
  - Handle invalid album IDs appropriately
  - Implement proper error handling
- **Example**: `AddAlbumUseCase.cs`

### Album Naming Conventions
- **Type**: Reference
- **Description**: Naming standards for album-related components
- **Guidelines**:
  - Album use cases: `{Operation}AlbumUseCase.cs` or `{Operation}ImageToAlbumUseCase.cs`
  - Album entity: `Album.cs`
  - Album repository: `IAlbumRepository.cs` and `SQLiteAlbumRepository.cs`

## 4. Capabilities-based Skills

### Album Management System
- **Type**: Capabilities-based
- **Description**: Complete album management functionality
- **Capabilities**:
  - Album creation and retrieval
  - Image-album association management
  - Album image retrieval
  - Album metadata management
  - Cross-domain integration with images
- **Implementation**: All album use cases in this directory

### Album Image Management
- **Type**: Capabilities-based
- **Description**: Functionality for managing images within albums
- **Capabilities**:
  - Adding images to albums
  - Removing images from albums (future)
  - Retrieving album images with filters
  - Album image count tracking
- **Implementation**: `AddImageToAlbumUseCase.cs` and `GetImagesByAlbumIdUseCase.cs`

## How to Use These Skills

### For Working with Album Use Cases
1. Identify the album operation needed
2. Use the appropriate use case class
3. Inject the required repositories
4. Call the `ExecuteAsync` method with appropriate parameters
5. Handle the returned domain objects

### For Adding New Album Functionality
1. Create a new use case class following naming conventions
2. Inherit from `BaseUseCases<T>` with appropriate return type
3. Inject necessary repositories
4. Implement business logic in `ExecuteAsync` method
5. Register in DI container
6. Test thoroughly

### For Troubleshooting Album Issues
1. Verify album repository implementation
2. Check for valid album IDs in parameters
3. Ensure image IDs exist when adding to albums
4. Verify database connections
5. Test use cases in isolation

This skills document provides a framework for effectively working with the Albums use cases. Follow these guidelines to ensure consistent and maintainable album-related functionality.