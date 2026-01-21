namespace AIGenManager.Core.Domain.Services;

public interface IImageImportService
{
    Task<ImportResult> ImportImagesFromFolderAsync(string folderPath, bool recursive = true);
}

public class ImportResult
{
    public int TotalImages { get; set; }
    public int SuccessfullyImported { get; set; }
    public int FailedToImport { get; set; }
    public List<ImportError> Errors { get; set; } = new();
    public List<string> ImportedFilePaths { get; set; } = new();
}

public class ImportError
{
    public string FilePath { get; set; } = string.Empty;
    public string ErrorType { get; set; } = string.Empty;
    public string ErrorMessage { get; set; } = string.Empty;
}