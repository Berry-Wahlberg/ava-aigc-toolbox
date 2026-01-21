using AIGenManager.Core.Application.Ports;
using System.Threading.Tasks;

namespace AIGenManager.Application.UseCases.Folders;

/// <summary>
/// Request for scanning a folder
/// </summary>
public record ScanFolderRequest(string FolderPath, bool Recursive = true);

/// <summary>
/// Use case for scanning folders and extracting image metadata
/// </summary>
public class ScanFolderUseCase : UseCase<ScanFolderRequest, int>
{
    private readonly IFolderScanner _folderScanner;

    /// <summary>
    /// Initializes a new instance of the ScanFolderUseCase
    /// </summary>
    /// <param name="folderScanner">Folder scanner service</param>
    public ScanFolderUseCase(IFolderScanner folderScanner)
    {
        _folderScanner = folderScanner;
    }

    /// <summary>
    /// Executes the folder scanning use case
    /// </summary>
    /// <param name="request">Scan folder request</param>
    /// <returns>Number of images processed</returns>
    public override async Task<int> ExecuteAsync(ScanFolderRequest request)
    {
        return await _folderScanner.ScanFolderAsync(request.FolderPath, request.Recursive);
    }
}