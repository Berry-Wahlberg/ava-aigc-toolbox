using AIGenManager.Core.Domain.Services;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Collections.Concurrent;
using System.Collections.Generic;

// 为SixLabors.ImageSharp.Image添加别名，避免与实体类Image冲突
using ImageSharpImage = SixLabors.ImageSharp.Image;

namespace AIGenManager.Infrastructure.Services;

/// <summary>
/// Service for generating and caching image thumbnails
/// </summary>
public class ThumbnailGenerationService : IThumbnailGenerationService
{
    private const int THUMBNAIL_SIZE = 256;
    private const string THUMBNAIL_EXTENSION = ".jpg";
    private const long MAX_CACHE_SIZE = 1024 * 1024 * 1024; // 1 GB
    private const int MAX_CACHE_ITEMS = 10000; // 最大缓存项数
    
    private readonly string _cacheDirectory;
    private readonly HashSet<string> _supportedFormats = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
    {
        ".png", ".jpg", ".jpeg", ".webp", ".gif", ".bmp", ".tiff", ".tif"
    };
    
    // LRU缓存：使用ConcurrentDictionary存储缓存项，使用LinkedList维护访问顺序
    private readonly ConcurrentDictionary<string, (string ThumbnailPath, LinkedListNode<string> Node)> _thumbnailCache;
    private readonly LinkedList<string> _lruList;
    private readonly object _cacheLock = new object();
    private long _currentCacheSize = 0;

    /// <summary>
    /// Initializes a new instance of the ThumbnailGenerationService
    /// </summary>
    public ThumbnailGenerationService()
    {
        // Create cache directory in app data
        var appDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "BerryAIGCToolbox");
        _cacheDirectory = Path.Combine(appDataPath, "Thumbnails");
        Directory.CreateDirectory(_cacheDirectory);
        
        // Initialize LRU cache
        _thumbnailCache = new ConcurrentDictionary<string, (string ThumbnailPath, LinkedListNode<string> Node)>();
        _lruList = new LinkedList<string>();
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
            await Task.Run(async () =>
            {
                using var originalImage = LoadImageSafe(imagePath);
                using var thumbnail = GenerateThumbnailImage(originalImage);
                await thumbnail.SaveAsJpegAsync(thumbnailPath);
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

        // 生成缓存键：使用图片路径和修改时间的组合
        var originalFileInfo = new FileInfo(imagePath);
        var cacheKey = $"{imagePath}_{originalFileInfo.LastWriteTimeUtc.Ticks}";
        
        // 检查缓存
        if (_thumbnailCache.TryGetValue(cacheKey, out var cacheItem))
        {
            // 验证缩略图文件是否仍存在且有效
            if (File.Exists(cacheItem.ThumbnailPath))
            {
                // 将访问的项移到LRU列表末尾（表示最近使用）
                lock (_cacheLock)
                {
                    _lruList.Remove(cacheItem.Node);
                    _lruList.AddLast(cacheItem.Node);
                }
                return cacheItem.ThumbnailPath;
            }
            else
            {
                // 缩略图文件不存在，从缓存中移除
                _thumbnailCache.TryRemove(cacheKey, out _);
            }
        }

        var thumbnailPath = GetThumbnailPath(imagePath);
        
        // 验证现有缩略图是否有效
        if (File.Exists(thumbnailPath))
        {
            // 检查缩略图是否比原图新
            if (new FileInfo(thumbnailPath).LastWriteTime >= originalFileInfo.LastWriteTime)
            {
                // 验证缩略图文件是否可读
                try
                {
                    using var stream = File.OpenRead(thumbnailPath);
                    // 添加到缓存
                    AddToCache(cacheKey, thumbnailPath);
                    return thumbnailPath;
                }
                catch
                {
                    // 缩略图损坏,重新生成
                    return await GenerateAndCacheThumbnail(imagePath, cacheKey);
                }
            }
        }
        
        // 生成新的缩略图
        return await GenerateAndCacheThumbnail(imagePath, cacheKey);
    }
    
    /// <summary>
    /// 生成缩略图并添加到缓存
    /// </summary>
    private async Task<string> GenerateAndCacheThumbnail(string imagePath, string cacheKey)
    {
        var thumbnailPath = await GenerateThumbnailAsync(imagePath);
        if (!string.IsNullOrEmpty(thumbnailPath))
        {
            AddToCache(cacheKey, thumbnailPath);
        }
        return thumbnailPath;
    }
    
    /// <summary>
    /// 添加到LRU缓存
    /// </summary>
    private void AddToCache(string cacheKey, string thumbnailPath)
    {
        lock (_cacheLock)
        {
            // 检查是否已存在于缓存中
            if (_thumbnailCache.TryGetValue(cacheKey, out var existingItem))
            {
                // 更新现有项
                _lruList.Remove(existingItem.Node);
            }
            else
            {
                // 检查缓存大小是否超过限制
                if (_thumbnailCache.Count >= MAX_CACHE_ITEMS)
                {
                    // 移除最久未使用的项
                    RemoveLeastRecentlyUsed();
                }
            }
            
            // 添加或更新到缓存
            var node = _lruList.AddLast(cacheKey);
            _thumbnailCache[cacheKey] = (thumbnailPath, node);
        }
    }
    
    /// <summary>
    /// 移除最久未使用的缓存项
    /// </summary>
    private void RemoveLeastRecentlyUsed()
    {
        if (_lruList.First != null)
        {
            var lruKey = _lruList.First.Value;
            _lruList.RemoveFirst();
            _thumbnailCache.TryRemove(lruKey, out _);
        }
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
    private ImageSharpImage LoadImageSafe(string imagePath)
    {
        using var stream = new FileStream(imagePath, FileMode.Open, FileAccess.Read, FileShare.Read);
        return ImageSharpImage.Load(stream);
    }
    
    /// <summary>
    /// Generates a thumbnail image from the original image
    /// </summary>
    /// <param name="originalImage">Original image to generate thumbnail from</param>
    /// <returns>Thumbnail image</returns>
    private ImageSharpImage GenerateThumbnailImage(ImageSharpImage originalImage)
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
        var thumbnail = originalImage.Clone(ctx => ctx.Resize(thumbnailWidth, thumbnailHeight));
        
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