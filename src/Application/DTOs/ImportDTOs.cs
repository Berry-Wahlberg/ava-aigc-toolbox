namespace AIGenManager.Application.DTOs;

public class ImportRequestDTO
{
    public string FolderPath { get; set; } = string.Empty;
    public bool Recursive { get; set; } = true;
    public bool IncludeSubfolders { get; set; } = true;
    public string[]? SupportedExtensions { get; set; }
}

public class ImportResultDTO
{
    public int TotalImages { get; set; }
    public int SuccessfullyImported { get; set; }
    public int FailedToImport { get; set; }
    public List<ImportErrorDTO> Errors { get; set; } = new();
    public List<string> ImportedFilePaths { get; set; } = new();
    public List<ImportedImageDTO> ImportedImages { get; set; } = new();
}

public class ImportErrorDTO
{
    public string FilePath { get; set; } = string.Empty;
    public string ErrorType { get; set; } = string.Empty;
    public string ErrorMessage { get; set; } = string.Empty;
}

public class ImportedImageDTO
{
    public int ImageId { get; set; }
    public string FilePath { get; set; } = string.Empty;
    public string FileName { get; set; } = string.Empty;
    public bool MetadataExtracted { get; set; }
    public bool RequiresManualEntry { get; set; }
}

public class MetadataDTO
{
    public string? Prompt { get; set; }
    public string? NegativePrompt { get; set; }
    public int? Steps { get; set; }
    public string? Sampler { get; set; }
    public decimal? CFGScale { get; set; }
    public long? Seed { get; set; }
    public int? Width { get; set; }
    public int? Height { get; set; }
    public string? ModelName { get; set; }
    public string? ModelHash { get; set; }
}