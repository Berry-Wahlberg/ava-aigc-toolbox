# Installation Guide
\n> **Die englische Version gilt als maßgebend**\n\n
## Overview
This guide will walk you through the process of installing the AVA AIGC Toolbox on your system. The application supports Windows, macOS, and Linux.

## System Requirements

### Minimum Requirements
- **Operating System**: Windows 10+, macOS 10.15+, or Linux (Ubuntu 20.04+, Fedora 32+)
- **.NET Runtime**: .NET 7.0 or later
- **Disk Space**: 100 MB of free space
- **RAM**: 2 GB minimum

### Recommended Requirements
- **RAM**: 4 GB or more
- **Processor**: Multi-core CPU
- **Display**: 1080p or higher resolution

## Installation Methods

### 1. Using Installer (Windows)

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

### 2. Using Package Manager (macOS/Linux)

#### macOS (Homebrew)
```bash
brew tap ava-aigc-toolbox/tap
brew install ava-aigc-toolbox
```

#### Linux (Snap)
```bash
sudo snap install ava-aigc-toolbox
```

#### Linux (Debian/Ubuntu)
```bash
sudo dpkg -i ava-aigc-toolbox_*.deb
sudo apt-get install -f
```

### 3. Portable Version (All Platforms)

1. **Download Portable Archive**
   - Download the latest `.zip` (Windows) or `.tar.gz` (macOS/Linux) archive

2. **Extract the Archive**
   - Extract the contents to a directory of your choice
   - No installation required

3. **Run the Application**
   - Windows: Double-click `AIGenManager.exe`
   - macOS/Linux: Run `./AIGenManager` from the terminal

## .NET Runtime Installation

If you don't have the .NET 7.0 runtime installed, you'll need to install it first:

### Windows
- Download from https://dotnet.microsoft.com/download/dotnet/7.0
- Run the installer and follow instructions

### macOS
```bash
brew install --cask dotnet-sdk
```

### Linux
```bash
# Ubuntu/Debian
sudo apt-get update
sudo apt-get install -y dotnet-runtime-7.0

# Fedora
sudo dnf install -y dotnet-runtime-7.0
```

## Verifying Installation

1. **Launch the Application**
2. **Check Version**
   - Go to `Help` > `About`
   - Verify the version matches the one you downloaded

3. **Test Basic Functionality**
   - The application should launch without errors
   - The main window should display correctly
   - You should be able to navigate through the interface

## Troubleshooting

### Application Won't Launch
- **Check .NET Runtime**: Ensure you have the correct .NET runtime installed
- **Check System Requirements**: Verify your system meets the minimum requirements
- **Run as Administrator**: Try running the application with administrative privileges
- **Check Logs**: Look for log files in `%APPDATA%/AIGenManager/` (Windows) or `~/.local/share/AIGenManager/` (macOS/Linux)

### Installation Errors
- **Windows Installer**: Ensure you have write permissions to the installation directory
- **Package Manager**: Check your internet connection and try again
- **Portable Version**: Ensure you've extracted all files correctly

### Performance Issues
- **Close Other Applications**: Free up system resources
- **Increase RAM**: Consider upgrading your system RAM
- **Lower Display Resolution**: Adjust your display settings

## Uninstallation

### Windows (Installer)
1. Go to `Control Panel` > `Programs` > `Programs and Features`
2. Select "AVA AIGC Toolbox" from the list
3. Click "Uninstall" and follow instructions

### macOS (Homebrew)
```bash
brew uninstall ava-aigc-toolbox
```

### Linux (Snap)
```bash
sudo snap remove ava-aigc-toolbox
```

### Portable Version
- Simply delete the extracted directory
- Optionally delete the application data folder:
  - Windows: `%APPDATA%/AIGenManager/`
  - macOS: `~/.local/share/AIGenManager/`
  - Linux: `~/.local/share/AIGenManager/`

## Next Steps

- [Getting Started Guide](./getting-started.md)
- [Features Overview](./features.md)
- [User Interface Guide](./ui-guide.md)

If you encounter any issues during installation, please check the [FAQ](./faq.md) or report them on the GitHub issues page.