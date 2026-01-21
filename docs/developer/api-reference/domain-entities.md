# Domain Entities API Reference

This document provides detailed information about the core domain entities in the AVA AIGC Toolbox.

## Image

Represents an AI-generated image with associated metadata.

### Properties

| Property | Type | Nullable | Description |
|----------|------|----------|-------------|
| `Id` | `int` | No | Unique identifier for the image |
| `RootFolderId` | `int` | No | ID of the root folder containing this image |
| `FolderId` | `int` | No | ID of the immediate folder containing this image |
| `Path` | `string` | No | Full file system path to the image file |
| `FileName` | `string` | No | Name of the image file |
| `Prompt` | `string` | Yes | The prompt used to generate the image |
| `NegativePrompt` | `string` | Yes | The negative prompt used in generation |
| `Steps` | `int` | No | Number of generation steps |
| `Sampler` | `string` | Yes | Name of the sampler used |
| `CFGScale` | `decimal` | No | CFG scale value |
| `Seed` | `long` | No | Seed value used for generation |
| `Width` | `int` | No | Image width in pixels |
| `Height` | `int` | No | Image height in pixels |
| `ModelHash` | `string` | Yes | Hash of the model used |
| `Model` | `string` | Yes | Name of the model used |
| `BatchSize` | `int` | No | Batch size used in generation |
| `BatchPos` | `int` | No | Position in the batch |
| `CreatedDate` | `DateTime` | No | Date the image was created |
| `ModifiedDate` | `DateTime` | No | Date the image was last modified |
| `CustomTags` | `string` | Yes | User-defined custom tags |
| `Rating` | `int` | Yes | User-assigned rating (1-5) |
| `Favorite` | `bool` | No | Whether the image is marked as a favorite |
| `ForDeletion` | `bool` | No | Whether the image is marked for deletion |
| `NSFW` | `bool` | No | Whether the image is marked as NSFW |
| `Unavailable` | `bool` | No | Whether the image file is unavailable |
| `AestheticScore` | `decimal` | Yes | Aesthetic score of the image |
| `HyperNetwork` | `string` | Yes | Hypernetwork used (if any) |
| `HyperNetworkStrength` | `decimal` | Yes | Hypernetwork strength value |
| `ClipSkip` | `int` | Yes | Clip skip value |
| `ENSD` | `int` | Yes | ENSD value |
| `FileSize` | `long` | No | Size of the image file in bytes |
| `NoMetadata` | `bool` | No | Whether the image has no metadata |
| `Workflow` | `string` | Yes | Workflow used (if any) |
| `WorkflowId` | `string` | Yes | Workflow ID (if any) |
| `HasError` | `bool` | No | Whether there was an error processing the image |
| `Hash` | `string` | Yes | Image hash value |
| `ViewedDate` | `DateTime` | Yes | Date the image was last viewed |
| `TouchedDate` | `DateTime` | Yes | Date the image was last touched |
| `Type` | `ImageType` | No | Type of image (enum) |

### Constructors

```csharp
// Parameterless constructor (required for ORM)
public Image() {}

// Main constructor
public Image(string path, string fileName)
```

### ImageType Enum

| Value | Description |
|-------|-------------|
| `Image` | Standard image |
| `Video` | Video file |
| `Other` | Other media type |

## Folder

Represents a filesystem folder containing images.

### Properties

| Property | Type | Nullable | Description |
|----------|------|----------|-------------|
| `Id` | `int` | No | Unique identifier for the folder |
| `ParentId` | `int` | No | ID of the parent folder (0 for root folders) |
| `Path` | `string` | No | Full file system path to the folder |
| `ImageCount` | `int` | No | Number of images in the folder |
| `ScannedDate` | `DateTime` | No | Date the folder was last scanned |
| `Unavailable` | `bool` | No | Whether the folder is unavailable |
| `Archived` | `bool` | No | Whether the folder is archived |
| `Excluded` | `bool` | No | Whether the folder is excluded from scanning |
| `IsRoot` | `bool` | No | Whether the folder is a root folder |
| `Recursive` | `bool` | No | Whether the folder is scanned recursively |
| `Watched` | `bool` | No | Whether the folder is watched for changes |

### Constructors

```csharp
// Parameterless constructor (required for ORM)
public Folder() {}

// Main constructor
public Folder(string path)
```

## Album

Represents a user-created collection of images.

### Properties

| Property | Type | Nullable | Description |
|----------|------|----------|-------------|
| `Id` | `int` | No | Unique identifier for the album |
| `Name` | `string` | No | Name of the album |
| `Order` | `int` | No | Display order of the album |
| `LastUpdated` | `DateTime` | No | Date the album was last updated |

### Constructors

```csharp
// Parameterless constructor (required for ORM)
public Album() {}

// Main constructor
public Album(string name)
```

## Tag

Represents a keyword used to categorize images.

### Properties

| Property | Type | Nullable | Description |
|----------|------|----------|-------------|
| `Id` | `int` | No | Unique identifier for the tag |
| `Name` | `string` | No | Name of the tag |

### Constructors

```csharp
// Parameterless constructor (required for ORM)
public Tag() {}

// Main constructor
public Tag(string name)
```

## ImageTag

Join entity that links images to tags.

### Properties

| Property | Type | Nullable | Description |
|----------|------|----------|-------------|
| `ImageId` | `int` | No | ID of the image |
| `TagId` | `int` | No | ID of the tag |

### Constructors

```csharp
// Parameterless constructor (required for ORM)
public ImageTag() {}

// Main constructor
public ImageTag(int imageId, int tagId)
```

## Model

Represents an AI model used to generate images.

### Properties

| Property | Type | Nullable | Description |
|----------|------|----------|-------------|
| `Id` | `int` | No | Unique identifier for the model |
| `Name` | `string` | No | Name of the model |
| `Hash` | `string` | Yes | Hash of the model |
| `Path` | `string` | No | File system path to the model file |
| `Type` | `string` | No | Type of model |
| `Size` | `long` | No | Size of the model file in bytes |
| `LastModified` | `DateTime` | No | Date the model was last modified |
| `Description` | `string` | Yes | Description of the model |

### Constructors

```csharp
// Parameterless constructor (required for ORM)
public Model() {}

// Main constructor
public Model(string name, string path, string type)
```

## Entity Relationships

```
┌───────────┐      ┌───────────┐
│   Image   │      │   Folder  │
└───────────┘      └───────────┘
       │                 │
       │ 1              1│
       │ ────────────────┘
       │ N
       ▼
┌───────────┐      ┌───────────┐
│ ImageTag  │──────│    Tag    │
└───────────┘ N    └───────────┘
       │ 1
       │
       ▼
┌───────────┐
│   Album   │
└───────────┘
```

### Relationship Details

1. **Image - Folder**: Many-to-one (Many images belong to one folder)
2. **Image - Tag**: Many-to-many (Many images can have many tags, through ImageTag join table)
3. **Image - Album**: Many-to-many (Many images can belong to many albums, through a join table not shown above)
4. **Image - Model**: Many-to-one (Many images can be generated by one model)

## Best Practices for Using Entities

1. **Immutability**: While entities are mutable, avoid changing their state directly. Use appropriate use cases to modify entities.
2. **Validation**: Always validate entity state before persisting changes.
3. **Relationships**: When working with relationships, ensure that related entities are properly loaded and saved.
4. **Performance**: Be mindful of lazy loading and eager loading when accessing related entities.
5. **Testing**: When testing code that uses entities, consider using mocks or test doubles for related services.

---

*Last updated: January 2026*
