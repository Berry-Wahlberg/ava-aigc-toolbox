namespace AIGenManager.Core.Domain.Services;

/// <summary>
/// Service for generating and caching image thumbnails
/// </summary>
public interface IThumbnailGenerationService
{
    /// <summary>
    /// Generates a thumbnail for the given image file
    /// </summary>
    /// <param name="imagePath">Path to the original image</param>
    /// <returns>Path to the generated thumbnail</returns>
    Task<string> GenerateThumbnailAsync(string imagePath);

    /// <summary>
    /// Gets the path to a thumbnail for the given image file, generating it if necessary
    /// </summary>
    /// <param name="imagePath">Path to the original image</param>
    /// <returns>Path to the thumbnail</returns>
    Task<string> GetOrGenerateThumbnailAsync(string imagePath);

    /// <summary>
    /// Clears the thumbnail cache
    /// </summary>
    Task ClearCacheAsync();

    /// <summary>
    /// Gets the thumbnail cache directory path
    /// </summary>
    string GetCacheDirectory();

    /// <summary>
    /// 清理无效的缩略图文件
    /// </summary>
    Task CleanupInvalidThumbnailsAsync();

    /// <summary>
    /// 验证缩略图文件是否有效
    /// </summary>
    /// <param name="thumbnailPath">缩略图文件路径</param>
    /// <returns>如果缩略图有效返回true,否则返回false</returns>
    bool IsThumbnailValid(string thumbnailPath);
}
