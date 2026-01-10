# Export & Sharing
\n> **English version is authoritative**\n\n
The AVA AIGC Toolbox provides several options for exporting and sharing your AI-generated images. This guide covers how to use these features effectively.

## Exporting Images

### 1. Export Single Image

#### Steps to Export a Single Image:
1. Select the image you want to export
2. Right-click and select **Export Image**, or go to `File > Export > Export Selected Images`
3. The export dialog will appear
4. Choose the destination folder
5. Configure export options
6. Click **Export** to export the image

### 2. Export Multiple Images

#### Steps to Export Multiple Images:
1. Select multiple images in the main content area
2. Right-click and select **Export Selected Images**, or go to `File > Export > Export Selected Images`
3. The export dialog will appear
4. Choose the destination folder
5. Configure export options
6. Click **Export** to export all selected images
7. Monitor progress in the export dialog
8. Click **Finish** when done

### 3. Export All Images

#### Steps to Export All Images:
1. Go to `File > Export > Export All Images`
2. The export dialog will appear
3. Choose the destination folder
4. Configure export options
5. Click **Export** to export all images
6. Monitor progress in the export dialog
7. Click **Finish** when done

## Export Options

The export dialog provides several options to customize your export:

### 1. Destination
- **Folder**: Choose the destination folder for exported images
- **Subfolder Structure**: Choose how to handle subfolders (flat structure, preserve original structure, create new structure)

### 2. File Naming
- **Original Filename**: Use the original filenames
- **Custom Pattern**: Create a custom filename pattern using variables
  - `{filename}`: Original filename
  - `{id}`: Image ID
  - `{model}`: Model name
  - `{date}`: Creation date
  - `{time}`: Creation time
  - `{seed}`: Seed value

### 3. Format Options
- **Preserve Original Format**: Keep the original file format
- **Convert to Format**: Convert images to a different format (JPEG, PNG, WebP, TIFF, BMP)
- **Quality**: Set the quality for lossy formats (JPEG, WebP)
- **Compression Level**: Set the compression level for lossless formats (PNG, TIFF)

### 4. Resize Options
- **Preserve Original Size**: Keep the original image dimensions
- **Resize to Specific Dimensions**: Resize images to specific width and height
- **Maintain Aspect Ratio**: Keep the original aspect ratio when resizing
- **Resize by Percentage**: Resize images by a percentage of the original size

### 5. Metadata Options
- **Include Metadata**: Embed metadata in the exported images
- **Select Metadata Fields**: Choose which metadata fields to include
- **Format**: Choose metadata format (EXIF, XMP, PNG Text Chunks)
- **Preserve Original Metadata**: Keep all original metadata

### 6. Additional Options
- **Overwrite Existing Files**: Replace files with the same name in the destination
- **Create Subfolders for Different Models**: Create separate subfolders for different AI models
- **Open Destination Folder After Export**: Open the destination folder in your file manager after export

## Sharing Images

### 1. Share via Email

#### Steps to Share via Email:
1. Select one or more images
2. Right-click and select **Share > Email**
3. Your default email client will open with the images attached
4. Compose your email and send

### 2. Share to Social Media

#### Steps to Share to Social Media:
1. Select an image
2. Right-click and select **Share > Social Media**
3. Choose a social media platform (if supported)
4. Follow the platform-specific sharing instructions

### 3. Copy to Clipboard

#### Steps to Copy to Clipboard:
1. Select an image
2. Right-click and select **Copy**, or press `Ctrl/Cmd + C`
3. The image will be copied to your clipboard
4. Paste it into another application using `Ctrl/Cmd + V`

### 4. Generate Shareable Link

#### Steps to Generate Shareable Link:
1. Select one or more images
2. Right-click and select **Share > Generate Link**
3. Configure sharing options (expiry, access permissions)
4. Click **Generate Link**
5. Copy the generated link to share with others

## Batch Export

For more advanced batch export options, use the batch export tool:

#### Steps to Use Batch Export:
1. Go to `Tools > Batch Operations > Batch Export`
2. Select the images you want to export (all, current view, or selected)
3. Configure export options as described above
4. Click **Export** to start the batch export
5. Monitor progress in the batch export dialog
6. Click **Finish** when done

## Export Presets

You can save export configurations as presets for quick access:

### Creating Export Presets

#### Steps to Create an Export Preset:
1. Open the export dialog
2. Configure the export options
3. Click the **Save Preset** button
4. Enter a name for the preset
5. Click **Save** to create the preset

### Using Export Presets

#### Steps to Use an Export Preset:
1. Open the export dialog
2. Click the **Presets** dropdown menu
3. Select a preset from the list
4. The export options will be populated with the preset settings
5. Click **Export** to use the preset

### Managing Export Presets

#### Steps to Manage Export Presets:
1. Open the export dialog
2. Click the **Manage Presets** button
3. In the preset management dialog, you can:
   - **Edit**: Modify existing presets
   - **Delete**: Remove unwanted presets
   - **Reorder**: Change the order of presets
4. Click **Close** when finished

## Metadata Export

In addition to exporting images, you can also export metadata separately:

### Exporting Metadata to Files

#### Steps to Export Metadata:
1. Select one or more images
2. Go to `File > Export > Export Metadata`
3. Choose the export format (JSON, CSV, TXT)
4. Select which metadata fields to include
5. Choose the destination folder
6. Click **Export** to export the metadata

### Metadata Formats

- **JSON**: Structured format suitable for programming and data analysis
- **CSV**: Comma-separated values suitable for spreadsheets
- **TXT**: Plain text format suitable for reading

## Best Practices for Exporting

1. **Choose the Right Format**: Use appropriate formats for your use case (JPEG for web, PNG for lossless, WebP for modern web)
2. **Optimize for Destination**: Resize and compress images appropriately for their intended use
3. **Include Relevant Metadata**: Always include relevant metadata when sharing with others
4. **Use Descriptive Filenames**: Use descriptive filenames for easy identification
5. **Create Export Presets**: Save frequently used export configurations as presets
6. **Test with Sample Images**: Test your export settings with a few sample images first
7. **Backup Before Exporting**: Backup your images before performing large export operations
8. **Monitor Progress**: Keep an eye on export progress for large batches

## Troubleshooting Export Issues

### Export Failing
- **Check Destination Permissions**: Ensure you have write access to the destination folder
- **Check File Size**: Some export formats may have size limitations
- **Check Image Format**: Ensure the image format is supported for the chosen export format
- **Check Disk Space**: Ensure there's enough disk space in the destination

### Images Not Exporting with Metadata
- **Check Metadata Options**: Ensure you've selected to include metadata in the export
- **Check Format Support**: Ensure the export format supports metadata embedding
- **Check Metadata Availability**: Ensure the images have metadata to export

### Slow Export Performance
- **Reduce Quality/Compression**: Lower quality or compression for faster export
- **Export Fewer Images**: Export images in smaller batches
- **Close Other Applications**: Free up system resources by closing other applications
- **Use Faster Formats**: Use faster formats like WebP for web export

### Incorrect Filenames
- **Check Naming Pattern**: Ensure your custom filename pattern is correct
- **Check Variables**: Ensure you're using valid variables in your naming pattern
- **Avoid Special Characters**: Avoid special characters in filenames that may not be supported by your filesystem

## Next Steps

- Learn about [AI Integration](../advanced-features/ai-integration.md) for more AI-powered features
- Read about [Batch Operations](../advanced-features/batch-operations.md) for more bulk processing options
- Explore [Backup & Restore](../advanced-features/backup-restore.md) to safeguard your image library