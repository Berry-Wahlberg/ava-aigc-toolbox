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
    private readonly HashSet<string> _supportedFormats = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
    {
        ".png", ".jpg", ".jpeg", ".webp", ".gif", ".bmp", ".tiff", ".tif"
    };

    /// <summary>
    /// Initializes a new instance of the ThumbnailGenerationService
    /// </summary>
    public ThumbnailGenerationService()
    {
        // Create cache directory in app data
        var appDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "BerryAIGCToolbox");
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

        // Check if file extension is supported
        var extension = Path.GetExtension(imagePath);
        if (!_supportedFormats.Contains(extension))
        {
            throw new NotSupportedException($"Image format not supported: {extension}");
        }

        // Create cache directory if needed
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

        // Generate thumbnail with enhanced error handling
        try
        {
            await Task.Run(() =>
            {
                using var originalImage = LoadImageSafe(imagePath);
                using var thumbnail = GenerateThumbnailImage(originalImage);
                thumbnail.Save(thumbnailPath, ImageFormat.Jpeg);
            });
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error generating thumbnail for {imagePath}: {ex.Message}");
            throw;
        }

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
        
        // 验证现有缩略图是否有效
        if (File.Exists(thumbnailPath))
        {
            var originalFileInfo = new FileInfo(imagePath);
            var thumbnailFileInfo = new FileInfo(thumbnailPath);
            
            // 检查缩略图是否比原图新
            if (thumbnailFileInfo.LastWriteTime >= originalFileInfo.LastWriteTime)
            {
                // 验证缩略图文件是否可读
                try
                {
                    using var stream = File.OpenRead(thumbnailPath);
                    return thumbnailPath;
                }
                catch
                {
                    // 缩略图损坏,重新生成
                    return await GenerateThumbnailAsync(imagePath);
                }
            }
        }
        
        return await GenerateThumbnailAsync(imagePath);
    }

    /// <inheritdoc/>
    public async Task ClearCacheAsync()
    {
        try
        {
            if (Directory.Exists(_cacheDirectory))
            {
                await Task.Run(() => Directory.Delete(_cacheDirectory, true));
                Directory.CreateDirectory(_cacheDirectory);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error clearing thumbnail cache: {ex.Message}");
        }
    }

    /// <inheritdoc/>
    public string GetCacheDirectory()
    {
        return _cacheDirectory;
    }

    /// <summary>
    /// Generates a unique path for the thumbnail based on the original image path and modification time
    /// </summary>
    /// <param name="imagePath">Path to the original image</param>
    /// <returns>Unique path for the thumbnail</returns>
    private string GetThumbnailPath(string imagePath)
    {
        var fileInfo = new FileInfo(imagePath);
        var contentToHash = $"{imagePath}_{fileInfo.LastWriteTimeUtc.Ticks}";
        
        // Generate a hash of the content
        using var sha256 = SHA256.Create();
        var hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(contentToHash));
        var hashString = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
        
        return Path.Combine(_cacheDirectory, $"{hashString}{THUMBNAIL_EXTENSION}");
    }

    /// <summary>
    /// Loads an image safely with error handling
    /// </summary>
    /// <param name="imagePath">Path to the image file</param>
    /// <returns>Loaded image</returns>
    private Image LoadImageSafe(string imagePath)
    {
        using var stream = new FileStream(imagePath, FileMode.Open, FileAccess.Read, FileShare.Read);
        return Image.FromStream(stream, true, true);
    }

    /// <summary>
    /// Generates a thumbnail image from the original image
    /// </summary>
    /// <param name="originalImage">Original image to generate thumbnail from</param>
    /// <returns>Thumbnail image</returns>
    private Image GenerateThumbnailImage(Image originalImage)
    {
        // Calculate aspect ratio preserving dimensions
        var width = originalImage.Width;
        var height = originalImage.Height;
        var ratio = (double)width / height;
        
        int thumbnailWidth, thumbnailHeight;
        if (ratio > 1)
        {
            // Landscape
            thumbnailWidth = THUMBNAIL_SIZE;
            thumbnailHeight = (int)(THUMBNAIL_SIZE / ratio);
        }
        else
        {
            // Portrait or square
            thumbnailHeight = THUMBNAIL_SIZE;
            thumbnailWidth = (int)(THUMBNAIL_SIZE * ratio);
        }
        
        // Create thumbnail with high quality
        var thumbnail = new Bitmap(thumbnailWidth, thumbnailHeight);
        using var graphics = Graphics.FromImage(thumbnail);
        graphics.CompositingQuality = CompositingQuality.HighQuality;
        graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
        graphics.SmoothingMode = SmoothingMode.HighQuality;
        
        // Draw the image
        graphics.DrawImage(originalImage, 0, 0, thumbnailWidth, thumbnailHeight);
        
        return thumbnail;
    }

    /// <summary>
    /// 清理无效的缩略图文件
    /// </summary>
    public async Task CleanupInvalidThumbnailsAsync()
    {
        if (!Directory.Exists(_cacheDirectory))
        {
            return;
        }
        
        await Task.Run(() =>
        {
            try
            {
                var thumbnailFiles = Directory.GetFiles(_cacheDirectory, "*.jpg");
                
                foreach (var thumbnailFile in thumbnailFiles)
                {
                    try
                    {
                        // 验证缩略图文件是否可读
                        using var stream = File.OpenRead(thumbnailFile);
                    }
                    catch
                    {
                        // 缩略图损坏,删除它
                        try
                        {
                            File.Delete(thumbnailFile);
                            Console.WriteLine($"Deleted invalid thumbnail: {thumbnailFile}");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error deleting thumbnail {thumbnailFile}: {ex.Message}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error cleaning up thumbnails: {ex.Message}");
            }
        });
    }

    /// <summary>
    /// 验证缩略图文件是否有效
    /// </summary>
    /// <param name="thumbnailPath">缩略图文件路径</param>
    /// <returns>如果缩略图有效返回true,否则返回false</returns>
    public bool IsThumbnailValid(string thumbnailPath)
    {
        if (!File.Exists(thumbnailPath))
        {
            return false;
        }
        
        try
        {
            using var stream = File.OpenRead(thumbnailPath);
            return true;
        }
        catch
        {
            return false;
        }
    }
}