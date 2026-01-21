# System Requirements

This document outlines the system requirements for developing, running, and deploying the AVA AIGC Toolbox application.

## Development Requirements

### Operating Systems

The AVA AIGC Toolbox can be developed on the following operating systems:

- **Windows**: Windows 10 version 1809 or later, Windows 11
- **macOS**: macOS 10.15 (Catalina) or later
- **Linux**: Ubuntu 20.04 LTS or later, Fedora 36 or later, or other modern Linux distributions

### Hardware Requirements

| Component | Minimum | Recommended |
|-----------|---------|-------------|
| CPU | 2-core processor | 4-core processor or better |
| RAM | 4 GB | 8 GB or more |
| Storage | 1 GB free space | 5 GB free space for development tools and dependencies |
| Display | 1024x768 resolution | 1920x1080 resolution or higher |

### Software Requirements

| Software | Version | Purpose |
|----------|---------|---------|
| .NET SDK | 7.0 or later | Development framework |
| Git | 2.0 or later | Version control |
| IDE | Visual Studio 2022, Visual Studio Code, or Rider | Development environment |
| Avalonia Extension | Latest | Avalonia UI development support |
| C# Extension | Latest | C# language support |

### IDE-Specific Requirements

#### Visual Studio 2022
- Community, Professional, or Enterprise edition
- .NET Desktop Development workload
- Avalonia for Visual Studio extension

#### Visual Studio Code
- C# Dev Kit extension
- Avalonia for VS Code extension
- .NET Install Tool for Extension Authors

#### JetBrains Rider
- Rider 2022.2 or later
- Avalonia plugin for Rider

## Runtime Requirements

### Operating Systems

The AVA AIGC Toolbox can be run on the following operating systems:

- **Windows**: Windows 10 version 1809 or later, Windows 11
- **macOS**: macOS 10.15 (Catalina) or later
- **Linux**: Ubuntu 20.04 LTS or later, Fedora 36 or later, or other modern Linux distributions

### Hardware Requirements

| Component | Minimum | Recommended |
|-----------|---------|-------------|
| CPU | 1-core processor | 2-core processor or better |
| RAM | 2 GB | 4 GB or more |
| Storage | 500 MB free space | 1 GB free space for application and database |
| Display | 1024x768 resolution | 1920x1080 resolution or higher |

### Software Requirements

- **.NET Runtime**: 7.0 or later (automatically installed with the application on Windows)
- **libgtk-3-0**: For Linux systems (install via package manager)
- **libx11-6**: For Linux systems (install via package manager)

## Database Requirements

- **SQLite**: The application uses SQLite 3.0+ for data storage
- Database file size depends on the number of images and metadata stored
- Default location varies by operating system:
  - Windows: `%APPDATA%/AIGenManager/aigenmanager.db`
  - macOS: `~/.local/share/AIGenManager/aigenmanager.db`
  - Linux: `~/.local/share/AIGenManager/aigenmanager.db`

## Network Requirements

### Development

- Internet connection required for:
  - Installing dependencies
  - Updating packages
  - Accessing documentation
  - Optional: Git remote operations

### Runtime

- **Offline**: The application can run fully offline
- **Optional internet features**:
  - AI-powered features (if implemented)
  - Check for updates
  - Access to online documentation

## Supported Image Formats

The AVA AIGC Toolbox supports the following image formats:

- JPEG/JPG
- PNG
- WebP
- BMP
- TIFF
- GIF (static)

## Performance Considerations

- Large image collections may require more RAM and storage
- SSD storage is recommended for faster database operations
- The application uses caching to improve performance with large image collections
- Performance may vary depending on the operating system and hardware configuration

## Accessibility Requirements

- The application follows Avalonia's accessibility guidelines
- Screen reader support is available on all platforms
- Keyboard navigation is fully supported

---

*Last updated: January 2026*
