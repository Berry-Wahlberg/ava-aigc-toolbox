# AI Project Management Prompt for AVA AIGC Toolbox

## Project Overview
This is a cross-platform AIGC (AI-Generated Content) image toolbox built with Avalonia & .NET. It supports AI-powered image organization, tagging, batch processing, format conversion, and AIGC workflow assistant. Runs seamlessly on Windows, macOS and Linux.

## Task Objectives
1. **Search the project catalog** to understand the codebase structure and functionality
2. **Compile a comprehensive skills list** that documents all available capabilities
3. **Guide the AI on how to use these skills** for effective project management

## Step 1: Project Catalog Exploration
Your first task is to explore the project structure. The main directories are:

```
- src/
  - Application/          # Use cases and application logic
  - Core/                # Domain models and interfaces
  - Infrastructure/      # Data access and external integrations
  - Presentation/        # UI components and view models
```

Use the following approach to explore:

1. **Examine project structure**:
   - List all directories and files to get an overview
   - Focus on the main csproj files to understand project dependencies

2. **Analyze architecture patterns**:
   - Identify the clean architecture layers (Presentation → Application → Core → Infrastructure)
   - Understand the dependency injection setup in `App.axaml.cs`
   - Examine the use case pattern implementation

3. **Map domain entities**:
   - Study the core domain entities in `Core/Domain/Entities/`
   - Understand the relationships between Image, Folder, Album, Tag, and ImageTag

4. **Document functionality**:
   - Explore each use case to understand what operations are available
   - Track how data flows from repositories to use cases to view models

## Step 2: Skills List Compilation

Skills are organized into 4 types:

### 1. Workflow-based Skills
For tasks with fixed sequences:
```
- Skill: Image Processing Workflow
  - Type: Workflow-based
  - Description: Complete process for managing AI-generated images
  - Steps:
    1. Retrieve images from database
    2. Apply tags and metadata
    3. Organize into albums/folders
    4. Update database records
  - Implementation: Multiple use cases across Images/Tags/Albums folders
```

### 2. Task-based Skills
For multiple operations in the same domain:
```
- Skill: Image Operations
  - Type: Task-based
  - Description: Collection of image management operations
  - Operations:
    - GetAllImages: `Application/UseCases/Images/GetAllImagesUseCase.cs`
    - GetImagesByFolderId: `Application/UseCases/Images/GetImagesByFolderIdUseCase.cs`
    - [Other image-related operations]
```

### 3. Reference/Guidelines
For standards and best practices:
```
- Skill: Code Style Guidelines
  - Type: Reference
  - Description: Coding standards for the project
  - Guidelines:
    - Follow clean architecture principles
    - Use use case pattern for application logic
    - Implement dependency injection via ServiceCollection
  - Example: `Presentation/App.axaml.cs` (ConfigureServices method)
```

### 4. Capabilities-based Skills
For comprehensive system capabilities:
```
- Skill: Image Management System
  - Type: Capabilities-based
  - Description: Complete image management functionality
  - Capabilities:
    - Image retrieval and filtering
    - Metadata extraction and storage
    - Tagging and categorization
    - Album organization
  - Implementation: Core/Domain/Entities/Image.cs + related use cases
```

### Required Skills Coverage
Your skills list must cover:
- Image management workflows and tasks
- Folder and album organization
- Tagging system operations
- Data access capabilities
- Code quality guidelines

## Step 3: Guide for Using Skills
Once you have compiled the skills list, create a guide that explains:

1. **How to navigate the codebase** using the skills list as a reference
2. **How to implement new features** by leveraging existing skills
3. **How to debug issues** by tracing through the skills dependencies
4. **How to refactor code** while maintaining skill integrity

### Example Usage Guide

```
# Using the Skills List

## Implementing a New Feature: Image Rating Filter

1. **Identify existing relevant skills**:
   - Image Management: Get All Images
   - Image Management: Get Images By Folder Id

2. **Plan new skill**:
   - Skill: Get Images By Rating
   - Description: Retrieves images with a specific rating
   - Implementation: Create new use case `GetImagesByRatingUseCase.cs`
   - Dependencies: Extend `IImageRepository` with `GetByRatingAsync()`

3. **Implementation steps**:
   a. Add new method to `IImageRepository` interface
   b. Implement method in `SQLiteImageRepository`
   c. Create new use case `GetImagesByRatingUseCase`
   d. Register use case in dependency injection container
   e. Add to view model and UI

4. **Test the new skill**:
   - Verify repository method works
   - Test use case with different ratings
   - Ensure UI displays filtered results correctly
```

## Expected Outputs
1. **Project Catalog Summary**: A structured overview of the codebase
2. **Comprehensive Skills List**: All application capabilities documented with implementation details
3. **Usage Guide**: Instructions for leveraging the skills list for project management

## Success Criteria
- The skills list covers all major application functionalities
- Each skill entry is complete with description, implementation location, usage, and dependencies
- The usage guide provides clear instructions for using the skills list
- The output demonstrates a deep understanding of the project architecture and functionality

## Additional Notes
- Follow the existing clean architecture patterns when suggesting new features
- Maintain consistency with the current coding style and conventions
- Focus on the core functionality first, then expand to edge cases
- Document any assumptions or areas that need further clarification

Now begin your exploration and compilation process. Good luck!