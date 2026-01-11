# Simplified Skills List for AVA AIGC Toolbox

## 1. Workflow-based Skills
For tasks with fixed sequences:

### Image Processing Workflow
- **Type**: Workflow-based
- **Description**: Complete process for managing AI-generated images from import to organization
- **Steps**:
  1. Retrieve images using `GetAllImagesUseCase` or `GetImagesByFolderIdUseCase`
  2. Extract metadata from image files
  3. Apply tags using `AddTagToImageUseCase`
  4. Organize into albums using `AddImageToAlbumUseCase`
  5. Update database records automatically via use cases
- **Implementation**: Multiple use cases across Images/Tags/Albums folders

### Album Creation Workflow
- **Type**: Workflow-based
- **Description**: Process for creating new albums and adding images
- **Steps**:
  1. Create album with `AddAlbumUseCase`
  2. Retrieve images to add using image retrieval use cases
  3. Add images to album with `AddImageToAlbumUseCase`
  4. Verify album contents with `GetImagesByAlbumIdUseCase`
- **Implementation**: Album-related use cases in `Application/UseCases/Albums/`

## 2. Task-based Skills
For multiple operations in the same domain:

### Image Operations
- **Type**: Task-based
- **Description**: Collection of image management operations
- **Operations**:
  - GetAllImages: `Application/UseCases/Images/GetAllImagesUseCase.cs`
  - GetImagesByFolderId: `Application/UseCases/Images/GetImagesByFolderIdUseCase.cs`

### Folder Operations
- **Type**: Task-based
- **Description**: Collection of folder management operations
- **Operations**:
  - GetAllFolders: `Application/UseCases/Folders/GetAllFoldersUseCase.cs`
  - GetRootFolders: `Application/UseCases/Folders/GetRootFoldersUseCase.cs`

### Album Operations
- **Type**: Task-based
- **Description**: Collection of album management operations
- **Operations**:
  - GetAllAlbums: `Application/UseCases/Albums/GetAllAlbumsUseCase.cs`
  - GetAlbumById: `Application/UseCases/Albums/GetAlbumByIdUseCase.cs`
  - AddAlbum: `Application/UseCases/Albums/AddAlbumUseCase.cs`
  - AddImageToAlbum: `Application/UseCases/Albums/AddImageToAlbumUseCase.cs`
  - GetImagesByAlbumId: `Application/UseCases/Albums/GetImagesByAlbumIdUseCase.cs`

### Tag Operations
- **Type**: Task-based
- **Description**: Collection of tag management operations
- **Operations**:
  - GetAllTags: `Application/UseCases/Tags/GetAllTagsUseCase.cs`
  - AddTag: `Application/UseCases/Tags/AddTagUseCase.cs`
  - GetTagsByImageId: `Application/UseCases/Tags/GetTagsByImageIdUseCase.cs`
  - AddTagToImage: `Application/UseCases/Tags/AddTagToImageUseCase.cs`
  - RemoveTagFromImage: `Application/UseCases/Tags/RemoveTagFromImageUseCase.cs`

## 3. Reference/Guidelines
For standards and best practices:

### Clean Architecture Guidelines
- **Type**: Reference
- **Description**: Architecture standards for the project
- **Guidelines**:
  - Follow clean architecture layers: Presentation → Application → Core → Infrastructure
  - Use use case pattern for all application logic
  - Implement interfaces in Core layer, concretions in Infrastructure
- **Example**: `Core/Application/Ports/` (interfaces) + `Infrastructure/Repositories/` (implementations)

### Dependency Injection Guidelines
- **Type**: Reference
- **Description**: DI configuration standards
- **Guidelines**:
  - Register all dependencies in `Presentation/App.axaml.cs` (ConfigureServices method)
  - Use transient lifetime for use cases
  - Use singleton lifetime for repositories and database context
- **Example**: `Presentation/App.axaml.cs` lines 49-97

### Repository Pattern Guidelines
- **Type**: Reference
- **Description**: Data access implementation standards
- **Guidelines**:
  - Implement all repository interfaces from Core/Application/Ports
  - Use SQLite-net for database operations
  - Include basic CRUD operations for all entities
- **Example**: `Infrastructure/Repositories/SQLiteImageRepository.cs`

## 4. Capabilities-based Skills
For comprehensive system capabilities:

### Image Management System
- **Type**: Capabilities-based
- **Description**: Complete image management functionality
- **Capabilities**:
  - Image retrieval and filtering by folder/album
  - Metadata extraction and storage
  - Tagging and categorization
  - Album organization
  - Image rating and favoriting
- **Implementation**: Core/Domain/Entities/Image.cs + all image-related use cases

### Tagging System
- **Type**: Capabilities-based
- **Description**: Complete tagging functionality
- **Capabilities**:
  - Tag creation and management
  - Image-tag associations
  - Tag filtering and search
  - Tag removal from images
- **Implementation**: Core/Domain/Entities/Tag.cs + ImageTag.cs + tag-related use cases

### Data Persistence System
- **Type**: Capabilities-based
- **Description**: Database and data access functionality
- **Capabilities**:
  - SQLite database management
  - Repository pattern implementation
  - Data migration support
  - Connection management
- **Implementation**: Infrastructure/Data/DatabaseContext.cs + all repository classes

## How to Use This Skills List

1. **Workflow-based Skills**: Follow these for step-by-step processes
2. **Task-based Skills**: Use these for individual operations within a domain
3. **Reference/Guidelines**: Consult these for coding standards and best practices
4. **Capabilities-based Skills**: Understand these for comprehensive system functionality

This simplified skills list provides a clear, organized reference for managing the AVA AIGC Toolbox project.