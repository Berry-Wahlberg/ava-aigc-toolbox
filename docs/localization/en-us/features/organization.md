# Organization
\n> **English version is authoritative**\n\n
The AVA AIGC Toolbox provides several powerful ways to organize your AI-generated images: folders, albums, and tags. This guide covers how to use these features to keep your image library well-organized and easy to navigate.

## Folders

Folders in the AVA AIGC Toolbox mirror your filesystem structure, allowing you to organize images based on their physical location on your computer.

### Adding Folders

#### Steps to Add a Root Folder:
1. In the sidebar, navigate to the **Folders** view
2. Click the `+` button at the top of the sidebar, or go to `File > Add Folder`
3. Select the folder you want to add to your library
4. Configure folder options:
   - **Include subfolders**: Include all images from subdirectories
   - **Watch folder**: Automatically detect new images added to this folder
   - **Exclude folder**: Exclude this folder from future library updates
5. Click **Add** to add the folder to your library

### Managing Folders

#### Refreshing Folders
1. In the sidebar, right-click the folder you want to refresh
2. Select **Refresh Folder** from the context menu
3. The application will scan the folder for new, modified, or deleted images

#### Removing Folders
1. In the sidebar, right-click the folder you want to remove
2. Select **Remove Folder** from the context menu
3. Confirm the removal in the dialog
4. **Note**: This only removes the folder from the library, not from your filesystem

#### Folder Properties
1. In the sidebar, right-click a folder
2. Select **Properties** from the context menu
3. The properties dialog will display:
   - Folder path and size
   - Number of images contained
   - Last scan date
   - Folder options (include subfolders, watch folder, etc.)
4. Click **Close** when finished

### Folder Navigation

#### Expanding and Collapsing Folders
- Click the arrow next to a folder to expand or collapse it
- Double-click a folder to open it in the main content area

#### Searching Within Folders
1. Navigate to the folder you want to search in
2. Use the search bar at the top of the window
3. The search will be restricted to the current folder and its subfolders

## Albums

Albums are user-created collections of images that can contain images from different folders. Unlike folders, albums don't reflect your filesystem structure - they're virtual collections.

### Creating Albums

#### Steps to Create an Album:
1. In the sidebar, navigate to the **Albums** view
2. Click the `+` button at the top of the sidebar
3. Enter a name for your album
4. Press `Enter` or click outside the text field to create the album

#### Creating Albums from Selected Images:
1. Select one or more images in the main content area
2. Right-click and select **Add to Album > New Album**
3. Enter a name for the album
4. Press `Enter` to create the album

### Managing Albums

#### Adding Images to Albums

##### Add Single Image:
1. Select an image in the main content area
2. Right-click and select **Add to Album**
3. Choose an existing album from the list

##### Add Multiple Images:
1. Select multiple images in the main content area
2. Right-click and select **Add to Album**
3. Choose an existing album from the list, or select **New Album**

##### Drag and Drop:
1. Select one or more images in the main content area
2. Drag them into an album in the sidebar

#### Removing Images from Albums
1. Navigate to the album containing the images
2. Select the images you want to remove
3. Right-click and select **Remove from Album**
4. Confirm the removal in the dialog

#### Renaming Albums
1. In the sidebar, right-click the album you want to rename
2. Select **Rename Album** from the context menu
3. Enter the new name
4. Press `Enter` to confirm

#### Deleting Albums
1. In the sidebar, right-click the album you want to delete
2. Select **Delete Album** from the context menu
3. Confirm the deletion in the dialog
4. **Note**: This only deletes the album, not the images it contains

#### Album Properties
1. In the sidebar, right-click an album
2. Select **Properties** from the context menu
3. The properties dialog will display:
   - Album name and description
   - Number of images contained
   - Creation date and last modified date
   - Album order in the sidebar
4. Click **Close** when finished

### Album Organization

#### Rearranging Albums
1. In the sidebar, navigate to the **Albums** view
2. Click and drag an album to reorder it in the list
3. The new order will be saved automatically

#### Creating Album Hierarchies
1. Create a parent album as described above
2. Create child albums
3. Click and drag a child album onto the parent album to make it a sub-album
4. Expand the parent album to view sub-albums
5. Double-click a parent album to view all images in the parent and its sub-albums

## Tags

Tags are keywords that you can assign to images to categorize and find them easily. Tags are one of the most powerful organizational tools in the AVA AIGC Toolbox.

### Adding Tags

#### Adding Tags to Single Image:
1. Select an image in the main content area
2. In the details panel, find the **Tags** section
3. Click the `+` button next to the tags list
4. Enter a tag name
5. Press `Enter` or click outside the text field to add the tag

#### Adding Tags to Multiple Images:
1. Select multiple images in the main content area
2. Right-click and select **Add Tags**
3. Enter tag names separated by commas
4. Click **Add** to apply the tags to all selected images

#### Adding Tags via Keyboard Shortcut:
1. Select one or more images
2. Press `Ctrl/Cmd + T` to open the tag dialog
3. Enter tag names separated by commas
4. Press `Enter` to apply the tags

### Managing Tags

#### Viewing Images with a Specific Tag
1. In the sidebar, navigate to the **Tags** view
2. Click on a tag to view all images with that tag
3. The main content area will display only images with the selected tag

#### Removing Tags from Images
1. Select an image in the main content area
2. In the details panel, find the **Tags** section
3. Hover over the tag you want to remove
4. Click the `×` button that appears next to the tag name

#### Removing Tags from Multiple Images
1. Select multiple images in the main content area
2. Right-click and select **Remove Tags**
3. Select the tags you want to remove
4. Click **Remove** to remove the tags from all selected images

#### Renaming Tags
1. In the sidebar, navigate to the **Tags** view
2. Right-click the tag you want to rename
3. Select **Rename Tag** from the context menu
4. Enter the new name
5. Press `Enter` to confirm
6. **Note**: This will rename the tag for all images that have it

#### Deleting Tags
1. In the sidebar, navigate to the **Tags** view
2. Right-click the tag you want to delete
3. Select **Delete Tag** from the context menu
4. Confirm the deletion in the dialog
5. **Note**: This will remove the tag from all images

#### Merging Tags
1. In the sidebar, navigate to the **Tags** view
2. Right-click the tag you want to merge
3. Select **Merge With** from the context menu
4. Select the tag you want to merge into
5. Click **Merge** to combine the tags
6. **Note**: All images with the original tag will now have the merged tag instead

### Tag Organization

#### Tag Cloud View
1. In the sidebar, navigate to the **Tags** view
2. Click the **Tag Cloud** button at the top of the sidebar
3. Tags are displayed in a visual cloud, with more frequently used tags appearing larger
4. Click a tag in the cloud to view all images with that tag

#### Sorting Tags
1. In the sidebar, navigate to the **Tags** view
2. Click the **Sort By** button at the top of the sidebar
3. Choose from:
   - **Name**: Sort tags alphabetically
   - **Usage**: Sort tags by how many images have them
   - **Creation Date**: Sort tags by when they were created

#### Tag Groups
1. In the sidebar, navigate to the **Tags** view
2. Click the **Tag Groups** button at the top of the sidebar
3. Create tag groups by clicking **+ Group**
4. Drag tags into groups to organize them
5. Tag groups help you manage large numbers of tags

## Smart Collections

Smart collections are automatically generated collections of images based on specific criteria. They update dynamically as your library changes.

### Default Smart Collections

The application includes several default smart collections:

- **All Images**: Displays all images in your library
- **Favorites**: Displays images marked as favorites
- **Recently Added**: Displays images added in the last 30 days
- **Recently Viewed**: Displays images viewed in the last 7 days
- **Untagged Images**: Displays images with no tags
- **For Deletion**: Displays images marked for deletion

### Creating Custom Smart Collections

#### Steps to Create a Custom Smart Collection:
1. In the sidebar, navigate to the **Smart Collections** view
2. Click the `+` button at the top of the sidebar
3. Enter a name for your smart collection
4. Configure the filter criteria:
   - **Text Search**: Images matching specific text in filename, tags, or metadata
   - **Date Range**: Images created or modified within a specific date range
   - **Dimensions**: Images with specific width and height
   - **Rating**: Images with a specific star rating
   - **Tags**: Images with specific tags
   - **AI Metadata**: Images with specific model, sampler, steps, etc.
5. Click **Save** to create the smart collection

### Managing Smart Collections

#### Editing Smart Collections
1. In the sidebar, right-click the smart collection you want to edit
2. Select **Edit Collection** from the context menu
3. Modify the filter criteria
4. Click **Save** to update the smart collection

#### Deleting Smart Collections
1. In the sidebar, right-click the smart collection you want to delete
2. Select **Delete Collection** from the context menu
3. Confirm the deletion in the dialog

#### Refreshing Smart Collections
1. In the sidebar, right-click a smart collection
2. Select **Refresh Collection** from the context menu
3. The smart collection will be updated with the latest images matching the criteria

## Best Practices for Organization

1. **Use a Consistent Naming Convention**: Use consistent naming for folders, albums, and tags
2. **Start Simple**: Begin with a basic organization structure and expand as needed
3. **Combine Methods**: Use folders for physical organization, albums for thematic organization, and tags for descriptive categorization
4. **Use Descriptive Tags**: Use specific, descriptive tags rather than generic ones
5. **Don't Over-Tag**: Use 5-10 relevant tags per image, not dozens
6. **Regularly Clean Up**: Remove unused tags and organize your library periodically
7. **Use Smart Collections**: Create smart collections for frequently used search criteria
8. **Backup Your Library**: Regularly backup your library database to preserve your organization structure

## Organization Workflow Examples

### Example 1: Organizing by Project
```
Folders:
└── AI Projects
    ├── Project A
    ├── Project B
    └── Project C

Albums:
├── Project A Final Images
├── Project A Sketches
├── Project B Final Images
└── Project B Sketches

Tags:
├── project-a
├── project-b
├── project-c
├── final
└── sketch
```

### Example 2: Organizing by AI Model
```
Folders:
└── AI Generated Images
    ├── Stable Diffusion
    ├── MidJourney
    └── DALL-E

Albums:
├── Landscapes
├── Portraits
├── Abstract
└── Characters

Tags:
├── stable-diffusion
├── midjourney
├── dall-e
├── landscape
├── portrait
├── abstract
└── character
```

## Troubleshooting Organization

### Tags Not Being Applied
- **Check Selection**: Ensure you have selected the correct images
- **Tag Name Format**: Avoid using commas in tag names (commas are used to separate multiple tags)
- **Permission Issues**: Ensure you have write access to the database

### Albums Not Showing Images
- **Check Album Filter**: Ensure you haven't applied a filter that's hiding images
- **Refresh Album**: Try refreshing the album to update its contents
- **Check Image Location**: Ensure the image files are still accessible

### Folders Not Updating
- **Check Watch Settings**: Ensure the folder is set to be watched for changes
- **Refresh Folder**: Manually refresh the folder to scan for changes
- **Check File System**: Ensure the folder still exists and you have access to it

## Next Steps

- Learn about [Metadata Editing](./metadata-editing.md) to view and edit AI metadata
- Explore [Search & Filtering](./search-filtering.md) to find images quickly
- Read about [Export & Sharing](./export-sharing.md) to share your organized images