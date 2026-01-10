# UI Overview
\n> **La versión en inglés es la válida**\n\n
The AVA AIGC Toolbox features an intuitive, well-organized user interface designed to help you manage your AI-generated images efficiently. This guide provides a detailed explanation of all the main interface components.

## Main Window Layout

The application window is divided into four main sections:

1. **Menu Bar** - Top-level navigation and application commands
2. **Sidebar** - Quick access to different views and filters
3. **Toolbar** - Common actions and settings
4. **Main Content Area** - Image display and details
5. **Status Bar** - Application status and information

```
┌─────────────────────────────────────────────────────────────────�?�?                       Menu Bar                                 �?├─────────────────────────────────────────────────────────────────�?�?                       Toolbar                                  �?├───────────────┬─────────────────────────────────────────────────�?�?              �?                                                �?�?  Sidebar     �?             Main Content Area                  �?�?              �?                                                �?├───────────────┴─────────────────────────────────────────────────�?�?                       Status Bar                               �?└─────────────────────────────────────────────────────────────────�?```

## 1. Menu Bar

The menu bar contains application-wide commands and settings, organized into the following menus:

### File Menu
- **New Library**: Create a new empty image library
- **Open Library**: Open an existing library database
- **Import**: 
  - **Import Images**: Import images from folders
  - **Import Metadata**: Import metadata from files
- **Export**: 
  - **Export Selected Images**: Export selected images to a folder
  - **Export All Images**: Export all images in the current view
- **Settings**: Open application settings
- **Exit**: Close the application

### Edit Menu
- **Undo**: Undo the last action
- **Redo**: Redo the last undone action
- **Select All**: Select all images in the current view
- **Deselect All**: Deselect all selected images
- **Invert Selection**: Invert the current selection
- **Find**: Open the search dialog

### View Menu
- **Toggle Sidebar**: Show or hide the sidebar
- **Toggle Details Panel**: Show or hide the details panel
- **View Mode**: 
  - **Grid View**: Display images in a grid
  - **List View**: Display images in a list with details
- **Sort By**: Change the sorting order of images
- **Zoom**: Adjust the zoom level of the image grid
- **Refresh**: Refresh the current view

### Tools Menu
- **Batch Operations**: 
  - **Batch Rename**: Rename multiple images at once
  - **Batch Tag**: Add tags to multiple images
  - **Batch Export**: Export multiple images with custom settings
- **Metadata Editor**: Open advanced metadata editing tools
- **Image Tools**: 
  - **Crop**: Crop images
  - **Resize**: Resize images
  - **Convert Format**: Convert images to different formats
- **AI Tools**: 
  - **Auto-Tag**: Use AI to automatically tag images
  - **Generate Thumbnails**: Regenerate thumbnails for all images

### Help Menu
- **Documentation**: Open this documentation
- **Keyboard Shortcuts**: Display keyboard shortcuts
- **About**: Show application version and credits
- **Check for Updates**: Check for new versions
- **Report Issue**: Open GitHub issues page

## 2. Sidebar

The sidebar provides quick access to different views and organizational features:

### Folders View
- **Root Folders**: Displays the root folders you've added to your library
- **Subfolders**: Expand folders to view their contents
- **Add Folder**: Click the `+` button to add a new root folder
- **Folder Options**: Right-click a folder to access options like:
  - Refresh Folder
  - Remove Folder
  - Properties

### Albums View
- **My Albums**: Displays all user-created albums
- **Add Album**: Click the `+` button to create a new album
- **Album Options**: Right-click an album to access options like:
  - Rename Album
  - Delete Album
  - Add Images
  - Properties

### Tags View
- **All Tags**: Displays all tags in your library, sorted by usage
- **Tag Cloud**: Visual representation of tags by popularity
- **Add Tag**: Click the `+` button to create a new tag
- **Tag Options**: Right-click a tag to access options like:
  - Rename Tag
  - Delete Tag
  - Merge Tags
  - View Images with Tag

### Smart Collections
- **All Images**: All images in your library
- **Favorites**: Images marked as favorites
- **Recently Added**: Images added in the last 30 days
- **Recently Viewed**: Images viewed in the last 7 days
- **Untagged Images**: Images without any tags
- **For Deletion**: Images marked for deletion

## 3. Toolbar

The toolbar provides quick access to common actions and settings:

### Main Toolbar
- **Import**: Import images from folders
- **Refresh**: Refresh the current view
- **View Mode**: Toggle between grid and list views
- **Sort**: Change the sorting order (by name, date, size, etc.)
- **Filter**: Open the filter panel
- **Settings**: Open application settings

### Image Operations Toolbar
- **Favorite**: Mark/unmark selected images as favorites
- **Delete**: Delete selected images
- **Tag**: Add tags to selected images
- **Edit**: Open image editor
- **Export**: Export selected images

## 4. Main Content Area

The main content area displays images and their details, and consists of two parts:

### Image Display

#### Grid View
- **Image Thumbnails**: Displays images in a grid of thumbnails
- **Selection**: 
  - Click to select a single image
  - Ctrl/Cmd + Click to select multiple images
  - Shift + Click to select a range of images
  - Drag to select multiple images in a rectangular area
- **Image Information**: Shows basic information on hover (filename, dimensions, size)

#### List View
- **Columns**: Displays images with columns for:
  - Filename
  - Size
  - Dimensions
  - Date Added
  - Date Modified
  - Rating
  - Favorite status
- **Sorting**: Click column headers to sort by that column
- **Resizable Columns**: Drag column dividers to adjust widths

#### Full-Screen View
- **Double-Click**: Open an image in full-screen view
- **Navigation**: 
  - Arrow keys to navigate between images
  - Escape to exit full-screen mode
  - Right-click for additional options
- **Zoom**: Use mouse wheel to zoom in/out
- **Pan**: Click and drag to pan when zoomed in

### Details Panel

The details panel appears on the right side of the window when an image is selected, displaying detailed information about the image:

#### Basic Information
- **Filename**: Name of the image file
- **Path**: Full file path
- **Size**: File size in bytes/KB/MB
- **Dimensions**: Width and height in pixels
- **Resolution**: DPI information (if available)
- **Format**: File format (JPEG, PNG, etc.)
- **Date Added**: When the image was added to the library
- **Date Modified**: Last modified date of the file

#### AI Metadata
- **Prompt**: The prompt used to generate the image
- **Negative Prompt**: The negative prompt used
- **Steps**: Number of generation steps
- **Sampler**: Name of the sampler used
- **CFG Scale**: CFG scale value
- **Seed**: Seed value used for generation
- **Model**: Name of the model used
- **Model Hash**: Hash of the model
- **Width/Height**: Generated dimensions

#### Image Properties
- **Rating**: 1-5 star rating system
- **Favorite**: Toggle favorite status
- **For Deletion**: Mark for deletion
- **NSFW**: Mark as Not Safe For Work
- **Unavailable**: File is unavailable

#### Tags
- **Tags List**: Display all tags associated with the image
- **Add Tag**: Click `+` to add new tags
- **Remove Tag**: Click `×` to remove existing tags

## 5. Status Bar

The status bar appears at the bottom of the window and displays:

- **Total Images**: Number of images in the current view
- **Selected Images**: Number of selected images
- **Filter Status**: Current filter being applied
- **Sort Status**: Current sorting criteria
- **Application Status**: Current application activity (importing, exporting, etc.)
- **Database Size**: Size of the current database

## 6. Dialogs and Panels

### Import Dialog
- **Folder Selection**: Choose folders to import images from
- **Import Options**: 
  - Include subfolders
  - Overwrite existing images
  - Extract metadata
  - Generate thumbnails
- **Progress Indicator**: Shows import progress

### Export Dialog
- **Destination Folder**: Choose where to export images
- **Export Options**: 
  - Include metadata
  - Resize images
  - Convert to format
  - Rename files
- **Progress Indicator**: Shows export progress

### Filter Panel
- **Text Search**: Search by filename, tags, or metadata
- **Date Range**: Filter by creation or modification date
- **Dimensions**: Filter by image width and height
- **Rating**: Filter by star rating
- **Tags**: Filter by specific tags
- **AI Metadata**: Filter by model, sampler, steps, etc.

### Settings Dialog
- **General**: Application language, theme, and startup options
- **Library**: Database location and backup settings
- **Import**: Default import options
- **Display**: Thumbnail size, grid spacing, and view options
- **Metadata**: Metadata extraction and display options
- **Keyboard Shortcuts**: Customize keyboard shortcuts

## 7. Context Menus

Context menus appear when you right-click on various elements:

### Image Context Menu
- **View**: Open in full-screen view
- **Edit**: Edit image or metadata
- **Copy**: Copy image to clipboard
- **Move To**: Move image to another folder or album
- **Copy To**: Copy image to another location
- **Delete**: Delete image from library
- **Add to Album**: Add to existing album
- **Add Tags**: Add tags to image
- **Remove Tags**: Remove tags from image
- **Set Rating**: Set star rating
- **Mark as Favorite**: Toggle favorite status
- **Properties**: View detailed properties

### Folder Context Menu
- **Open in Explorer/Finder**: Open folder in system file manager
- **Refresh**: Refresh folder contents
- **Remove Folder**: Remove from library (doesn't delete files)
- **Properties**: View folder properties

### Album Context Menu
- **Open**: View album contents
- **Rename**: Rename album
- **Delete**: Delete album
- **Add Images**: Add images to album
- **Remove Images**: Remove selected images from album
- **Properties**: View album properties

### Tag Context Menu
- **View Images**: View all images with this tag
- **Rename**: Rename tag
- **Delete**: Delete tag
- **Merge With**: Merge with another tag
- **Properties**: View tag properties

## 8. Keyboard Shortcuts

For quick access to common commands, refer to the [Keyboard Shortcuts](./keyboard-shortcuts.md) reference.

## Customization Options

### Theme
- **Light Mode**: Bright color scheme
- **Dark Mode**: Dark color scheme
- **System Theme**: Follow system theme settings

### View Options
- **Thumbnail Size**: Adjust the size of thumbnails in grid view
- **Grid Spacing**: Adjust spacing between images in grid view
- **Show/Hide Columns**: Customize which columns appear in list view
- **Details Panel Position**: Move details panel to left or right

### Font Size
- Adjust the font size for better readability

## Tips for Efficient Navigation

1. **Keyboard Navigation**: Use keyboard shortcuts for faster operation
2. **Customize Toolbar**: Add frequently used commands to the toolbar
3. **Pin Frequent Items**: Pin frequently used folders, albums, and tags to the top of their respective lists
4. **Use Smart Collections**: Take advantage of pre-built smart collections for quick access
5. **Custom Filters**: Create and save custom filters for recurring searches
6. **Keyboard Focus**: Press `Tab` to navigate between UI elements
7. **Context Menus**: Right-click on elements for quick access to options

## Conclusion

The AVA AIGC Toolbox UI is designed to be intuitive and efficient, with all features easily accessible from the main interface. By familiarizing yourself with the different components, you'll be able to navigate and use the application more effectively, helping you manage your AI-generated images with ease.

For more information on specific features, refer to the relevant sections in this documentation: