# Getting Started Guide
\n> **English version is authoritative**\n\n
## Welcome to AVA AIGC Toolbox

Thank you for choosing AVA AIGC Toolbox! This guide will help you get started with the application and explore its key features.

## First Launch

### 1. Launch the Application
- **Windows**: Double-click the desktop shortcut or use Start menu
- **macOS**: Open from Applications folder or use Spotlight
- **Linux**: Launch from applications menu or run `ava-aigc-toolbox` in terminal

### 2. Initial Setup

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

## Basic Navigation

The main window is divided into several sections:

### 1. Sidebar
- **Folders**: Navigate through your image folders
- **Albums**: Access your image albums
- **Tags**: Browse and filter by tags
- **All Images**: View all images in your library

### 2. Main Content Area
- **Image Grid**: Displays images in a grid layout
- **Image Details**: Shows metadata and properties when an image is selected

### 3. Toolbar
- **Import**: Add new images to your library
- **Sort**: Change image sorting order
- **Filter**: Apply filters to the image grid
- **View**: Toggle between grid and list views

### 4. Status Bar
- Shows total number of images
- Displays current filter or search criteria
- Shows application status

## Adding Images

### 1. Importing Images

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

### 2. Image Metadata

When images are imported, the application automatically extracts:
- Filename and path
- File size and dimensions
- Creation and modification dates
- AI-generated metadata (if available):
  - Prompt
  - Negative prompt
  - Steps and sampler
  - CFG scale and seed
  - Model information

## Organizing Images

### 1. Using Folders

- The application mirrors your filesystem folder structure
- Navigate folders in the sidebar to view images in specific locations
- New folders created in the filesystem will be detected automatically

### 2. Creating Albums

1. Click the **+** button next to "Albums" in the sidebar
2. Enter a name for your album
3. Press Enter to create
4. Drag images from the grid into the album to add them

### 3. Adding Tags

#### To Single Image
1. Select an image in the grid
2. In the details panel, find the "Tags" section
3. Click the **+** button
4. Enter a tag name and press Enter

#### To Multiple Images
1. Select multiple images using Ctrl/Cmd + click
2. Right-click and select **Add Tags**
3. Enter tag names separated by commas
4. Click **Add** to apply tags to all selected images

## Working with Images

### 1. Viewing Images

- **Single Click**: Select an image to see details
- **Double Click**: Open image in full-screen view
- **Right Click**: Open context menu with additional options

### 2. Image Details

When an image is selected, you'll see:
- Basic information (filename, size, dimensions)
- AI metadata (prompt, negative prompt, etc.)
- Tags associated with the image
- Rating and favorite status

### 3. Editing Metadata

1. Select an image
2. In the details panel, click on any editable field
3. Make your changes
4. Press Enter or click outside the field to save

### 4. Rating and Favoriting

- **Rating**: Click the stars in the details panel to rate an image (1-5 stars)
- **Favorite**: Click the heart icon to mark an image as favorite
- **For Deletion**: Mark images for deletion to easily remove them later

## Searching and Filtering

### 1. Basic Search

1. Type in the search box at the top of the window
2. Results will appear automatically as you type
3. Search matches against filenames, tags, and metadata

### 2. Advanced Filtering

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

## Exporting Images

### 1. Export Single Image

1. Select an image
2. Right-click and select **Export Image**
3. Choose destination folder
4. Click **Save**

### 2. Export Multiple Images

1. Select multiple images
2. Right-click and select **Export Selected Images**
3. Choose destination folder
4. Click **Save**

### 3. Export with Metadata

- When exporting, you can choose to include metadata
- Check the "Include metadata" option in the export dialog
- Metadata will be embedded in the exported images

## Next Steps

Now that you've learned the basics, you can:

- Explore the [UI Overview](./ui-overview.md) for detailed interface explanation
- Learn about [Image Management](./features/image-management.md) for more details on managing your images
- Read about [Organization](./features/organization.md) to learn more about folders, albums, and tags
- Check the [FAQ](./faq.md) for common questions

## Tips and Tricks

- **Keyboard Shortcuts**: Press `Ctrl/Cmd + K` to see all keyboard shortcuts
- **Batch Operations**: Select multiple images to perform batch operations
- **Auto-Tagging**: Use AI-powered auto-tagging for your images
- **Backup**: Regularly backup your database file to prevent data loss
- **Update Metadata**: Use the metadata editor to keep your image information organized

Enjoy using AVA AIGC Toolbox for managing your AI-generated images!