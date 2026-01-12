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
        var supportedExtensions = new[] { ".png", ".jpg", ".jpeg", ".webp", ".txt", ".mp4" };

        // Get all image files
        var searchOption = recursive ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
        var imageFiles = Directory.EnumerateFiles(folderPath, "*.*", searchOption)
            .Where(file => supportedExtensions.Contains(Path.GetExtension(file).ToLower()))
            .ToList();

        foreach (var imageFile in imageFiles)
        {
            await ProcessImageFileAsync(imageFile, folderPath);
            processedCount++;
        }

        return processedCount;
    }

    /// <summary>
    /// Processes a single image file
    /// </summary>
    /// <param name="imagePath">Path to the image file</param>
    /// <param name="rootFolderPath">Root folder path</param>
    private async Task ProcessImageFileAsync(string imagePath, string rootFolderPath)
    {
        try
        {
            var fileInfo = new FileInfo(imagePath);
            var relativePath = Path.GetRelativePath(rootFolderPath, imagePath);

            // Check if image already exists in database
            var existingImages = await _imageRepository.GetAllAsync();
            if (existingImages.Any(img => img.Path == imagePath))
            {
                return; // Image already processed
            }

            // Extract metadata using the enhanced service
            var metadataResult = await _metadataExtractionService.ExtractMetadataAsync(imagePath);

            // Generate thumbnail
            var thumbnailPath = await _thumbnailGenerationService.GenerateThumbnailAsync(imagePath);

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
        }
        catch (Exception ex)
        {
            // Log error (implement proper logging later)
            Console.WriteLine($"Error processing image {imagePath}: {ex.Message}");
        }
    }


}