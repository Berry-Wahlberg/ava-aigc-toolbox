# Metadata Editing
\n> **La version anglaise prévaut**\n\n
The AVA AIGC Toolbox automatically extracts and displays AI-generated metadata from your images, and allows you to view, edit, and manage this metadata. This guide covers how to work with metadata in the application.

## What is AI Metadata?

AI-generated images often contain embedded metadata that provides information about how the image was created. This metadata typically includes:

- **Prompt**: The text prompt used to generate the image
- **Negative Prompt**: Text specifying what should be excluded from the image
- **Steps**: Number of generation steps used
- **Sampler**: The sampling method used (e.g., Euler, DDIM, LMS)
- **CFG Scale**: Classifier-free guidance scale
- **Seed**: Random seed used for generation
- **Model**: Name of the AI model used
- **Model Hash**: Unique identifier for the model
- **Width/Height**: Generated image dimensions
- **Clip Skip**: Number of CLIP layers to skip
- **Hypernetwork**: Hypernetwork used (if any)
- **Hypernetwork Strength**: Strength of the hypernetwork

## Viewing Metadata

### Image Details Panel

The primary way to view image metadata is through the details panel:

#### Steps to View Metadata:
1. Select an image in the main content area
2. The details panel will appear on the right side of the window
3. Scroll down to view all available metadata
4. Click on sections to expand or collapse them

### Metadata Sections

The metadata is organized into several sections:

- **Basic Information**: Filename, path, size, dimensions, and file attributes
- **AI Metadata**: Generation parameters like prompt, negative prompt, steps, etc.
- **Image Properties**: User-defined properties like rating, favorite status, and tags
- **Technical Details**: Color profile, bit depth, and other technical image information

### Full Metadata View

For a more comprehensive view of all metadata:

1. Select an image
2. Right-click and select **Properties**
3. Go to the **Metadata** tab
4. View all embedded and application-specific metadata
5. Click **Close** when finished

## Editing Metadata

### Basic Metadata Editing

You can edit most metadata fields directly in the details panel:

#### Steps to Edit Metadata:
1. Select an image in the main content area
2. In the details panel, find the metadata field you want to edit
3. Click on the field to make it editable
4. Enter the new value
5. Press `Enter` or click outside the field to save the changes

### AI Metadata Fields

The following AI metadata fields can be edited:

- **Prompt**
- **Negative Prompt**
- **Model**
- **Model Hash**
- **Sampler**
- **Steps**
- **CFG Scale**
- **Seed**
- **Width/Height**
- **Clip Skip**
- **Hypernetwork**
- **Hypernetwork Strength**

### Bulk Metadata Editing

You can edit metadata for multiple images at once:

#### Steps to Bulk Edit Metadata:
1. Select multiple images in the main content area
2. Right-click and select **Edit Metadata**
3. In the bulk edit dialog, select the metadata fields you want to edit
4. Enter the new values for each selected field
5. Choose how to apply the changes:
   - **Set**: Replace existing values with the new value
   - **Append**: Add the new value to existing values
   - **Prepend**: Insert the new value before existing values
6. Click **Apply** to save the changes to all selected images

### Advanced Metadata Editor

For more advanced metadata editing options:

1. Select one or more images
2. Go to `Tools > Metadata Editor`
3. In the advanced editor, you can:
   - View all metadata fields in a tabular format
   - Edit multiple fields at once
   - Copy metadata from one image to another
   - Import/export metadata to files
   - Batch process metadata for multiple images
4. Click **Save** to apply changes

## Metadata Extraction

### Automatic Extraction

The application automatically extracts metadata when importing images:

#### Steps to Enable Automatic Extraction:
1. Go to `Settings > Metadata > Extraction`
2. Check **Extract metadata when importing images**
3. Select which metadata fields to extract
4. Click **Save** to apply changes

### Manual Extraction

You can manually extract metadata from images:

#### Steps to Manually Extract Metadata:
1. Select one or more images
2. Right-click and select **Extract Metadata**
3. In the extraction dialog, select which metadata fields to extract
4. Click **Extract** to start the extraction process
5. Monitor progress in the dialog
6. Click **Finish** when done

### Supported Metadata Formats

The application supports extracting metadata from:

- **PNG files**: Embedded in text chunks
- **JPEG files**: Embedded in EXIF, IPTC, or XMP fields
- **WebP files**: Embedded in metadata sections
- **TIFF files**: Embedded in TIFF tags

### Common Metadata Formats

The application can extract metadata from common AI image generation tools:

- **Stable Diffusion**: Automatic1111 WebUI, InvokeAI, ComfyUI
- **MidJourney**: Direct downloads from MidJourney
- **DALL-E**: Direct downloads from DALL-E
- **Other Tools**: Any tool that embeds metadata in supported formats

## Metadata Export

### Embedding Metadata in Images

You can embed metadata back into image files:

#### Steps to Embed Metadata:
1. Select one or more images
2. Right-click and select **Embed Metadata**
3. In the embed dialog, select which metadata fields to embed
4. Choose embedding options:
   - **Overwrite existing metadata**: Replace existing metadata in files
   - **Preserve original files**: Create backups before embedding
5. Click **Embed** to start the process
6. Monitor progress in the dialog
7. Click **Finish** when done

### Exporting Metadata to Files

You can export metadata to external files:

#### Steps to Export Metadata:
1. Select one or more images
2. Go to `File > Export > Export Metadata`
3. Choose the export format:
   - **JSON**: Structured metadata in JSON format
   - **CSV**: Comma-separated values for spreadsheets
   - **TXT**: Plain text format
4. Select which metadata fields to export
5. Choose the destination folder
6. Click **Export** to save the metadata files

### Importing Metadata from Files

You can import metadata from external files:

#### Steps to Import Metadata:
1. Go to `File > Import > Import Metadata`
2. Select the metadata file to import
3. Map the imported fields to the application's metadata fields
4. Click **Import** to apply the metadata to matching images
5. Monitor progress in the dialog
6. Click **Finish** when done

## Metadata Templates

### Creating Metadata Templates

You can create templates for frequently used metadata values:

#### Steps to Create a Template:
1. Go to `Tools > Metadata Templates > Manage Templates`
2. Click **Add Template**
3. Enter a name for the template
4. Fill in the metadata fields you want to include in the template
5. Click **Save** to create the template

### Applying Templates

#### Applying Templates to Single Image:
1. Select an image
2. Go to `Tools > Metadata Templates > [Template Name]`
3. The template metadata will be applied to the image

#### Applying Templates to Multiple Images:
1. Select multiple images
2. Right-click and select **Apply Metadata Template**
3. Choose a template from the list
4. Click **Apply** to apply the template to all selected images

### Editing Templates

1. Go to `Tools > Metadata Templates > Manage Templates`
2. Select the template you want to edit
3. Click **Edit Template**
4. Modify the template fields
5. Click **Save** to update the template

### Deleting Templates

1. Go to `Tools > Metadata Templates > Manage Templates`
2. Select the template you want to delete
3. Click **Delete Template**
4. Confirm the deletion in the dialog

## Best Practices for Metadata Management

1. **Extract Metadata on Import**: Always extract metadata when importing new images
2. **Keep Metadata Updated**: Regularly update metadata for better searchability
3. **Use Descriptive Prompts**: Ensure prompts are descriptive and accurate for better organization
4. **Backup Metadata**: Export metadata periodically as a backup
5. **Use Templates**: Create templates for frequently used metadata values
6. **Embed Metadata Before Sharing**: Always embed metadata before sharing images with others
7. **Standardize Values**: Use consistent values for model names, samplers, etc.
8. **Don't Overwrite Original Files**: Always preserve original files when embedding metadata

## Troubleshooting Metadata Issues

### Metadata Not Extracting
- **Check File Format**: Ensure the image is in a supported format (PNG, JPEG, WebP, TIFF)
- **Check Metadata Format**: Verify that the metadata is embedded in a supported format
- **Corrupted Files**: Some files may have corrupted metadata - try re-generating the image
- **Unsupported Tool**: The tool used to generate the image may not embed metadata in a supported format

### Metadata Not Saving
- **Check File Permissions**: Ensure you have write access to the image files
- **Read-Only Files**: Some files may be read-only - check file properties
- **File Locked**: The file may be locked by another application
- **Unsupported Format**: Some formats may not support embedding certain metadata fields

### Incorrect Metadata Values
- **Manual Correction**: Edit the incorrect values directly in the details panel
- **Re-Extract**: Try re-extracting metadata from the image
- **Import Correct Metadata**: Import corrected metadata from a file

### Missing Metadata Fields
- **Custom Fields**: Some metadata fields may be custom to specific tools - they may not map directly to the application's fields
- **Update Application**: Ensure you're using the latest version of the application, which may support more metadata fields
- **Manual Mapping**: Use the advanced metadata editor to map custom fields to application fields

## Next Steps

- Explore [Search & Filtering](./search-filtering.md) to find images using metadata
- Read about [Export & Sharing](./export-sharing.md) to share images with metadata
- Learn about [AI Integration](../advanced-features/ai-integration.md) for more AI-powered features