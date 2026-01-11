<<<<<<< HEAD
# Image Management

This guide covers the core image management features of the AVA AIGC Toolbox, including how to import, view, and manage your AI-generated images.

## Importing Images

### 1. Import from Folders

You can import images from your filesystem into the AVA AIGC Toolbox:

#### Steps to Import:
1. Click the **Import** button in the toolbar, or go to `File > Import > Import Images`
2. In the import dialog, click **Add Folder** and select one or more folders containing images
3. Configure import options:
   - **Include subfolders**: Import images from all subdirectories
   - **Overwrite existing images**: Replace images with the same path in the library
   - **Extract metadata**: Automatically extract AI metadata from images
   - **Generate thumbnails**: Create or regenerate thumbnails for all imported images
4. Click **Start Import** to begin the import process
5. Monitor the progress in the import dialog
6. Click **Finish** when import is complete

### 2. Drag and Drop

You can also import images by dragging and dropping them into the application:

#### Steps to Import via Drag and Drop:
1. Open your system's file manager (Explorer/Finder)
2. Select one or more images or folders
3. Drag them into the AVA AIGC Toolbox window
4. A confirmation dialog will appear with import options
5. Configure the options as desired
6. Click **Import** to start the import process

### 3. Automatic Import

The application can automatically watch folders for new images:

#### Steps to Set Up Automatic Import:
1. Go to `Settings > Library > Watched Folders`
2. Click **Add Folder** and select a folder to watch
3. Configure watch options:
   - **Include subfolders**: Monitor all subdirectories
   - **Check interval**: How often to check for new images (in minutes)
   - **Auto-import new images**: Automatically import new images when detected
4. Click **Save** to enable automatic importing

## Viewing Images

### 1. Grid View

Grid view displays images in a grid of thumbnails, which is the default view when you open the application:

#### Navigating Grid View:
- **Scroll**: Use your mouse wheel or scroll bar to navigate the grid
- **Zoom**: 
  - Use `Ctrl/Cmd +` to zoom in
  - Use `Ctrl/Cmd -` to zoom out
  - Use `Ctrl/Cmd 0` to reset zoom
- **Adjust Thumbnail Size**: Use the slider in the toolbar or go to `View > Thumbnail Size`

#### Selecting Images in Grid View:
- **Single Image**: Click on an image to select it
- **Multiple Images**: 
  - Hold `Ctrl/Cmd` and click to select multiple individual images
  - Hold `Shift` and click to select a range of images
  - Click and drag to draw a selection rectangle around multiple images
- **Select All**: Press `Ctrl/Cmd + A` to select all images in the current view
- **Deselect All**: Press `Esc` or go to `Edit > Deselect All`

### 2. List View

List view displays images in a list with detailed information columns:

#### Switching to List View:
- Click the **List View** button in the toolbar, or go to `View > List View`

#### Customizing List View:
- **Sort Columns**: Click on a column header to sort by that column
- **Resize Columns**: Drag the dividers between column headers to adjust widths
- **Show/Hide Columns**: Right-click on any column header to show or hide columns
- **Reset Columns**: Go to `View > Reset List Columns` to restore default columns

#### Available Columns:
- Filename
- Path
- Size
- Dimensions
- Date Added
- Date Modified
- Rating
- Favorite status
- Tags
- Model
- Sampler
- Steps
- CFG Scale
- Seed

### 3. Full-Screen View

Full-screen view allows you to view images in full resolution:

#### Opening Full-Screen View:
- Double-click on an image in grid or list view
- Select an image and press `Enter`
- Right-click on an image and select **View**

#### Navigating in Full-Screen View:
- **Next Image**: Use `Right Arrow`, `Page Down`, or click the right arrow button
- **Previous Image**: Use `Left Arrow`, `Page Up`, or click the left arrow button
- **Zoom**: 
  - Use mouse wheel to zoom in/out
  - Click and drag to pan when zoomed in
  - Press `F11` to toggle between fit-to-screen and actual size
- **Exit Full-Screen**: Press `Esc` or click the close button

#### Full-Screen View Options:
- **Show/Hide Controls**: Move your mouse to the bottom of the screen to show controls
- **Image Information**: Click the `i` button to toggle image information display
- **Slideshow**: Click the play button to start a slideshow
- **Set as Favorite**: Click the heart button to mark/unmark as favorite

## Image Operations

### 1. Copying Images

You can copy images to the clipboard or to other locations:

#### Copy to Clipboard:
1. Select one or more images
2. Right-click and select **Copy**
3. Paste the images into another application or location using `Ctrl/Cmd + V`

#### Copy to Folder:
1. Select one or more images
2. Right-click and select **Copy To**
3. Choose the destination folder
4. Click **Copy** to copy the images

### 2. Moving Images

You can move images to different folders within your library:

#### Steps to Move Images:
1. Select one or more images
2. Right-click and select **Move To**
3. Choose the destination folder
4. Click **Move** to move the images

### 3. Renaming Images

You can rename individual images or multiple images at once:

#### Rename Single Image:
1. Select an image
2. Right-click and select **Rename**
3. Type the new name
4. Press `Enter` to confirm

#### Batch Rename Images:
1. Select multiple images
2. Go to `Tools > Batch Operations > Batch Rename`
3. Configure rename options:
   - **Prefix**: Add a prefix to filenames
   - **Suffix**: Add a suffix to filenames
   - **Numbering**: Add sequential numbers
   - **Pattern**: Use a custom pattern for renaming
4. Preview the new names
5. Click **Rename** to apply the changes

### 4. Deleting Images

You can delete images from your library:

#### Delete Single Image:
1. Select an image
2. Press `Delete` or right-click and select **Delete**
3. Confirm the deletion in the dialog

#### Delete Multiple Images:
1. Select multiple images
2. Press `Delete` or right-click and select **Delete**
3. Confirm the deletion in the dialog

#### Mark for Deletion:
You can mark images for deletion without immediately removing them:
1. Select one or more images
2. Right-click and select **Mark for Deletion**
3. To view marked images, go to **Smart Collections > For Deletion**
4. To delete marked images, select them and click **Delete**
5. To unmark images, right-click and select **Unmark for Deletion**

### 5. Image Properties

You can view detailed properties of any image:

#### Steps to View Image Properties:
1. Select an image
2. Right-click and select **Properties**
3. The properties dialog will display:
   - Basic information (filename, path, size, dimensions)
   - File attributes (created date, modified date, accessed date)
   - AI metadata (prompt, negative prompt, steps, etc.)
   - Image statistics (color profile, bit depth)
4. Click **Close** when finished

## Thumbnail Management

### 1. Generate Thumbnails

The application automatically generates thumbnails when importing images, but you can regenerate them if needed:

#### Steps to Regenerate Thumbnails:
1. Select one or more images, or go to a folder/album view
2. Go to `Tools > AI Tools > Generate Thumbnails`
3. Configure options:
   - **Regenerate all thumbnails**: Replace existing thumbnails
   - **Quality**: Set thumbnail quality (high, medium, low)
   - **Size**: Set maximum thumbnail size
4. Click **Generate** to start the process
5. Monitor progress in the dialog
6. Click **Finish** when done

### 2. Thumbnail Settings

You can configure thumbnail settings in the application settings:

#### Steps to Configure Thumbnail Settings:
1. Go to `Settings > Display > Thumbnails`
2. Configure settings:
   - **Default thumbnail size**: Set the default size for grid view
   - **Quality**: Set thumbnail quality (high, medium, low)
   - **Cache size**: Set maximum cache size for thumbnails
   - **Auto-regenerate**: Automatically regenerate thumbnails when needed
3. Click **Save** to apply changes

## Best Practices for Image Management

1. **Organize First**: Plan your folder structure before importing large numbers of images
2. **Use Descriptive Names**: Name folders and images in a way that makes them easy to find
3. **Import with Metadata**: Always extract metadata when importing images
4. **Regular Backups**: Backup your library database regularly (see [Backup & Restore](../advanced-features/backup-restore.md))
5. **Optimize Performance**: For large libraries, consider increasing cache size and using lower thumbnail quality
6. **Clean Up Regularly**: Remove unused images and organize your library periodically
7. **Use Smart Collections**: Take advantage of smart collections for quick access to frequently used image groups

## Troubleshooting Image Management

### Images Not Importing
- **Check File Permissions**: Ensure you have read access to the source folders
- **Supported Formats**: Verify that your images are in supported formats (JPEG, PNG, WebP, TIFF, BMP, GIF)
- **File Size**: Check if images are too large to import
- **Corrupted Files**: Some images may be corrupted - try importing one image at a time to identify problematic files

### Thumbnails Not Displaying
- **Regenerate Thumbnails**: Try regenerating thumbnails for the affected images
- **Check Cache**: Clear the thumbnail cache in `Settings > Display > Thumbnails > Clear Cache`
- **File Access**: Ensure the application has access to the image files

### Slow Image Loading
- **Increase Cache Size**: Increase thumbnail cache size in settings
- **Lower Thumbnail Quality**: Reduce thumbnail quality for better performance
- **Close Other Applications**: Free up system resources by closing other applications
- **Optimize Database**: Use the database optimization tool in `Settings > Library > Optimize Database`

## Next Steps

- Learn about [Organization](./organization.md) to organize your images using folders, albums, and tags
- Read about [Metadata Editing](./metadata-editing.md) to view and edit AI metadata
- Explore [Search & Filtering](./search-filtering.md) to find images quickly
=======
# Image Management\n\n*Placeholder for image management features*
>>>>>>> origin/doc/dev

