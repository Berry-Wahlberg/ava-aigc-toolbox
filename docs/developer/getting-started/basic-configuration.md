# Basic Configuration

This guide covers the basic configuration options for the AVA AIGC Toolbox application.

## Configuration Files

The application uses the following configuration files:

### appsettings.json

The main configuration file, located in the `AIGenManager.Presentation` project directory. This file contains:

- Database connection settings
- Application settings
- Logging configuration

### User Preferences

User-specific settings are stored in a separate configuration file:

- **Windows**: `%APPDATA%/AIGenManager/settings.json`
- **macOS**: `~/.local/share/AIGenManager/settings.json`
- **Linux**: `~/.local/share/AIGenManager/settings.json`

## Database Configuration

### Default Database Location

By default, the application stores its database in the following location:

- **Windows**: `%APPDATA%/AIGenManager/aigenmanager.db`
- **macOS**: `~/.local/share/AIGenManager/aigenmanager.db`
- **Linux**: `~/.local/share/AIGenManager/aigenmanager.db`

### Changing Database Location

To change the database location:

1. Open the `appsettings.json` file in the `AIGenManager.Presentation` project
2. Locate the `ConnectionStrings` section
3. Update the `DefaultConnection` value with the new path:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Data Source=C:\\Path\\To\\New\\Database\\aigenmanager.db"
  }
}
```

**Note**: For production builds, you'll need to recompile the application after making this change.

## Application Settings

### Theme Configuration

The application supports both light and dark themes.

#### Setting Theme via UI

1. Open the application
2. Click on the "Settings" menu
3. Select "Appearance"
4. Choose between "Light", "Dark", or "System Default"
5. The theme will change immediately

#### Setting Theme via Configuration File

1. Open the user preferences file
2. Add or modify the `Theme` setting:

```json
{
  "Theme": "Dark" // Options: Light, Dark, System
}
```

### Image Preview Settings

#### Preview Quality

1. Open the application
2. Click on the "Settings" menu
3. Select "Images"
4. Adjust the "Preview Quality" slider
   - Lower quality = faster performance
   - Higher quality = better visual appearance

#### Thumbnail Size

1. Open the application
2. Click on the "Settings" menu
3. Select "Images"
4. Adjust the "Thumbnail Size" slider
5. Click "Apply" to see the changes

### Logging Configuration

#### Log Level

To change the logging level:

1. Open the `appsettings.json` file
2. Locate the `Logging` section
3. Update the log level for different categories:

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning",
      "AIGenManager": "Debug"
    }
  }
}
```

Available log levels (in order of verbosity):
- Trace
- Debug
- Information
- Warning
- Error
- Critical

#### Log File Location

Log files are stored in:

- **Windows**: `%APPDATA%/AIGenManager/logs/`
- **macOS**: `~/.local/share/AIGenManager/logs/`
- **Linux**: `~/.local/share/AIGenManager/logs/`

## Keyboard Shortcuts

### Default Shortcuts

| Shortcut | Action |
|----------|--------|
| `Ctrl+O` | Open file/folder |
| `Ctrl+I` | Import images |
| `Ctrl+S` | Save changes |
| `Ctrl+F` | Search |
| `Ctrl+A` | Select all |
| `Ctrl+D` | Duplicate |
| `Delete` | Delete selected items |
| `Ctrl+Z` | Undo |
| `Ctrl+Y` | Redo |
| `F5` | Refresh |
| `F11` | Toggle full-screen |
| `Ctrl+K` | Show keyboard shortcuts |

### Customizing Shortcuts

1. Open the application
2. Click on the "Settings" menu
3. Select "Keyboard Shortcuts"
4. Click on the shortcut you want to change
5. Press the new key combination
6. Click "Save" to apply changes

## Performance Settings

### Cache Size

To adjust the image cache size:

1. Open the application
2. Click on the "Settings" menu
3. Select "Performance"
4. Adjust the "Image Cache Size" slider
5. Click "Apply"

### Background Processing

1. Open the application
2. Click on the "Settings" menu
3. Select "Performance"
4. Toggle "Enable Background Processing"
   - Enabled: Allows the application to process images in the background
   - Disabled: Processes images only when actively requested

## Default Folder Settings

### Default Import Folder

1. Open the application
2. Click on the "Settings" menu
3. Select "Folders"
4. Click "Browse" next to "Default Import Folder"
5. Select the desired folder
6. Click "Save"

### Default Export Folder

1. Open the application
2. Click on the "Settings" menu
3. Select "Folders"
4. Click "Browse" next to "Default Export Folder"
5. Select the desired folder
6. Click "Save"

## Resetting Settings

### Reset to Defaults

1. Open the application
2. Click on the "Settings" menu
3. Select "Advanced"
4. Click "Reset to Default Settings"
5. Confirm the action
6. Restart the application for changes to take effect

### Resetting Specific Settings

To reset specific settings, you can manually edit or delete the user preferences file:

1. Locate the user preferences file (see [User Preferences](#user-preferences))
2. Open it with a text editor
3. Remove the specific setting you want to reset, or delete the entire file to reset all settings
4. Restart the application

## Advanced Configuration

### Command Line Arguments

The application supports the following command line arguments:

| Argument | Description |
|----------|-------------|
| `--debug` | Enable debug logging |
| `--database <path>` | Specify a custom database location |
| `--import <path>` | Import images from the specified path on startup |
| `--theme <LightDarkSystem>` | Set the application theme |
| `--version` | Show application version |
| `--help` | Show help information |

Example:
```bash
dotnet run --project src/Presentation/AIGenManager.Presentation.csproj -- --debug --theme Dark
```

### Environment Variables

| Variable | Description |
|----------|-------------|
| `AIGENMANAGER_DATABASE` | Override the default database location |
| `AIGENMANAGER_LOG_LEVEL` | Set the log level |
| `AIGENMANAGER_THEME` | Set the application theme |

## Configuration for Developers

### Adding New Configuration Options

1. Define the setting in the appropriate configuration class
2. Update the `appsettings.json` template
3. Add UI controls to allow users to modify the setting
4. Implement the logic to read and apply the setting
5. Add documentation for the new setting

### Configuration Class Structure

Configuration settings are typically defined in classes that inherit from `IOptions<TOptions>` or `IOptionsSnapshot<TOptions>`. This allows for strongly-typed access to configuration values.

Example:

```csharp
public class ImageSettings
{
    public int ThumbnailSize { get; set; } = 200;
    public int PreviewQuality { get; set; } = 80;
    public int CacheSize { get; set; } = 500;
}
```

To register this configuration class:

```csharp
// In Program.cs or App.axaml.cs
services.Configure<ImageSettings>(Configuration.GetSection("ImageSettings"));
```

To use it in a class:

```csharp
public class ImageService
{
    private readonly ImageSettings _settings;
    
    public ImageService(IOptions<ImageSettings> settings)
    {
        _settings = settings.Value;
    }
    
    // Use _settings.ThumbnailSize, etc.
}
```

## Best Practices

1. **Backup Configuration Files**: Always backup your configuration files before making changes
2. **Use Version Control**: Keep configuration templates in version control, but exclude user-specific settings
3. **Document Changes**: Document any configuration changes you make
4. **Test Changes**: Test configuration changes in a development environment before deploying to production
5. **Use Environment-Specific Configuration**: For multi-environment setups, use environment-specific configuration files (e.g., `appsettings.Development.json`, `appsettings.Production.json`)

## Troubleshooting Configuration Issues

1. **Settings Not Saving**: Ensure the application has write access to the settings directory
2. **Changes Not Taking Effect**: Try restarting the application
3. **Corrupted Configuration**: Delete the user preferences file and restart the application to reset to defaults
4. **Invalid Configuration Values**: Check the configuration files for syntax errors
5. **Log Errors**: Check the application logs for configuration-related errors

---

*Last updated: January 2026*
