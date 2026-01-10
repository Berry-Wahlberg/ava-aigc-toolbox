# Development Environment Setup

This guide will walk you through setting up your development environment for the AVA AIGC Toolbox project.

## Prerequisites

Before you begin, ensure you have the following installed:

- **.NET SDK 7.0 or later**
- **Git 2.0 or later**
- **An IDE** (Visual Studio 2022, Visual Studio Code, or Rider)

## Step 1: Install .NET SDK

### Windows

1. Download the .NET SDK installer from the [official .NET website](https://dotnet.microsoft.com/download)
2. Run the installer and follow the on-screen instructions
3. Verify installation by opening a command prompt and running:
   ```bash
   dotnet --version
   ```

### macOS

1. Using Homebrew (recommended):
   ```bash
   brew install dotnet-sdk
   ```
2. Or download the installer from the [official .NET website](https://dotnet.microsoft.com/download)
3. Verify installation:
   ```bash
   dotnet --version
   ```

### Linux

#### Ubuntu/Debian

1. Add the Microsoft package repository:
   ```bash
   wget https://packages.microsoft.com/config/ubuntu/$(lsb_release -rs)/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
   sudo dpkg -i packages-microsoft-prod.deb
   rm packages-microsoft-prod.deb
   ```

2. Install the .NET SDK:
   ```bash
   sudo apt-get update && sudo apt-get install -y dotnet-sdk-7.0
   ```

#### Fedora

1. Install the .NET SDK:
   ```bash
   sudo dnf install dotnet-sdk-7.0
   ```

3. Verify installation on any Linux distribution:
   ```bash
   dotnet --version
   ```

## Step 2: Install Git

### Windows

1. Download Git from the [official Git website](https://git-scm.com/download/win)
2. Run the installer, accepting the default options for most settings
3. Verify installation:
   ```bash
   git --version
   ```

### macOS

1. Using Homebrew (recommended):
   ```bash
   brew install git
   ```
2. Or use the pre-installed Git (may be outdated):
   ```bash
   git --version
   ```
3. To update pre-installed Git:
   ```bash
   brew install git
   ```

### Linux

#### Ubuntu/Debian

```bash
sudo apt-get update && sudo apt-get install -y git
```

#### Fedora

```bash
sudo dnf install git
```

3. Verify installation on any Linux distribution:
   ```bash
   git --version
   ```

## Step 3: Install an IDE

Choose one of the following IDEs for development:

### Option 1: Visual Studio 2022 (Windows only)

1. Download Visual Studio 2022 from the [official Visual Studio website](https://visualstudio.microsoft.com/downloads/)
2. Run the installer and select the **.NET Desktop Development** workload
3. During installation, select the **Avalonia for Visual Studio** extension from the Individual Components tab, or install it later from the Visual Studio Marketplace
4. Launch Visual Studio 2022

### Option 2: Visual Studio Code (Cross-platform)

1. Download VS Code from the [official VS Code website](https://code.visualstudio.com/)
2. Install the following extensions:
   - [C# Dev Kit](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csdevkit)
   - [Avalonia for VS Code](https://marketplace.visualstudio.com/items?itemName=AvaloniaTeam.vscode-avalonia)
   - [.NET Install Tool for Extension Authors](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.dotnet-install-tools)
3. Launch VS Code

### Option 3: JetBrains Rider (Cross-platform)

1. Download Rider from the [official Rider website](https://www.jetbrains.com/rider/)
2. Install Rider following the on-screen instructions
3. Install the [Avalonia plugin for Rider](https://plugins.jetbrains.com/plugin/14839-avalonia)
4. Launch Rider

## Step 4: Clone the Repository

1. Open a terminal or command prompt
2. Navigate to the directory where you want to clone the project
3. Run the following command to clone the repository:
   ```bash
   git clone https://github.com/your-organization/ava-aigc-toolbox.git
   ```
4. Navigate into the project directory:
   ```bash
   cd ava-aigc-toolbox
   ```

## Step 5: Restore Dependencies

1. In the project directory, run:
   ```bash
   dotnet restore
   ```
2. This will download and install all required dependencies for the project

## Step 6: Verify the Setup

1. Build the project to ensure everything is working correctly:
   ```bash
   dotnet build
   ```
2. If the build succeeds, you'll see a message like:
   ```
   Build succeeded.
   0 Warning(s)
   0 Error(s)
   ```

## Step 7: Configure Your IDE

### Visual Studio 2022

1. Open the solution file `AIGenManager.sln`
2. Set `AIGenManager.Presentation` as the startup project by right-clicking it in the Solution Explorer and selecting "Set as Startup Project"
3. The IDE should automatically detect the .NET SDK and configure the project

### Visual Studio Code

1. Open the project folder in VS Code
2. The C# Dev Kit extension should automatically detect the project structure
3. You may be prompted to select the solution file - choose `AIGenManager.sln`
4. To run the project, open the Command Palette (Ctrl+Shift+P) and select "Run and Debug"

### JetBrains Rider

1. Open the solution file `AIGenManager.sln`
2. Rider should automatically configure the project
3. Set `AIGenManager.Presentation` as the startup project by right-clicking it in the Solution Explorer and selecting "Run 'AIGenManager.Presentation'"

## Step 8: Install Additional Tools (Optional)

### SQLite Browser

For viewing and editing the SQLite database:

- Download [DB Browser for SQLite](https://sqlitebrowser.org/dl/)

### Avalonia UI Designer

- Visual Studio: Included with the Avalonia extension
- VS Code: Use the Avalonia Preview extension
- Rider: Included with the Avalonia plugin

### Code Analysis Tools

- **dotnet-format**: For code formatting
  ```bash
  dotnet tool install -g dotnet-format
  ```

- **SonarLint**: For static code analysis (available as an extension for all major IDEs)

## Troubleshooting

### Common Issues

1. **.NET SDK not found**: Ensure you've installed the correct version of the .NET SDK and it's in your PATH
2. **Missing dependencies**: Run `dotnet restore` again to ensure all dependencies are installed
3. **Build errors**: Check the error messages carefully and ensure you're using the correct .NET SDK version
4. **IDE configuration issues**: Try restarting your IDE or reloading the project

### Getting Help

- Check the [Troubleshooting](../troubleshooting/common-issues.md) section of the documentation
- Search the project's issue tracker for similar problems
- Ask for help in the project's discussion forums or Discord server

## Next Steps

Now that your development environment is set up, you can:

- [Build and run the project](./first-build-run.md)
- Explore the [project architecture](../architecture/clean-architecture.md)
- Review the [coding standards](../development-workflow/coding-standards.md)

---

*Last updated: January 2026*
