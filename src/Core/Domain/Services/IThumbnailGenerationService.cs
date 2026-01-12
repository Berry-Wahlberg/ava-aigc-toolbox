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
}
