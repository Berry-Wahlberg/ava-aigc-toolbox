# Search & Filtering
\n> **La versión en inglés es la válida**\n\n
The AVA AIGC Toolbox provides powerful search and filtering capabilities to help you quickly find images in your library. This guide covers how to use these features effectively.

## Basic Search

### Search Bar

The search bar is located at the top of the main window and provides a quick way to search for images:

#### Steps to Perform a Basic Search:
1. Click in the search bar or press `Ctrl/Cmd + F` to focus on it
2. Type your search query
3. Results will appear automatically as you type
4. Press `Enter` to execute the search
5. Press `Esc` to clear the search

### Search Scope

By default, the search includes:
- Filenames
- Tags
- AI metadata (prompt, negative prompt, model, etc.)
- Image properties (rating, favorite status, etc.)

### Search Tips

- **Use quotes for exact phrases**: "futuristic city" will only match images containing that exact phrase
- **Use AND/OR operators**: "cat AND dog" will match images containing both words, "cat OR dog" will match images containing either word
- **Use NOT operator**: "cat NOT dog" will match images containing "cat" but not "dog"
- **Use wildcards**: "cat*" will match images containing words starting with "cat"

## Advanced Search

For more precise control over your search, use the advanced search dialog:

#### Steps to Open Advanced Search:
1. Click the **Advanced Search** button next to the search bar, or go to `Edit > Advanced Search`
2. The advanced search dialog will appear

### Advanced Search Options

The advanced search dialog allows you to create complex search queries using multiple criteria:

#### Text Search
- **Filename**: Search by filename or partial filename
- **Tags**: Search by tags
- **Prompt**: Search within the image prompt
- **Negative Prompt**: Search within the negative prompt
- **Model**: Search by model name or hash
- **Sampler**: Search by sampler name

#### Date Range
- **Created Date**: Search images created within a specific date range
- **Modified Date**: Search images modified within a specific date range
- **Added Date**: Search images added to the library within a specific date range

#### Image Properties
- **Rating**: Search by star rating (1-5 stars)
- **Favorite**: Search only favorite or non-favorite images
- **For Deletion**: Search images marked for deletion
- **NSFW**: Search NSFW or non-NSFW images
- **Unavailable**: Search unavailable images

#### Image Dimensions
- **Width**: Search images with specific width (in pixels)
- **Height**: Search images with specific height (in pixels)
- **Aspect Ratio**: Search images with specific aspect ratio
- **Orientation**: Search by orientation (portrait, landscape, square)

#### AI Metadata
- **Steps**: Search images with specific number of generation steps
- **CFG Scale**: Search images with specific CFG scale value
- **Seed**: Search images with specific seed value
- **Clip Skip**: Search images with specific clip skip value
- **Hypernetwork**: Search images using specific hypernetwork

### Saving Advanced Searches

You can save your advanced search criteria as a smart collection:

1. Configure your search criteria in the advanced search dialog
2. Click **Save as Smart Collection**
3. Enter a name for the smart collection
4. Click **Save**
5. The smart collection will appear in the sidebar under **Smart Collections**

## Filter Panel

The filter panel provides an interactive way to filter images based on various criteria:

#### Steps to Open the Filter Panel:
1. Click the **Filter** button in the toolbar, or go to `View > Toggle Filter Panel`
2. The filter panel will appear on the left side of the main content area

### Filter Categories

The filter panel is organized into several categories:

#### Quick Filters
- **All Images**: Show all images in the current view
- **Favorites**: Show only favorite images
- **Recently Added**: Show images added in the last 30 days
- **Untagged**: Show images with no tags
- **For Deletion**: Show images marked for deletion

#### Tags
- Shows all tags in your library
- Click a tag to filter by that tag
- Click multiple tags to filter by images that have all selected tags
- Use the search bar to find specific tags

#### AI Models
- Shows all AI models used in your images
- Click a model to filter by that model
- Shows the number of images for each model

#### Samplers
- Shows all samplers used in your images
- Click a sampler to filter by that sampler
- Shows the number of images for each sampler

#### Dimensions
- Filter by image orientation (portrait, landscape, square)
- Filter by minimum/maximum width and height

#### Rating
- Filter by star rating using a slider or checkboxes
- Select "No Rating" to show images without a rating

### Combining Filters

You can combine multiple filters to create precise searches:

1. Apply a filter from one category (e.g., select a tag)
2. Apply a filter from another category (e.g., select a model)
3. The results will show images that match all applied filters
4. Click a selected filter again to remove it
5. Click **Clear All** to remove all filters

## Sorting Options

You can sort your images to make them easier to browse:

#### Steps to Change Sorting:
1. Click the **Sort** button in the toolbar, or go to `View > Sort By`
2. Select a sorting option from the list
3. Click again to toggle between ascending and descending order

### Available Sorting Options

- **Name**: Sort by filename
- **Date Created**: Sort by image creation date
- **Date Modified**: Sort by image modification date
- **Date Added**: Sort by date added to the library
- **Size**: Sort by file size
- **Dimensions**: Sort by image dimensions
- **Rating**: Sort by star rating
- **Random**: Sort images randomly
- **Steps**: Sort by number of generation steps
- **CFG Scale**: Sort by CFG scale value
- **Seed**: Sort by seed value

## Smart Collections

Smart collections are automatically updated collections of images based on specific criteria. They're a great way to save frequently used searches and filters.

For more information about smart collections, see [Organization](./organization.md#smart-collections).

## Search History

The application keeps a history of your recent searches:

#### Steps to Access Search History:
1. Click the down arrow next to the search bar
2. A dropdown menu will appear showing recent searches
3. Click on a previous search to execute it again
4. Click **Clear History** to remove all previous searches

## Searching in Specific Views

You can perform searches within specific views:

### Search in Folders
1. Navigate to a folder in the sidebar
2. Perform a search
3. The search will be restricted to that folder and its subfolders

### Search in Albums
1. Navigate to an album in the sidebar
2. Perform a search
3. The search will be restricted to that album

### Search in Tags
1. Click on a tag in the sidebar
2. Perform a search
3. The search will be restricted to images with that tag

## Tips for Effective Searching

1. **Start with Basic Search**: Begin with a simple search query before moving to advanced search
2. **Use Specific Terms**: Be specific with your search terms for more accurate results
3. **Combine Filters**: Use multiple filters to narrow down results
4. **Save Useful Searches**: Save frequently used searches as smart collections
5. **Use Wildcards**: Use wildcards for broader searches
6. **Check Search Scope**: Be aware of the current search scope (all images, folder, album, etc.)
7. **Clear Filters**: Remember to clear filters when starting a new search
8. **Use Search History**: Reuse previous searches from the search history

## Troubleshooting Search Issues

### No Results Found
- **Check Search Query**: Ensure your search query is correct and not too specific
- **Check Search Scope**: Ensure you're searching in the correct view (all images, folder, album, etc.)
- **Check Filters**: Ensure no filters are restricting your results
- **Check Spelling**: Ensure your search terms are spelled correctly

### Too Many Results
- **Narrow Your Search**: Add more search terms or apply additional filters
- **Use More Specific Terms**: Use more specific terms to narrow down results
- **Use AND Operator**: Use "AND" to require multiple terms

### Unexpected Results
- **Check Search Options**: Ensure you're searching in the correct fields
- **Check Operator Usage**: Ensure you're using search operators correctly
- **Check Quote Usage**: Ensure you're using quotes for exact phrases correctly

### Slow Search Performance
- **Optimize Database**: Go to `Settings > Library > Optimize Database` to improve search performance
- **Reduce Search Scope**: Search within a specific folder or album instead of all images
- **Use Fewer Criteria**: Use fewer search criteria for faster results

## Next Steps

- Learn about [Export & Sharing](./export-sharing.md) to share your search results
- Read about [Organization](./organization.md) to better organize your images
- Explore [Metadata Editing](./metadata-editing.md) to improve searchability by updating metadata