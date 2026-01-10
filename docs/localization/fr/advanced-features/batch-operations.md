# Batch Operations
\n> **La version anglaise prévaut**\n\n
The AVA AIGC Toolbox allows you to perform bulk operations on multiple images at once, saving you time and effort. This guide covers the various batch operations available in the application.

## Batch Tagging

### Adding Tags to Multiple Images

#### Steps to Batch Add Tags:
1. Select multiple images in the main content area
2. Right-click and select **Add Tags**, or go to `Tools > Batch Operations > Batch Add Tags`
3. In the batch tag dialog, enter the tags you want to add, separated by commas
4. Choose tag options:
   - **Replace existing tags**: Replace all existing tags with the new tags
   - **Append to existing tags**: Add new tags to existing tags
5. Click **Add Tags** to apply the tags to all selected images

### Removing Tags from Multiple Images

#### Steps to Batch Remove Tags:
1. Select multiple images in the main content area
2. Right-click and select **Remove Tags**, or go to `Tools > Batch Operations > Batch Remove Tags`
3. In the batch remove tag dialog, select the tags you want to remove
4. Click **Remove Tags** to remove the selected tags from all images

### Replacing Tags in Multiple Images

#### Steps to Batch Replace Tags:
1. Select multiple images in the main content area
2. Right-click and select **Replace Tags**, or go to `Tools > Batch Operations > Batch Replace Tags`
3. In the batch replace tag dialog, enter the old tag and the new tag
4. Click **Replace Tags** to replace the old tag with the new tag in all images

## Batch Metadata Editing

### Updating Metadata for Multiple Images

#### Steps to Batch Edit Metadata:
1. Select multiple images in the main content area
2. Right-click and select **Edit Metadata**, or go to `Tools > Batch Operations > Batch Edit Metadata`
3. In the batch metadata dialog, select the metadata fields you want to edit
4. Enter the new values for each selected field
5. Choose how to apply the changes:
   - **Set**: Replace existing values with the new value
   - **Append**: Add the new value to existing values
   - **Prepend**: Insert the new value before existing values
6. Click **Apply** to save the changes to all selected images

### Applying Metadata Templates

#### Steps to Apply Metadata Templates to Multiple Images:
1. Select multiple images in the main content area
2. Right-click and select **Apply Metadata Template**
3. Choose a template from the list
4. Click **Apply** to apply the template to all selected images

## Batch Image Operations

### Resizing Multiple Images

#### Steps to Batch Resize Images:
1. Select multiple images in the main content area
2. Right-click and select **Resize Images**, or go to `Tools > Batch Operations > Batch Resize`
3. In the batch resize dialog, configure resize options:
   - **Resize by Percentage**: Resize images by a percentage of the original size
   - **Resize to Specific Dimensions**: Resize images to specific width and height
   - **Maintain Aspect Ratio**: Keep the original aspect ratio when resizing
   - **Quality**: Set the quality for resized images
4. Choose output options:
   - **Overwrite original images**: Replace original images with resized versions
   - **Save as new images**: Save resized images as new files
5. Click **Resize** to start the process
6. Monitor progress in the dialog
7. Click **Finish** when done

### Converting Multiple Images

#### Steps to Batch Convert Images:
1. Select multiple images in the main content area
2. Right-click and select **Convert Images**, or go to `Tools > Batch Operations > Batch Convert`
3. In the batch convert dialog, select the target format (JPEG, PNG, WebP, TIFF, BMP)
4. Configure format-specific options:
   - **Quality**: Set the quality for lossy formats (JPEG, WebP)
   - **Compression Level**: Set the compression level for lossless formats (PNG, TIFF)
5. Choose output options:
   - **Overwrite original images**: Replace original images with converted versions
   - **Save as new images**: Save converted images as new files
6. Click **Convert** to start the process
7. Monitor progress in the dialog
8. Click **Finish** when done

### Renaming Multiple Images

#### Steps to Batch Rename Images:
1. Select multiple images in the main content area
2. Right-click and select **Rename Images**, or go to `Tools > Batch Operations > Batch Rename`
3. In the batch rename dialog, configure rename options:
   - **Prefix**: Add a prefix to filenames
   - **Suffix**: Add a suffix to filenames
   - **Numbering**: Add sequential numbers
   - **Pattern**: Use a custom pattern for renaming
4. Preview the new names
5. Click **Rename** to apply the changes

## Batch Rating and Properties

### Rating Multiple Images

#### Steps to Batch Rate Images:
1. Select multiple images in the main content area
2. Right-click and select **Set Rating**
3. Choose the star rating (1-5 stars)
4. The rating will be applied to all selected images

### Marking Multiple Images as Favorites

#### Steps to Batch Mark as Favorites:
1. Select multiple images in the main content area
2. Right-click and select **Mark as Favorite**, or click the heart button in the toolbar
3. The favorite status will be toggled for all selected images

### Marking Multiple Images for Deletion

#### Steps to Batch Mark for Deletion:
1. Select multiple images in the main content area
2. Right-click and select **Mark for Deletion**
3. The selected images will be marked for deletion
4. To view marked images, go to **Smart Collections > For Deletion**
5. To delete marked images, select them and click **Delete**

## Batch AI Operations

### Batch Auto-Tagging

#### Steps to Batch Auto-Tag Images:
1. Select multiple images in the main content area
2. Right-click and select **AI Tools > Auto-Tag Images**, or go to `Tools > AI Tools > Auto-Tag Images`
3. In the auto-tag dialog, configure tag generation options
4. Click **Generate Tags** to start the process
5. Monitor progress in the dialog
6. Review generated tags
7. Click **Apply** to apply the tags to all selected images

### Batch Metadata Enhancement

#### Steps to Batch Enhance Metadata:
1. Select multiple images in the main content area
2. Right-click and select **AI Tools > Enhance Metadata**, or go to `Tools > AI Tools > Enhance Metadata`
3. In the enhancement dialog, select which metadata fields to enhance
4. Click **Enhance Metadata** to start the process
5. Monitor progress in the dialog
6. Review enhanced metadata
7. Click **Apply** to save the changes to all selected images

## Batch Export

### Exporting Multiple Images

#### Steps to Batch Export Images:
1. Select multiple images in the main content area
2. Right-click and select **Export Selected Images**, or go to `File > Export > Export Selected Images`
3. In the export dialog, configure export options
4. Click **Export** to start the process
5. Monitor progress in the dialog
6. Click **Finish** when done

### Using Export Presets for Batch Export

#### Steps to Use Export Presets for Batch Export:
1. Select multiple images in the main content area
2. Right-click and select **Export Selected Images**
3. In the export dialog, click the **Presets** dropdown menu
4. Select a preset from the list
5. Click **Export** to use the preset for batch export

## Batch Operations Best Practices

1. **Start with a Small Batch**: Test batch operations on a small number of images first
2. **Use Undo When Possible**: Many batch operations support undo, use it if you make a mistake
3. **Backup Before Batch Operations**: Always backup your images before performing destructive batch operations
4. **Use Filters to Select Images**: Use search and filtering to select the exact images you want to process
5. **Monitor Progress**: Keep an eye on batch operation progress for large batches
6. **Use Presets**: Save frequently used batch operation configurations as presets
7. **Check Results**: Always check the results of batch operations before continuing
8. **Avoid Overwriting Original Files**: When possible, save processed images as new files

## Troubleshooting Batch Operations

### Batch Operation Failing
- **Check File Permissions**: Ensure you have write access to the images
- **Check File Locks**: Ensure the images are not locked by other applications
- **Check Image Formats**: Ensure all images are in supported formats
- **Reduce Batch Size**: Try processing images in smaller batches

### Slow Batch Processing
- **Close Other Applications**: Free up system resources by closing other applications
- **Reduce Parallel Processing**: Decrease the number of parallel processes in settings
- **Use Lower Quality Settings**: Use lower quality settings for faster processing
- **Use Local Storage**: Ensure images are stored on local drives, not network drives

### Incorrect Results from Batch Operations
- **Check Configuration**: Ensure you configured the batch operation correctly
- **Use Undo**: If available, use undo to revert the operation
- **Restore from Backup**: If the operation was destructive, restore from backup
- **Test on Sample Images**: Test the operation on sample images first

### Images Not Selected Correctly
- **Check Selection**: Ensure you selected the correct images
- **Use Filters**: Use search and filtering to select images more precisely
- **Use Smart Collections**: Use smart collections to gather images for batch processing

## Next Steps

- Learn about [Backup & Restore](./backup-restore.md) to safeguard your library
- Read about [AI Integration](./ai-integration.md) for more AI-powered features
- Explore [Export & Sharing](../features/export-sharing.md) to share your processed images