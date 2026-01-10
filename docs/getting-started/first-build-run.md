# First Build and Run

This guide will walk you through building and running the AVA AIGC Toolbox for the first time.

## Prerequisites

Before you begin, ensure you have:

- Completed the [Development Environment Setup](./development-setup.md)
- Cloned the repository
- Restored dependencies using `dotnet restore`

## Building the Project

### Using .NET CLI

1. Open a terminal or command prompt
2. Navigate to the project root directory
3. Run the build command:
   ```bash
   dotnet build
   ```
4. Wait for the build to complete
5. If successful, you'll see a message like:
   ```
   Build succeeded.
   0 Warning(s)
   0 Error(s)
   ```

### Building in Visual Studio 2022

1. Open the solution file `AIGenManager.sln`
2. Select the desired build configuration (Debug or Release) from the toolbar
3. Click the "Build" menu and select "Build Solution", or press `Ctrl+Shift+B`
4. Monitor the build progress in the Output window
5. If successful, you'll see "Build succeeded" in the Output window

### Building in Visual Studio Code

1. Open the project folder in VS Code
2. Open the Command Palette (Ctrl+Shift+P)
3. Type "Build" and select "Tasks: Run Build Task"
4. Select the appropriate build task (usually "build")
5. Monitor the build progress in the Terminal window

### Building in JetBrains Rider

1. Open the solution file `AIGenManager.sln`
2. Select the desired build configuration (Debug or Release) from the toolbar
3. Click the "Build" menu and select "Build Solution", or press `Ctrl+F9`
4. Monitor the build progress in the status bar

## Running the Application

### Using .NET CLI

1. In the project root directory, run:
   ```bash
   dotnet run --project src/Presentation/AIGenManager.Presentation.csproj
   ```
2. The application will start and display its main window

### Running in Visual Studio 2022

1. Ensure `AIGenManager.Presentation` is set as the startup project
2. Click the "Start Debugging" button (green arrow) in the toolbar, or press `F5`
3. The application will start in debug mode
4. To run without debugging, click "Start Without Debugging" or press `Ctrl+F5`

### Running in Visual Studio Code

1. Open the Run and Debug view (Ctrl+Shift+D)
2. Select the appropriate debug configuration from the dropdown (usually ".NET Core Launch (console)")
3. Click the "Start Debugging" button (green arrow), or press `F5`
4. To run without debugging, open the Command Palette and select "Run Without Debugging"

### Running in JetBrains Rider

1. Ensure `AIGenManager.Presentation` is set as the startup project
2. Click the "Run" button (green arrow) in the toolbar, or press `Shift+F10`
3. The application will start
4. To run in debug mode, click the "Debug" button (bug icon), or press `F5`

## First Launch Experience

When you run the application for the first time:

1. **Welcome Screen**: You'll be greeted with a welcome screen offering options to:
   - Start with an empty library
   - Import existing images
   - Learn more about the application

2. **Database Initialization**: The application will automatically create a SQLite database file in the appropriate location for your operating system:
   - Windows: `%APPDATA%/AIGenManager/aigenmanager.db`
   - macOS: `~/.local/share/AIGenManager/aigenmanager.db`
   - Linux: `~/.local/share/AIGenManager/aigenmanager.db`

3. **Main Window**: After selecting an option, you'll be taken to the main application window, which consists of:
   - Sidebar: For navigating folders, albums, and tags
   - Main content area: Displays images in a grid layout
   - Toolbar: Contains various actions and filters
   - Status bar: Shows application status and statistics

## Verifying the Application

To ensure the application is working correctly:

1. **Check the UI**: Verify that all UI elements are displayed properly
2. **Test Basic Functionality**:
   - Try creating a new album
   - Import a sample image
   - Add a tag to an image
   - Search for an image
3. **Check Logs**: If you encounter any issues, check the application logs:
   - Windows: `%APPDATA%/AIGenManager/logs/`
   - macOS: `~/.local/share/AIGenManager/logs/`
   - Linux: `~/.local/share/AIGenManager/logs/`

## Running Tests

### Unit Tests

1. To run all unit tests:
   ```bash
   dotnet test
   ```
2. To run tests for a specific project:
   ```bash
   dotnet test src/Core/AIGenManager.Core.csproj
   ```

### Running Tests in IDEs

- **Visual Studio 2022**: Use the Test Explorer window (`Ctrl+E, T`)
- **Visual Studio Code**: Use the Test Explorer extension or run via Command Palette
- **Rider**: Use the Unit Tests window (`Ctrl+Alt+U`)

## Common Issues and Solutions

### Build Errors

1. **Missing Dependencies**:
   - Solution: Run `dotnet restore` again

2. **Incorrect .NET SDK Version**:
   - Solution: Ensure you have .NET SDK 7.0 or later installed
   - Verify with: `dotnet --version`

3. **Platform-Specific Issues**:
   - **Linux**: Ensure you have installed required system dependencies
     ```bash
     # Ubuntu/Debian
     sudo apt-get install -y libgtk-3-0 libx11-6
     ```

### Runtime Errors

1. **Application Fails to Start**:
   - Solution: Check the logs for detailed error messages
   - Ensure all dependencies are installed

2. **Database Connection Issues**:
   - Solution: Verify the database file has the correct permissions
   - Ensure the application has write access to the database directory

3. **UI Rendering Issues**:
   - Solution: Ensure you're using the latest Avalonia version
   - Try updating the Avalonia NuGet packages

## Next Steps

Now that you've successfully built and run the application, you can:

1. [Configure the application](./basic-configuration.md)
2. Explore the [architecture documentation](../architecture/clean-architecture.md)
3. Review the [coding standards](../development-workflow/coding-standards.md)
4. Start developing new features

## Useful Commands Summary

| Command | Description |
|---------|-------------|
| `dotnet restore` | Restore project dependencies |
| `dotnet build` | Build the solution |
| `dotnet run --project src/Presentation/AIGenManager.Presentation.csproj` | Run the application |
| `dotnet test` | Run all tests |
| `dotnet build --configuration Release` | Build in Release mode |
| `dotnet run --project src/Presentation/AIGenManager.Presentation.csproj --configuration Release` | Run in Release mode |

---

*Last updated: January 2026*
