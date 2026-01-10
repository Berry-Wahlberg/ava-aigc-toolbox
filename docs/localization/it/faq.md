# FAQ
\n> **La versione inglese è quella ufficiale**\n\n
This FAQ section answers common questions about the AVA AIGC Toolbox. If you don't find what you're looking for, please check the [Troubleshooting](./troubleshooting.md) guide or contact support.

## General Questions

### What is AVA AIGC Toolbox?
AVA AIGC Toolbox is a comprehensive tool for managing, organizing, and editing AI-generated images. It provides features like metadata extraction, auto-tagging, search functionality, and AI-powered image enhancement.

### Is AVA AIGC Toolbox free to use?
Yes, AVA AIGC Toolbox is an open-source project available for free under the MIT License.

### What platforms does AVA AIGC Toolbox support?
AVA AIGC Toolbox is built with Avalonia UI framework, which means it supports Windows, macOS, and Linux operating systems.

### What file formats are supported?
The application supports all common image formats including JPEG, PNG, WebP, BMP, TIFF, and AVIF. It also supports animated formats like GIF and WebP.

### How much storage space do I need?
The application itself requires minimal storage space (around 100MB). The actual storage requirements depend on the size of your image library and the cache settings you configure.

## Installation & Setup

### How do I install AVA AIGC Toolbox?
Refer to the [Installation](./installation.md) guide for detailed instructions on installing the application on your platform.

### What are the system requirements?
- **Operating System**: Windows 10+, macOS 10.15+, or Linux
- **Processor**: Intel Core i5 or equivalent
- **Memory**: 8GB RAM (16GB recommended)
- **Storage**: 500MB free space plus space for your image library
- **.NET 7.0 Runtime**: Required for running the application

### Can I run AVA AIGC Toolbox from a USB drive?
Yes, you can run the portable version of AVA AIGC Toolbox from a USB drive. Just download the portable ZIP file from the releases page and extract it to your USB drive.

### How do I update AVA AIGC Toolbox?
You can update the application either through the built-in update checker (in Settings > General > Update Checks) or by downloading the latest version from the project's GitHub page.

## Library Management

### What is an image library?
An image library is a collection of images organized within the AVA AIGC Toolbox. The application uses a SQLite database to store metadata about your images, while the actual image files remain in their original locations.

### Can I have multiple libraries?
Yes, you can create and switch between multiple libraries. To do this, go to `File > Open Library` or use the library selector in the welcome screen.

### How do I back up my library?
You can back up your library using the built-in backup feature. Go to `File > Backup Library` or configure automatic backups in `Settings > Library > Backup`.

### Can I move my library to another computer?
Yes, you can move your library by copying the library database file and ensuring all image files are accessible from the new location. You may need to update file paths if images are stored in different locations on the new computer.

## Image Import & Export

### How do I import images?
You can import images by clicking the `Import` button in the toolbar, dragging and dropping images into the application, or using the `File > Import` menu option.

### Why are some images not importing?
Common reasons include:
- The file format is not supported
- The file is corrupted
- You don't have read permissions for the file
- The file size exceeds the configured limit
- The file is already in the library

### How do I export images?
Select the images you want to export, then click the `Export` button in the toolbar or use the `File > Export` menu option.

### Can I export images with their metadata?
Yes, you can include metadata in your exports by enabling the "Include Metadata" option in the export dialog or in `Settings > Export > Defaults`.

## Metadata & Tagging

### What metadata is extracted from images?
The application extracts various metadata fields including:
- Basic information (file name, size, dimensions, format)
- EXIF data (camera settings, location, date taken)
- AI-generated metadata (prompt, model name, seed, steps, CFG scale, sampler)
- User-added metadata (tags, ratings, favorites, notes)

### How accurate is the auto-tagging feature?
The accuracy of auto-tagging depends on the AI model being used. We recommend reviewing auto-generated tags and making adjustments as needed. You can also customize the confidence threshold in `Settings > AI > Tag Models`.

### Can I edit metadata for multiple images at once?
Yes, you can edit metadata for multiple images simultaneously using the batch editing feature. Select multiple images, then edit the metadata in the details panel.

### Will editing metadata in AVA AIGC Toolbox modify my original files?
By default, the application stores metadata in its database and doesn't modify original files. However, you can choose to write metadata back to files when exporting or using the "Write Metadata to Files" option.

## AI Features

### Do I need an API key for AI features?
Some AI features (like certain auto-tagging models or image enhancement) may require an API key. You can configure API keys in `Settings > AI > API Integration`.

### Are AI features optional?
Yes, you can enable or disable AI features entirely in `Settings > AI > General`. Disabling AI features can improve performance if you don't need them.

### How does AI auto-tagging work?
AI auto-tagging uses machine learning models to analyze your images and generate relevant tags. The application supports various models, and you can configure the default model in settings.

### Can I use my own AI models?
Currently, the application supports a predefined set of AI models. Support for custom models may be added in future versions.

## Performance & Troubleshooting

### Why is the application running slowly?
Common reasons for slow performance include:
- Large library size (consider optimizing or splitting your library)
- Insufficient RAM (try increasing cache sizes in settings)
- High parallel processing settings (reduce in `Settings > Library > Performance`)
- Animations enabled (disable in `Settings > Interface`)

### How can I improve performance?
- Increase thumbnail and image cache sizes
- Enable lazy loading
- Reduce the number of parallel processes
- Disable animations
- Use a faster storage device for your library
- Keep your application updated

### Why are thumbnails not displaying correctly?
Try the following solutions:
- Clear the thumbnail cache (`File > Maintenance > Clear Thumbnail Cache`)
- Restart the application
- Check if the original image files are still accessible
- Re-import the affected images

### What should I do if the application crashes?
1. Check the log files (`Settings > Troubleshooting > Logging` for location)
2. Restart the application
3. Try opening a different library
4. Reset settings to default
5. If the issue persists, report the bug on GitHub with logs attached

## Advanced Questions

### Can I extend the application with plugins?
Currently, the application doesn't support plugins. However, this is a planned feature for future versions.

### Is the application safe to use with sensitive images?
Yes, all processing is done locally on your computer, and no images are sent to external servers unless you specifically use AI features that require API calls.

### How can I contribute to the project?
You can contribute by:
- Reporting bugs and suggesting features on GitHub
- Submitting pull requests
- Improving documentation
- Translating the application to other languages
- Testing pre-release versions

### Where is the application data stored?
Application data is stored in:
- **Windows**: `%APPDATA%/AIGenManager/`
- **macOS**: `~/.local/share/AIGenManager/`
- **Linux**: `~/.local/share/AIGenManager/`

This includes settings, logs, cache, and library databases.

## Next Steps

- Learn about [Settings](./settings.md) to configure the application to your needs
- Read about [Troubleshooting](./troubleshooting.md) for help with common issues
- Explore [Tips & Best Practices](./tips-best-practices.md) for more user tips