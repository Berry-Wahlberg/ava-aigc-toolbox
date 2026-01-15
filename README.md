# Berry AIGC Toolbox

A cross-platform AIGC (AI-Generated Content) image asset management tool built with Avalonia & .NET. Supports AI-powered image organization, tagging, batch processing, format conversion, and AIGC workflow assistant. Runs seamlessly on Windows, macOS and Linux.

## Features

### Core Features
- **Cross-Platform Support**: Runs on Windows, macOS, and Linux
- **AI-Powered Image Management**: Organize and manage AI-generated images with ease
- **Advanced Tagging System**: Create, apply, and manage tags for your images
- **Album Organization**: Group images into custom albums for better organization
- **Folder Navigation**: Browse images by their original folder structure
- **Metadata Extraction**: Automatically extract AI-generated metadata (prompt, negative prompt, steps, sampler, etc.)
- **Batch Processing**: Perform operations on multiple images simultaneously
- **Format Conversion**: Convert between different image formats
- **AIGC Workflow Assistant**: Streamline your AI content creation workflow

### AI Capabilities
- **Auto-Tagging**: AI-powered automatic tagging for your images
- **Metadata Recognition**: Smart extraction of AI generation parameters
- **Prompt Analysis**: Understand and categorize image prompts
- **Workflow Integration**: Seamlessly integrate with your AI generation tools

### User Experience
- **Intuitive Interface**: Clean and user-friendly design
- **Keyboard Shortcuts**: Efficient navigation with keyboard shortcuts
- **Drag and Drop Support**: Easy image importing and organization
- **Multiple View Modes**: Grid and list views for different preferences
- **Advanced Search and Filtering**: Find images quickly with powerful search capabilities

## Installation

### System Requirements

#### Minimum Requirements
- **Operating System**: Windows 10+, macOS 10.15+, or Linux (Ubuntu 20.04+, Fedora 32+)
- **.NET Runtime**: .NET 7.0 or later
- **Disk Space**: 100 MB of free space
- **RAM**: 2 GB minimum

#### Recommended Requirements
- **RAM**: 4 GB or more
- **Processor**: Multi-core CPU
- **Display**: 1080p or higher resolution

### Installation Methods

#### 1. Using Installer (Windows)

1. **Download the Installer**
   - Visit the official website or GitHub releases page
   - Download the latest `.exe` installer for Windows

2. **Run the Installer**
   - Double-click the downloaded `.exe` file
   - Follow the on-screen instructions
   - Choose installation directory (default recommended)
   - Select whether to create desktop and start menu shortcuts

3. **Launch the Application**
   - Click "Finish" to launch the application immediately
   - Or use the desktop/start menu shortcuts later

#### 2. Using Package Manager (macOS/Linux)

##### macOS (Homebrew)
```bash
brew tap berry-aigc-toolbox/tap
brew install ava-aigc-toolbox
```

##### Linux (Snap)
```bash
sudo snap install berry-aigc-toolbox
```

##### Linux (Debian/Ubuntu)
```bash
sudo dpkg -i berry-aigc-toolbox_*.deb
sudo apt-get install -f
```

#### 3. Portable Version (All Platforms)

1. **Download Portable Archive**
   - Download the latest `.zip` (Windows) or `.tar.gz` (macOS/Linux) archive

2. **Extract the Archive**
   - Extract the contents to a directory of your choice
   - No installation required

3. **Run the Application**
   - Windows: Double-click `AIGenManager.exe`
   - macOS/Linux: Run `./AIGenManager` from the terminal

### .NET Runtime Installation

If you don't have the .NET 7.0 runtime installed, you'll need to install it first:

#### Windows
- Download from [https://dotnet.microsoft.com/download/dotnet/7.0](https://dotnet.microsoft.com/download/dotnet/7.0)
- Run the installer and follow instructions

#### macOS
```bash
brew install --cask dotnet-sdk
```

#### Linux
```bash
# Ubuntu/Debian
sudo apt-get update
sudo apt-get install -y dotnet-runtime-7.0

# Fedora
sudo dnf install -y dotnet-runtime-7.0
```

## Usage

### First Launch

When you launch the application for the first time:

1. **Welcome Screen**
   - You'll see a welcome screen with options to:
     - Start with empty library
     - Import existing images
     - Learn more about the application

2. **Choose Your Option**
   - **Start with empty library**: Creates a new database for your images
   - **Import existing images**: Lets you select folders to import images from
   - **Learn more**: Opens the documentation

3. **Database Location**
   - The application automatically creates a database file:
     - Windows: `%APPDATA%/AIGenManager/aigenmanager.db`
     - macOS: `~/.local/share/AIGenManager/aigenmanager.db`
     - Linux: `~/.local/share/AIGenManager/aigenmanager.db`

### Basic Navigation

The main window is divided into several sections:

- **Sidebar**: Navigate through folders, albums, tags, and all images
- **Main Content Area**: Displays images in grid or list view
- **Image Details**: Shows metadata and properties when an image is selected
- **Toolbar**: Access import, sort, filter, and view options
- **Status Bar**: Shows total images, current filter, and application status

### Adding Images

#### From Filesystem
1. Click the **Import** button in the toolbar
2. Select **Import from Folder**
3. Choose the folder containing your images
4. Click **Select Folder** to start importing

#### Drag and Drop
1. Open your file explorer/finder
2. Select one or more images
3. Drag them into the main content area of the application
4. The images will be added to your library

### Organizing Images

#### Creating Albums
1. Click the **+** button next to "Albums" in the sidebar
2. Enter a name for your album
3. Press Enter to create
4. Drag images from the grid into the album to add them

#### Adding Tags

##### To Single Image
1. Select an image in the grid
2. In the details panel, find the "Tags" section
3. Click the **+** button
4. Enter a tag name and press Enter

##### To Multiple Images
1. Select multiple images using Ctrl/Cmd + click
2. Right-click and select **Add Tags**
3. Enter tag names separated by commas
4. Click **Add** to apply tags to all selected images

### Searching and Filtering

#### Basic Search
1. Type in the search box at the top of the window
2. Results will appear automatically as you type
3. Search matches against filenames, tags, and metadata

#### Advanced Filtering
1. Click the **Filter** button in the toolbar
2. Set filter criteria:
   - Folder
   - Album
   - Tags
   - Rating
   - Date range
   - Dimensions
   - AI metadata (model, sampler, etc.)
3. Click **Apply** to see filtered results

### Keyboard Shortcuts

- **Ctrl/Cmd + K**: Show all keyboard shortcuts
- **Ctrl/Cmd + I**: Import images
- **Ctrl/Cmd + F**: Focus search box
- **Ctrl/Cmd + A**: Select all images
- **Delete**: Delete selected images
- **Space**: Preview selected image
- **Ctrl/Cmd + 1**: Grid view
- **Ctrl/Cmd + 2**: List view

## Configuration

### Database Configuration

The application uses SQLite for data storage. The database file is automatically created at:
- Windows: `%APPDATA%/AIGenManager/aigenmanager.db`
- macOS: `~/.local/share/AIGenManager/aigenmanager.db`
- Linux: `~/.local/share/AIGenManager/aigenmanager.db`

To back up your data, simply copy this file to a safe location.

### Application Settings

The application settings are stored in:
- Windows: `%APPDATA%/AIGenManager/settings.json`
- macOS: `~/.local/share/AIGenManager/settings.json`
- Linux: `~/.local/share/AIGenManager/settings.json`

Settings include:
- UI preferences (view mode, theme, etc.)
- Import settings
- Search and filter preferences
- Keyboard shortcuts customization

### Customization

The application supports various customization options:
- **Theme**: Light and dark themes
- **View Options**: Grid size, list columns, etc.
- **Sorting Preferences**: Default sorting order
- **Metadata Display**: Choose which metadata fields to show

## Contributing

### Architecture Overview

The project follows Clean Architecture principles with the following layers:

1. **Presentation**: UI components and view models built with Avalonia
2. **Application**: Use cases implementing business logic
3. **Core**: Domain models, entities, and interfaces
4. **Infrastructure**: Data access and external integrations

### Coding Standards

- Follow C# coding conventions
- Use dependency injection for all dependencies
- Implement interfaces in the Core layer, concretions in Infrastructure
- Use use case pattern for all application logic
- Follow SOLID principles

### Development Setup

1. **Prerequisites**
   - .NET 7.0 SDK or later
   - Visual Studio, Rider, or VS Code with C# extension
   - Git

2. **Clone the Repository**
   ```bash
   git clone https://github.com/berry-aigc-toolbox/berry-aigc-toolbox.git
   cd berry-aigc-toolbox
   ```

3. **Build the Project**
   ```bash
   dotnet build
   ```

4. **Run the Application**
   ```bash
   dotnet run --project src/Presentation/AIGenManager.Presentation.csproj
   ```

### Contribution Workflow

1. Fork the repository
2. Create a feature branch
3. Implement your changes
4. Run tests (if available)
5. Commit your changes with descriptive commit messages
6. Push to your fork
7. Create a pull request

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

## Acknowledgments

- **Avalonia UI**: Cross-platform UI framework
- **.NET**: Powerful development platform
- **SQLite**: Lightweight database engine
- **SQLite-net**: SQLite ORM for .NET

## Contact

- **GitHub Repository**: [https://github.com/berry-aigc-toolbox/berry-aigc-toolbox](https://github.com/berry-aigc-toolbox/berry-aigc-toolbox)
- **Issues**: [https://github.com/berry-aigc-toolbox/berry-aigc-toolbox/issues](https://github.com/berry-aigc-toolbox/berry-aigc-toolbox/issues)
- **Documentation**: [https://github.com/berry-aigc-toolbox/berry-aigc-toolbox/docs](https://github.com/berry-aigc-toolbox/berry-aigc-toolbox/docs)

## Support

For support, please:
1. Check the [documentation](https://github.com/berry-aigc-toolbox/berry-aigc-toolbox/docs)
2. Search for existing [issues](https://github.com/berry-aigc-toolbox/berry-aigc-toolbox/issues)
3. Create a new issue if you can't find a solution

## Changelog

For the latest changes, see the [CHANGELOG](CHANGELOG.md) file.
