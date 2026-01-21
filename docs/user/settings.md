<<<<<<< HEAD
# Settings

The AVA AIGC Toolbox provides a comprehensive set of settings to customize your experience. This guide covers all the available settings and how to configure them.

## Accessing Settings

#### Steps to Open Settings:
1. Click the **Settings** button in the toolbar, or go to `File > Settings`
2. The settings dialog will appear
3. Use the sidebar to navigate between different settings categories
4. Click **Save** to apply changes, or **Cancel** to discard changes
5. Some settings may require restarting the application to take effect

## General Settings

### Application
- **Language**: Select the application language (English, etc.)
- **Theme**: Choose between light, dark, or system theme
- **Startup Behavior**: Configure what happens when the application starts
  - **Show Welcome Screen**: Display welcome screen on startup
  - **Open Last Library**: Automatically open the last used library
  - **Minimize to Tray**: Start minimized to system tray
- **Update Checks**: Configure automatic update checks
  - **Check for updates automatically**: Enable/disable automatic update checks
  - **Update channel**: Select update channel (stable, beta, nightly)

### Interface
- **Font Size**: Adjust the application font size for better readability
- **Icon Size**: Change the size of icons in the interface
- **Animation**: Toggle animations on or off
- **Tooltips**: Enable/disable tooltips
- **Status Bar**: Show/hide the status bar

## Library Settings

### General
- **Database Location**: Path to the library database file
- **Default Import Folder**: Default folder for importing images
- **Auto-Update Library**: Automatically update the library when files change
- **File Watcher**: Enable/disable file system watching

### Backup
- **Enable automatic backup**: Enable/disable scheduled backups
- **Backup Frequency**: How often to backup (daily, weekly, monthly)
- **Backup Time**: Time of day to perform backups
- **Backup Type**: Database only or complete backup
- **Destination Folder**: Where to store backups
- **Keep Backups For**: How long to keep old backups
- **Maximum Backup Count**: Maximum number of backups to keep

### Performance
- **Thumbnail Cache Size**: Maximum size of thumbnail cache in MB
- **Image Cache Size**: Maximum size of image cache in MB
- **Parallel Processing**: Number of parallel processes for tasks
- **Lazy Loading**: Enable/disable lazy loading of images

## Import Settings

### General
- **Include Subfolders**: Include subfolders when importing by default
- **Extract Metadata**: Extract metadata from images by default
- **Generate Thumbnails**: Generate thumbnails during import by default
- **Overwrite Existing**: Overwrite existing images by default

### File Handling
- **Skip Corrupted Files**: Skip corrupted files during import
- **Skip Duplicate Files**: Skip files with the same path
- **File Name Conflict Resolution**: How to handle file name conflicts
  - **Rename New File**: Rename the new file with a suffix
  - **Overwrite Existing**: Replace the existing file
  - **Skip**: Skip the new file

## Display Settings

### Grid View
- **Default Thumbnail Size**: Default size of thumbnails in grid view
- **Grid Spacing**: Spacing between images in grid view
- **Show File Names**: Show/hide file names under thumbnails
- **Show Rating Stars**: Show/hide rating stars on thumbnails
- **Show Favorite Icon**: Show/hide favorite icon on thumbnails

### List View
- **Default Columns**: Select which columns to show by default in list view
- **Column Widths**: Adjust default widths for columns
- **Row Height**: Set the height of rows in list view

### Details Panel
- **Show Details Panel**: Show/hide the details panel by default
- **Panel Position**: Position of the details panel (left, right, bottom)
- **Expanded Sections**: Which sections to show expanded by default

## Metadata Settings

### Extraction
- **Extract Metadata on Import**: Automatically extract metadata when importing images
- **Metadata Fields**: Select which metadata fields to extract
- **Model Name Mapping**: Map model hashes to human-readable names
- **Auto-Detect Model**: Automatically detect model names from metadata

### Display
- **Show Full Prompt**: Show full prompt or truncated prompt in details panel
- **Format Dates**: Select date format (short, long, custom)
- **Format Numbers**: Select number formatting options

### Editing
- **Allow Metadata Editing**: Enable/disable metadata editing
- **Validate Metadata**: Validate metadata before saving
- **Backup Original Metadata**: Backup original metadata before editing

## AI Settings

### General
- **Enable AI Features**: Toggle AI features on or off
- **Default AI Model**: Set the default AI model for various tasks
- **Max Parallel Requests**: Number of parallel AI requests
- **Cache AI Results**: Cache AI results for faster processing

### Tag Models
- **Default Tag Model**: Set the default model for auto-tagging
- **Tag Confidence Threshold**: Default confidence level for generated tags
- **Tag Language**: Default language for generated tags

### API Integration
- **API Key**: Your API key for AI services
- **API URL**: API endpoint URL
- **Rate Limit**: Maximum number of requests per minute
- **Timeout**: API request timeout in seconds

## Search Settings

### General
- **Default Search Scope**: Default scope for searches (all images, current folder, etc.)
- **Search History Size**: Number of recent searches to keep
- **Auto-Complete**: Enable/disable search auto-complete
- **Wildcards Enabled**: Enable/disable wildcards in search

### Advanced
- **Search Indexing**: Configure search indexing behavior
  - **Index on Import**: Index images when importing
  - **Index in Background**: Index images in the background
  - **Index Frequency**: How often to update search index

## Export Settings

### Defaults
- **Default Export Format**: Default format for exporting images
- **Default Export Quality**: Default quality for export
- **Default Resize Options**: Default resize settings
- **Include Metadata**: Include metadata in exports by default

### Presets
- **Manage Export Presets**: Create, edit, and delete export presets
- **Default Export Preset**: Set the default export preset

## Keyboard Shortcuts

### Customization
- **Enable Keyboard Shortcuts**: Enable/disable keyboard shortcuts
- **Customize Shortcuts**: Modify existing keyboard shortcuts
- **Reset to Defaults**: Restore default keyboard shortcuts

## Troubleshooting Settings

### Logging
- **Log Level**: Set the verbosity of logs (debug, info, warning, error)
- **Log File Location**: Path to log files
- **Max Log File Size**: Maximum size of log files in MB
- **Keep Log Files For**: How long to keep log files

### Debug
- **Enable Debug Mode**: Enable debug mode for troubleshooting
- **Show Debug Information**: Display debug information in the interface
- **Generate Debug Reports**: Create debug reports for support

## Resetting Settings

### Reset to Defaults
1. Go to `Settings > Advanced > Reset Settings`
2. Click **Reset to Defaults**
3. Confirm the reset in the dialog
4. The application will restart with default settings

### Reset Specific Settings
1. Go to the settings category you want to reset
2. Click the **Reset to Defaults** button at the bottom of the page
3. Confirm the reset in the dialog
4. Click **Save** to apply changes

## Importing/Exporting Settings

### Export Settings
1. Go to `Settings > Advanced > Import/Export Settings`
2. Click **Export Settings**
3. Choose a location to save the settings file
4. Click **Save** to export settings

### Import Settings
1. Go to `Settings > Advanced > Import/Export Settings`
2. Click **Import Settings**
3. Select the settings file from your filesystem
4. Click **Open** to import settings
5. Restart the application to apply imported settings

## Best Practices for Settings

1. **Start with Defaults**: Begin with default settings and adjust as needed
2. **Backup Settings**: Export your settings after making significant changes
3. **Test Changes**: Test settings changes before relying on them
4. **Restart When Prompted**: Always restart the application when prompted for settings changes
5. **Document Custom Settings**: Keep a record of custom settings you've made
6. **Use Presets**: Save frequently used configurations as presets
7. **Optimize Performance**: Adjust performance settings based on your system
8. **Reset if Problems Occur**: If you encounter issues, try resetting to default settings

## Troubleshooting Settings Issues

### Settings Not Saving
- **Check Permissions**: Ensure you have write access to the settings file location
- **Check Disk Space**: Ensure there's enough disk space for settings
- **Close Other Instances**: Ensure no other instances of the application are running
- **Reset Settings**: Try resetting settings to default

### Application Not Starting After Settings Change
- **Reset Settings Manually**: Delete the settings file to reset to defaults
  - Windows: `%APPDATA%/AIGenManager/settings.json`
  - macOS: `~/.local/share/AIGenManager/settings.json`
  - Linux: `~/.local/share/AIGenManager/settings.json`
- **Reinstall Application**: If manual reset doesn't work, reinstall the application

### Performance Issues
- **Adjust Cache Settings**: Increase cache sizes for better performance
- **Reduce Parallel Processing**: Decrease the number of parallel processes
- **Disable Animation**: Turn off animations for faster performance
- **Enable Lazy Loading**: Enable lazy loading to reduce initial load time

## Next Steps

- Learn about [Keyboard Shortcuts](./keyboard-shortcuts.md) for quick access to common commands
- Read about [Troubleshooting](.\/support\/troubleshooting\.md) for help with common issues
- Explore [FAQ](.\/support\/faq\.md) for answers to frequently asked questions
=======
# Settings\n\n*Placeholder for application settings*
>>>>>>> origin/doc/dev

