namespace AIGenManager.Core.Domain.Services;

public interface IMetadataExtractionService
{
    Task<MetadataExtractionResult> ExtractMetadataAsync(string imagePath);
}

public class MetadataExtractionResult
{
    public bool Success { get; set; }
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
    public string? ErrorMessage { get; set; }
    public bool RequiresManualEntry { get; set; }
}