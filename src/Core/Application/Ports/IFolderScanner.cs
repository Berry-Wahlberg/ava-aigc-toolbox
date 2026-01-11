using System.Threading.Tasks;

namespace AIGenManager.Core.Application.Ports;

/// <summary>
/// Interface for folder scanning functionality
/// </summary>
public interface IFolderScanner
{
    /// <summary>
    /// Scans a folder and extracts metadata from all supported image files
    /// </summary>
    /// <param name="folderPath">Path to scan</param>
    /// <param name="recursive">Whether to scan recursively</param>
    /// <returns>Number of images processed</returns>
    Task<int> ScanFolderAsync(string folderPath, bool recursive = true);
}