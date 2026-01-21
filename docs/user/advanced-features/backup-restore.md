<<<<<<< HEAD
# Backup & Restore

The AVA AIGC Toolbox provides robust backup and restoration features to safeguard your image library. This guide covers how to backup your library and restore it if needed.

## Understanding the Library Structure

Before backing up your library, it's important to understand its structure:

- **Database File**: Contains all metadata, tags, albums, and organizational information
- **Image Files**: The actual image files are stored on your filesystem
- **Thumbnail Cache**: Contains generated thumbnails for faster browsing

## Backup Options

### 1. Database Backup

The most critical component to backup is the database file, which contains all your organizational data:

#### Steps to Backup the Database:
1. Go to `File > Backup Library`, or click the **Backup** button in the toolbar
2. In the backup dialog, select **Database Only** as the backup type
3. Choose the destination folder for the backup
4. Enter a name for the backup file
5. Click **Backup** to start the process
6. Monitor progress in the dialog
7. Click **Finish** when done

### 2. Complete Backup

A complete backup includes:
- Database file
- Thumbnail cache
- Optional: Image files (if they're stored in a managed location)

#### Steps to Perform a Complete Backup:
1. Go to `File > Backup Library`
2. In the backup dialog, select **Complete Backup** as the backup type
3. Choose the destination folder for the backup
4. Configure backup options:
   - **Include Image Files**: Include the actual image files in the backup
   - **Compress Backup**: Create a compressed backup file
   - **Encrypt Backup**: Encrypt the backup with a password
5. Click **Backup** to start the process
6. Monitor progress in the dialog
7. Click **Finish** when done

### 3. Automatic Backup

You can configure the application to automatically backup your library:

#### Steps to Set Up Automatic Backup:
1. Go to `Settings > Library > Backup`
2. Check **Enable automatic backup**
3. Configure backup settings:
   - **Backup Frequency**: How often to backup (daily, weekly, monthly)
   - **Backup Time**: Time of day to perform the backup
   - **Backup Type**: Database only or complete backup
   - **Destination Folder**: Where to store backups
   - **Keep Backups For**: How long to keep old backups
   - **Maximum Backup Count**: Maximum number of backups to keep
4. Click **Save** to enable automatic backups

## Restoring from Backup

### 1. Restoring the Database

#### Steps to Restore the Database:
1. Close the application (recommended)
2. Go to `File > Restore Library`
3. In the restore dialog, select **Database Only** as the restore type
4. Click **Browse** and select the backup file
5. Configure restore options:
   - **Overwrite existing database**: Replace the current database
   - **Verify backup integrity**: Check if the backup file is valid
6. Click **Restore** to start the process
7. Monitor progress in the dialog
8. Click **Finish** when done
9. Restart the application for changes to take effect

### 2. Complete Restore

#### Steps to Perform a Complete Restore:
1. Close the application (recommended)
2. Go to `File > Restore Library`
3. In the restore dialog, select **Complete Restore** as the restore type
4. Click **Browse** and select the backup file
5. Choose the destination folder for restoration
6. Configure restore options:
   - **Overwrite existing files**: Replace existing files with restored files
   - **Verify backup integrity**: Check if the backup file is valid
   - **Restore image files**: Restore the actual image files
   - **Restore thumbnail cache**: Restore the thumbnail cache
7. Click **Restore** to start the process
8. Monitor progress in the dialog
9. Click **Finish** when done
10. Restart the application for changes to take effect

## Backup File Management

### Viewing Backup History

#### Steps to View Backup History:
1. Go to `Settings > Library > Backup`
2. Scroll down to the **Backup History** section
3. View the list of existing backups
4. Click a backup to see details:
   - Backup date and time
   - Backup type
   - File size
   - Backup location
5. Use the buttons to:
   - **View Backup**: Open the backup file location
   - **Delete Backup**: Remove the backup file
   - **Restore Backup**: Restore from this backup

### Managing Backup Files

- **Backup Location**: By default, backups are stored in:
  - Windows: `%APPDATA%/AIGenManager/Backups/`
  - macOS: `~/.local/share/AIGenManager/Backups/`
  - Linux: `~/.local/share/AIGenManager/Backups/`

- **Manual Backup Management**: 
  - You can manually copy backup files to external storage
  - Keep backups in multiple locations for redundancy
  - Label backups clearly with date and type

## Best Practices for Backup

1. **Backup Regularly**: Schedule regular backups based on how frequently you add images
2. **Use Multiple Locations**: Store backups in at least two different locations (local and external)
3. **Test Restores**: Periodically test restoring from backups to ensure they're valid
4. **Backup Before Major Changes**: Always backup before performing batch operations or upgrading the application
5. **Encrypt Sensitive Backups**: Use encryption for backups containing sensitive images
6. **Keep Backups for Different Time Periods**: Keep daily, weekly, and monthly backups
7. **Document Backup Locations**: Keep a record of where your backups are stored
8. **Consider Cloud Storage**: Store backups in cloud storage for off-site protection

## Troubleshooting Backup Issues

### Backup Failing
- **Check Disk Space**: Ensure there's enough disk space at the backup destination
- **Check Permissions**: Ensure you have write access to the backup location
- **Check File Locks**: Ensure the database isn't locked by another process
- **Close Other Applications**: Close other applications that might be accessing the database

### Restore Failing
- **Check Backup File**: Ensure the backup file is valid and not corrupted
- **Check File Permissions**: Ensure you have write access to the library location
- **Close the Application**: Close the application before restoring to avoid file locks
- **Check Version Compatibility**: Ensure the backup is compatible with your current application version

### Corrupted Database
- **Try Automatic Repair**: Go to `Tools > Database > Repair Database`
- **Restore from Backup**: If repair fails, restore from the latest valid backup
- **Check Disk Health**: Check your hard drive for errors if you experience frequent corruption

## Database Optimization

Regular database optimization can improve performance and reduce corruption risks:

#### Steps to Optimize the Database:
1. Go to `Tools > Database > Optimize Database`
2. In the optimization dialog, select optimization options:
   - **Compact Database**: Reduce database file size
   - **Rebuild Indexes**: Rebuild database indexes for better performance
   - **Check Database Integrity**: Verify database integrity
3. Click **Optimize** to start the process
4. Monitor progress in the dialog
5. Click **Finish** when done

## Emergency Recovery

If you're unable to start the application due to database corruption:

1. **Locate the Database File**: Find the database file at its default location
2. **Rename the Corrupted Database**: Rename the corrupted database file (e.g., `aigenmanager.db.corrupted`)
3. **Start the Application**: The application will create a new empty database
4. **Restore from Backup**: Use the steps above to restore from your latest backup

## Backup File Format

Backup files are stored in the following formats:

- **.db**: SQLite database file (for database-only backups)
- **.zip**: Compressed backup file (for complete backups)
- **.bak**: Encrypted backup file (for encrypted backups)

## Migrating to a New Computer

### Steps to Migrate Your Library to a New Computer:
1. On the old computer:
   - Perform a complete backup of your library
   - Copy the backup file to an external storage device
   - Note the location of your image files
2. On the new computer:
   - Install the AVA AIGC Toolbox
   - Copy your image files to the same location (or a new location)
   - Open the application
   - Restore from the backup file
   - If you changed the image file location, update the library settings

## Next Steps

- Learn about [AI Integration](./ai-integration.md) for more AI-powered features
- Read about [Batch Operations](./batch-operations.md) for bulk image processing
- Explore [Settings](../settings.md) to configure backup settings
=======
# Backup & Restore\n\n*Placeholder for backup and restore*
>>>>>>> origin/doc/dev

