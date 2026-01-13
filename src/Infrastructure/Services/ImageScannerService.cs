using AIGenManager.Core.Domain.Entities;
using AIGenManager.Core.Domain.Services;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using System.Collections.Concurrent;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

// 为实体类Image和ImageSharp.Image添加别名，避免冲突
using DomainImage = AIGenManager.Core.Domain.Entities.Image;
using ImageSharpImage = SixLabors.ImageSharp.Image;

namespace AIGenManager.Infrastructure.Services;

/// <summary>
/// 图片扫描服务实现
/// </summary>
public class ImageScannerService : IImageScannerService
{
    // 支持的图片格式
    private readonly HashSet<string> _supportedImageExtensions = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
    {
        ".jpg", ".jpeg", ".png", ".gif", ".bmp", ".webp", ".tiff", ".tif"
    };
    
    // 缩略图缓存
    private readonly ConcurrentDictionary<string, (byte[] Data, DateTime LastAccess)> _thumbnailCache;
    
    // 缓存大小限制（默认1000个）
    private const int MaxCacheSize = 1000;
    
    // 取消令牌源
    private CancellationTokenSource? _cts;
    
    public ImageScannerService()
    {
        _thumbnailCache = new ConcurrentDictionary<string, (byte[], DateTime)>();
    }
    
    /// <inheritdoc/>
    public async Task<IEnumerable<DomainImage>> ScanImagesAsync(string directoryPath, bool includeSubdirectories = true)
    {
        if (!Directory.Exists(directoryPath))
        {
            throw new DirectoryNotFoundException($"Directory not found: {directoryPath}");
        }
        
        _cts = new CancellationTokenSource();
        var cancellationToken = _cts.Token;
        
        try
        {
            // 使用Directory.EnumerateFiles异步扫描文件
            var filePaths = Directory.EnumerateFiles(directoryPath, "*.*", 
                includeSubdirectories ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly)
                .Where(file => _supportedImageExtensions.Contains(Path.GetExtension(file)))
                .ToList();
            
            var images = new ConcurrentBag<DomainImage>();
            
            // 并行处理图片文件
            await Parallel.ForEachAsync(filePaths, cancellationToken, async (filePath, ct) =>
            {
                ct.ThrowIfCancellationRequested();
                
                try
                {
                    // 创建Image实体
                    var fileInfo = new FileInfo(filePath);
                    var image = new DomainImage(filePath, fileInfo.Name)
                    {
                        FileSize = fileInfo.Length,
                        CreatedDate = fileInfo.CreationTime,
                        ModifiedDate = fileInfo.LastWriteTime
                    };
                    
                    // 异步获取图片尺寸
                    await using var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read);
                    using var imageSharpImage = await ImageSharpImage.LoadAsync(stream, ct);
                    
                    image.Width = imageSharpImage.Width;
                    image.Height = imageSharpImage.Height;
                    
                    images.Add(image);
                }
                catch (Exception ex)
                {
                    // 记录错误但不中断扫描
                    Console.WriteLine($"Error processing file {filePath}: {ex.Message}");
                }
            });
            
            return images;
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("Image scan operation was canceled.");
            return Enumerable.Empty<DomainImage>();
        }
        finally
        {
            _cts.Dispose();
            _cts = null;
        }
    }
    
    /// <inheritdoc/>
    public async Task<MemoryStream> GetThumbnailAsync(string imagePath, int thumbnailSize = 200)
    {
        if (!File.Exists(imagePath))
        {
            throw new FileNotFoundException($"Image file not found: {imagePath}");
        }
        
        // 生成缓存键
        var cacheKey = $"{imagePath}_{thumbnailSize}";
        
        // 检查缓存
        if (_thumbnailCache.TryGetValue(cacheKey, out var cachedThumbnail))
        {
            // 更新最后访问时间
            _thumbnailCache[cacheKey] = (cachedThumbnail.Data, DateTime.Now);
            
            // 返回缓存的缩略图
            return new MemoryStream(cachedThumbnail.Data);
        }
        
        // 生成新的缩略图
        await using var stream = new FileStream(imagePath, FileMode.Open, FileAccess.Read, FileShare.Read);
        using var image = await ImageSharpImage.LoadAsync(stream);
        
        // 计算缩放尺寸，保持比例
        var (newWidth, newHeight) = CalculateThumbnailSize(image.Width, image.Height, thumbnailSize);
        
        // 调整图片大小
        image.Mutate(x => x.Resize(newWidth, newHeight));
        
        // 保存到内存流
        var thumbnailStream = new MemoryStream();
        await image.SaveAsJpegAsync(thumbnailStream);
        
        // 重置流位置
        thumbnailStream.Position = 0;
        
        // 将缩略图数据保存到缓存
        var thumbnailData = thumbnailStream.ToArray();
        _thumbnailCache[cacheKey] = (thumbnailData, DateTime.Now);
        
        // 清理缓存，使用LRU算法
        if (_thumbnailCache.Count > MaxCacheSize)
        {
            // 找到最旧的缓存项
            var oldestCacheKey = _thumbnailCache.OrderBy(kv => kv.Value.LastAccess).First().Key;
            _thumbnailCache.TryRemove(oldestCacheKey, out _);
        }
        
        // 返回缩略图流的副本
        return new MemoryStream(thumbnailData);
    }
    
    /// <inheritdoc/>
    public void CancelScan()
    {
        _cts?.Cancel();
    }
    
    /// <summary>
    /// 计算缩略图尺寸，保持宽高比
    /// </summary>
    /// <param name="originalWidth">原始宽度</param>
    /// <param name="originalHeight">原始高度</param>
    /// <param name="maxSize">最大尺寸</param>
    /// <returns>缩略图尺寸</returns>
    private (int Width, int Height) CalculateThumbnailSize(int originalWidth, int originalHeight, int maxSize)
    {
        if (originalWidth <= maxSize && originalHeight <= maxSize)
        {
            return (originalWidth, originalHeight);
        }
        
        double aspectRatio = (double)originalWidth / originalHeight;
        
        if (aspectRatio > 1)
        {
            // 横向图片
            return (maxSize, (int)(maxSize / aspectRatio));
        }
        else
        {
            // 纵向图片
            return ((int)(maxSize * aspectRatio), maxSize);
        }
    }
}