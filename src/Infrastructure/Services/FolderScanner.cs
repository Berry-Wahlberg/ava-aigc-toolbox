using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AIGenManager.Core.Application.Ports;
using AIGenManager.Core.Domain.Entities;
using AIGenManager.Core.Domain.Services;

namespace AIGenManager.Infrastructure.Services;

/// <summary>
/// Service for scanning folders and extracting metadata from images
/// </summary>
public class FolderScanner : IFolderScanner
{
    private readonly IMetadataExtractionService _metadataExtractionService;
    private readonly IThumbnailGenerationService _thumbnailGenerationService;
    private readonly IImageRepository _imageRepository;
    private readonly IFolderRepository _folderRepository;

    /// <summary>
    /// Initializes a new instance of the FolderScanner service
    /// </summary>
    /// <param name="metadataExtractionService">Metadata extraction service</param>
    /// <param name="thumbnailGenerationService">Thumbnail generation service</param>
    /// <param name="imageRepository">Image repository</param>
    /// <param name="folderRepository">Folder repository</param>
    public FolderScanner(
        IMetadataExtractionService metadataExtractionService,
        IThumbnailGenerationService thumbnailGenerationService,
        IImageRepository imageRepository,
        IFolderRepository folderRepository)
    {
        _metadataExtractionService = metadataExtractionService;
        _thumbnailGenerationService = thumbnailGenerationService;
        _imageRepository = imageRepository;
        _folderRepository = folderRepository;
    }

    /// <summary>
    /// Scans a folder and extracts metadata from all supported image files
    /// </summary>
    /// <param name="folderPath">Path to scan</param>
    /// <param name="recursive">Whether to scan recursively</param>
    /// <returns>Number of images processed</returns>
    public async Task<int> ScanFolderAsync(string folderPath, bool recursive = true)
    {
        if (!Directory.Exists(folderPath))
        {
            throw new DirectoryNotFoundException($"Folder not found: {folderPath}");
        }

        var processedCount = 0;
        // Enhanced supported image formats including common formats
        var supportedImageExtensions = new[] { ".png", ".jpg", ".jpeg", ".webp", ".gif", ".bmp", ".tiff", ".tif", ".svg" };
        var supportedExtensions = supportedImageExtensions.Concat(new[] { ".txt", ".mp4" }).ToArray();

        // Get all image files
        var searchOption = recursive ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
        var imageFiles = Directory.EnumerateFiles(folderPath, "*.*", searchOption)
            .Where(file => supportedExtensions.Contains(Path.GetExtension(file).ToLower()))
            .ToList();

        // Process files in parallel for faster performance
        var processedResults = await Task.WhenAll(imageFiles.Select(file => ProcessImageFileAsync(file, folderPath)));
        processedCount = processedResults.Count(result => result);

        return processedCount;
    }

    /// <summary>
    /// Processes a single image file
    /// </summary>
    /// <param name="imagePath">Path to the image file</param>
    /// <param name="rootFolderPath">Root folder path</param>
    /// <returns>True if processing succeeded, false otherwise</returns>
    private async Task<bool> ProcessImageFileAsync(string imagePath, string rootFolderPath)
    {
        try
        {
            var fileInfo = new FileInfo(imagePath);
            var relativePath = Path.GetRelativePath(rootFolderPath, imagePath);

            // Check if file exists and is accessible
            if (!fileInfo.Exists || (fileInfo.Attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
            {
                return false;
            }

            // Check if image already exists in database
            var existingImages = await _imageRepository.GetAllAsync();
            if (existingImages.Any(img => img.Path == imagePath))
            {
                return false; // Image already processed
            }

            // Extract metadata using the enhanced service
            var metadataResult = await _metadataExtractionService.ExtractMetadataAsync(imagePath);

            // Generate thumbnail with improved error handling
            string thumbnailPath;
            try
            {
                thumbnailPath = await _thumbnailGenerationService.GenerateThumbnailAsync(imagePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error generating thumbnail for {imagePath}: {ex.Message}");
                // Provide empty string as fallback for failed thumbnails
                thumbnailPath = string.Empty;
            }

            // Create image entity
            var image = new Image(imagePath, fileInfo.Name)
            {
                FileSize = fileInfo.Length,
                CreatedDate = fileInfo.CreationTime,
                ModifiedDate = fileInfo.LastWriteTime,
                Width = metadataResult.Width ?? 0,
                Height = metadataResult.Height ?? 0,
                Prompt = metadataResult.Prompt,
                NegativePrompt = metadataResult.NegativePrompt,
                Model = metadataResult.Model,
                Sampler = metadataResult.Sampler,
                Steps = metadataResult.Steps ?? 0,
                CFGScale = metadataResult.CFGScale ?? 0,
                Seed = metadataResult.Seed ?? 0,
                NoMetadata = !metadataResult.Success || metadataResult.RequiresManualEntry,
                ThumbnailPath = thumbnailPath
            };

            // Save to database
            await _imageRepository.AddAsync(image);
            return true;
        }
        catch (IOException ex)
        {
            Console.WriteLine($"I/O error processing image {imagePath}: {ex.Message}");
        }
        catch (UnauthorizedAccessException ex)
        {
            Console.WriteLine($"Access denied processing image {imagePath}: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error processing image {imagePath}: {ex.Message}");
        }
        return false;
    }
}