# Troubleshooting
\n> **La versione inglese è quella ufficiale**\n\n
This guide provides solutions to common issues you may encounter while using the AVA AIGC Toolbox. If you can't find a solution here, please check the [FAQ](./faq.md) or reach out to our support team.

## Application Launch Issues

### Application Won't Start
- **Check System Requirements**: Ensure your system meets the minimum requirements (see [System Requirements](./getting-started.md#system-requirements))
- **Check .NET Runtime**: Ensure you have .NET 7.0 or later installed
- **Check File Permissions**: Ensure you have executable permissions for the application
- **Run as Administrator**: Try running the application as administrator/root
- **Check Log Files**: Review log files for error messages
  - Windows: `%APPDATA%/AIGenManager/logs/`
  - macOS: `~/.local/share/AIGenManager/logs/`
  - Linux: `~/.local/share/AIGenManager/logs/`
- **Reinstall Application**: Try reinstalling the application

### Application Crashes on Startup
- **Check Database Integrity**: The database may be corrupted, try restoring from backup
- **Reset Settings**: Delete the settings file to reset to defaults
  - Windows: `%APPDATA%/AIGenManager/settings.json`
  - macOS: `~/.local/share/AIGenManager/settings.json`
  - Linux: `~/.local/share/AIGenManager/settings.json`
- **Update Graphics Drivers**: Outdated graphics drivers can cause crashes
- **Disable GPU Acceleration**: Add `--disable-gpu` to the command line arguments
- **Check for Updates**: Ensure you're using the latest version of the application

## Library Issues

### Can't Open Library
- **Check File Path**: Ensure the library file exists at the specified path
- **Check File Permissions**: Ensure you have read/write access to the library file
- **Check Database Integrity**: The database may be corrupted, try using the repair tool
- **Restore from Backup**: Restore the library from a recent backup

### Library Corruption
- **Run Database Repair**: Go to `Tools > Database > Repair Database`
- **Restore from Backup**: Restore from the latest valid backup
- **Check Disk Health**: Check your hard drive for errors
- **Optimize Database**: Go to `Tools > Database > Optimize Database`

### Slow Library Performance
- **Optimize Database**: Regularly optimize the database to improve performance
- **Increase Cache Size**: Increase thumbnail and image cache sizes in settings
- **Reduce Thumbnail Quality**: Lower thumbnail quality in settings for better performance
- **Close Other Applications**: Free up system resources by closing other applications
- **Use Local Storage**: Ensure images are stored on local drives, not network drives

## Import Issues

### Can't Import Images
- **Check File Permissions**: Ensure you have read access to the source images
- **Check Supported Formats**: Ensure images are in supported formats (JPEG, PNG, WebP, TIFF, BMP, GIF)
- **Check File Size**: Some very large images may fail to import
- **Check Disk Space**: Ensure there's enough disk space at the destination
- **Check File Locks**: Ensure images aren't locked by other applications

### Import Taking Too Long
- **Reduce Batch Size**: Import images in smaller batches
- **Disable Thumbnail Generation**: Disable thumbnail generation during import
- **Disable Metadata Extraction**: Disable metadata extraction during import
- **Use Local Storage**: Ensure source images are on local drives

### Metadata Not Extracting
- **Check Image Format**: Ensure images contain embedded metadata
- **Check Metadata Format**: Ensure metadata is in a supported format
- **Try Manual Extraction**: Use manual metadata extraction (right-click > Extract Metadata)
- **Update Application**: Ensure you're using the latest version

## Image Viewing Issues

### Images Not Displaying
- **Check File Path**: Ensure the image files still exist at their original locations
- **Check File Permissions**: Ensure you have read access to the images
- **Regenerate Thumbnails**: Try regenerating thumbnails (right-click > Generate Thumbnails)
- **Check Image Format**: Ensure images are in supported formats
- **Clear Thumbnail Cache**: Clear the thumbnail cache in settings

### Full-Screen View Issues
- **Check Graphics Drivers**: Update your graphics drivers
- **Disable GPU Acceleration**: Disable GPU acceleration in settings
- **Check Display Resolution**: Ensure your display resolution is supported
- **Use Keyboard Shortcuts**: Use `Esc` to exit full-screen view if the UI is unresponsive

### Images Appear Blurry
- **Check Zoom Level**: Ensure you're viewing images at 100% or higher zoom
- **Check Image Quality**: The original images may be low quality
- **Check Thumbnail Settings**: Ensure thumbnail quality is set to high in settings
- **Regenerate Thumbnails**: Regenerate thumbnails for better quality

## Organization Issues

### Tags Not Being Applied
- **Check Selection**: Ensure you've selected the correct images
- **Check Tag Name Format**: Avoid using commas in tag names
- **Check Database Permissions**: Ensure you have write access to the database
- **Optimize Database**: Try optimizing the database

### Albums Not Showing Images
- **Check Album Membership**: Ensure images are properly added to albums
- **Refresh Album**: Try refreshing the album
- **Check Image Availability**: Ensure the image files still exist
- **Repair Database**: Run database repair tool

### Folders Not Updating
- **Check File Watcher**: Ensure file system watching is enabled in settings
- **Refresh Folder**: Manually refresh the folder
- **Check Folder Permissions**: Ensure you have read access to the folder
- **Check Folder Existence**: Ensure the folder still exists

## Search Issues

### No Search Results
- **Check Search Query**: Ensure your search query is correct
- **Check Search Scope**: Ensure you're searching in the correct scope (all images, folder, album, etc.)
- **Check Filters**: Ensure no filters are restricting your results
- **Check Database Index**: Rebuild search index in settings

### Search Results Not Accurate
- **Check Search Options**: Ensure you're using the correct search options
- **Rebuild Search Index**: Rebuild the search index
- **Check Metadata**: Ensure metadata is properly extracted and indexed

### Slow Search Performance
- **Optimize Database**: Optimize the database to improve search performance
- **Rebuild Search Index**: Rebuild the search index
- **Reduce Search Scope**: Search within specific folders or albums

## Export Issues

### Can't Export Images
- **Check Destination Permissions**: Ensure you have write access to the destination folder
- **Check Disk Space**: Ensure there's enough disk space at the destination
- **Check File Locks**: Ensure images aren't locked by other applications
- **Reduce Batch Size**: Export images in smaller batches

### Exported Images Missing Metadata
- **Check Export Options**: Ensure you've selected to include metadata in the export
- **Check Format Support**: Ensure the export format supports metadata embedding
- **Check Metadata Availability**: Ensure images have metadata to export

### Export Taking Too Long
- **Reduce Batch Size**: Export images in smaller batches
- **Reduce Quality Settings**: Use lower quality settings for faster export
- **Disable Resize**: Disable image resizing during export
- **Close Other Applications**: Free up system resources

## AI Features Issues

### AI Features Not Working
- **Check AI Settings**: Ensure AI features are enabled in settings
- **Check Model Availability**: Ensure required AI models are installed
- **Check API Credentials**: Ensure API keys are correctly configured
- **Check Network Connection**: Ensure you have internet access for cloud-based AI features
- **Check System Requirements**: Ensure your system meets AI processing requirements

### Slow AI Processing
- **Reduce Parallel Requests**: Decrease the number of parallel AI requests in settings
- **Use Local Models**: Switch to local models for faster processing
- **Close Other Applications**: Free up system resources
- **Use Smaller Models**: Use smaller AI models for faster processing

### Poor AI Results
- **Adjust Confidence Threshold**: Change the confidence threshold for better results
- **Try Different Models**: Experiment with different AI models
- **Improve Input Quality**: Ensure input images are of good quality
- **Update Models**: Use the latest versions of AI models

## UI Issues

### UI Not Responding
- **Wait for Operation to Complete**: Some operations may take time to finish
- **Close Other Applications**: Free up system resources
- **Restart Application**: Try restarting the application
- **Reset Settings**: Reset settings to default

### UI Elements Missing
- **Check Display Resolution**: Ensure your display resolution is supported
- **Restart Application**: Try restarting the application
- **Reset Settings**: Reset UI settings to default
- **Update Application**: Ensure you're using the latest version

### UI Font Too Small/Large
- **Adjust Font Size**: Change font size in settings
- **Restart Application**: Restart to apply font size changes
- **Check Display Scaling**: Ensure display scaling is set correctly in your OS

## General Tips

1. **Update Regularly**: Keep the application updated to the latest version
2. **Backup Regularly**: Backup your library regularly
3. **Optimize Database**: Regularly optimize the database for better performance
4. **Clear Caches**: Clear thumbnail and image caches periodically
5. **Reset Settings**: If you encounter persistent issues, reset settings to default
6. **Check Logs**: Review log files for error messages
7. **Reinstall if Needed**: If all else fails, try reinstalling the application
8. **Reach Out for Support**: If you can't resolve an issue, contact support

## Contacting Support

If you can't resolve an issue using this guide:

1. **Check the [FAQ](./faq.md)** for answers to common questions
2. **Search the Documentation** for related topics
3. **Check GitHub Issues** for similar issues reported by other users
4. **Create a Support Ticket** with:
   - Application version
   - OS version
   - Detailed description of the issue
   - Steps to reproduce the issue
   - Log files
   - Screenshots (if applicable)

## Next Steps

- Check the [FAQ](./faq.md) for answers to common questions
- Explore [Tips & Best Practices](./tips-best-practices.md) for more user tips
- Read about [Settings](./settings.md) to configure application preferences