using AIGenManager.Core.Domain.Services;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace AIGenManager.Infrastructure.Services;

/// <summary>
/// Service for generating and caching image thumbnails
/// </summary>
public class ThumbnailGenerationService : IThumbnailGenerationService
{
    private const int THUMBNAIL_SIZE = 256;
    private const string THUMBNAIL_EXTENSION = ".jpg";
    private const long MAX_CACHE_SIZE = 1024 * 1024 * 1024; // 1 GB
    
    private readonly string _cacheDirectory;

    /// <summary>
    /// Initializes a new instance of the ThumbnailGenerationService
    /// </summary>
    public ThumbnailGenerationService()
    {
        // Create cache directory in app data
        var appDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "AIGenManager");
        _cacheDirectory = Path.Combine(appDataPath, "Thumbnails");
        Directory.CreateDirectory(_cacheDirectory);
    }

    /// <inheritdoc/>
    public async Task<string> GenerateThumbnailAsync(string imagePath)
    {
        if (!File.Exists(imagePath))
        {
            throw new FileNotFoundException($"Image file not found: {imagePath}");
        }

        // Create cache subdirectory if needed
        await Task.Run(() => Directory.CreateDirectory(_cacheDirectory));

        // Generate unique filename based on image path and modification time
        var thumbnailPath = GetThumbnailPath(imagePath);

        // Check if thumbnail already exists and is newer than the original file
        if (File.Exists(thumbnailPath))
        {
            var originalFileInfo = new FileInfo(imagePath);
            var thumbnailFileInfo = new FileInfo(thumbnailPath);
            
            if (thumbnailFileInfo.LastWriteTime >= originalFileInfo.LastWriteTime)
            {
                return thumbnailPath;
            }
        }

        // Generate thumbnail
        await Task.Run(() =>
        {
            using var originalImage = Image.FromFile(imagePath);
            using var thumbnail = GenerateThumbnailImage(originalImage);
            thumbnail.Save(thumbnailPath, ImageFormat.Jpeg);
        });

        // Cleanup cache if it exceeds maximum size
        await CleanupCacheAsync();

        return thumbnailPath;
    }

    /// <inheritdoc/>
    public async Task<string> GetOrGenerateThumbnailAsync(string imagePath)
    {
        if (!File.Exists(imagePath))
        {
            return string.Empty;
        }

        var thumbnailPath = GetThumbnailPath(imagePath);
        
        if (File.Exists(thumbnailPath))
        {
            var originalFileInfo = new FileInfo(imagePath);
            var thumbnailFileInfo = new FileInfo(thumbnailPath);
            
            if (thumbnailFileInfo.LastWriteTime >= originalFileInfo.LastWriteTime)
            {
                return thumbnailPath;
            }
        }

        return await GenerateThumbnailAsync(imagePath);
    }

    /// <inheritdoc/>
    public async Task ClearCacheAsync()
    {
        await Task.Run(() =>
        {
            if (Directory.Exists(_cacheDirectory))
            {
                var files = Directory.GetFiles(_cacheDirectory);
                foreach (var file in files)
                {
                    File.Delete(file);
                }
            }
        });
    }

    /// <inheritdoc/>
    public string GetCacheDirectory()
    {
        return _cacheDirectory;
    }

    /// <summary>
    /// Generates a thumbnail image from the original
    /// </summary>
    /// <param name="originalImage">Original image</param>
    /// <returns>Thumbnail image</returns>
    private Image GenerateThumbnailImage(Image originalImage)
    {
        var width = originalImage.Width;
        var height = originalImage.Height;

        // Calculate aspect ratio
        if (width > height)
        {
            height = (int)(height * ((double)THUMBNAIL_SIZE / width));
            width = THUMBNAIL_SIZE;
        }
        else
        {
            width = (int)(width * ((double)THUMBNAIL_SIZE / height));
            height = THUMBNAIL_SIZE;
        }

        // Create thumbnail bitmap
        var thumbnail = new Bitmap(THUMBNAIL_SIZE, THUMBNAIL_SIZE);
        thumbnail.SetResolution(72, 72);

        // Draw original image onto thumbnail with padding
        using var graphics = Graphics.FromImage(thumbnail);
        graphics.Clear(Color.Black);
        graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
        graphics.SmoothingMode = SmoothingMode.HighQuality;
        graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

        // Calculate padding to center the image
        var x = (THUMBNAIL_SIZE - width) / 2;
        var y = (THUMBNAIL_SIZE - height) / 2;

        graphics.DrawImage(originalImage, x, y, width, height);

        return thumbnail;
    }

    /// <summary>
    /// Generates a unique thumbnail path based on the original image path
    /// </summary>
    /// <param name="imagePath">Original image path</param>
    /// <returns>Thumbnail path</returns>
    private string GetThumbnailPath(string imagePath)
    {
        // Generate SHA256 hash of the image path to create a unique filename
        using var sha256 = SHA256.Create();
        var bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(imagePath));
        var hash = BitConverter.ToString(bytes).Replace("-", "").ToLower();
        
        return Path.Combine(_cacheDirectory, $"{hash}{THUMBNAIL_EXTENSION}");
    }

    /// <summary>
    /// Cleans up the cache if it exceeds the maximum size
    /// </summary>
    private async Task CleanupCacheAsync()
    {
        await Task.Run(() =>
        {
            var files = Directory.GetFiles(_cacheDirectory)
                .Select(file => new FileInfo(file))
                .OrderBy(f => f.LastWriteTime)
                .ToList();

            long totalSize = files.Sum(f => f.Length);

            // Delete oldest files until cache size is under the limit
            foreach (var file in files)
            {
                if (totalSize <= MAX_CACHE_SIZE)
                    break;

                totalSize -= file.Length;
                File.Delete(file.FullName);
            }
        });
    }
}
