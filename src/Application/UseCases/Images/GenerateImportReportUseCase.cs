using AIGenManager.Core.Domain.Services;

namespace AIGenManager.Application.UseCases.Images;

public class GenerateImportReportUseCase
{
    private readonly IImageImportService _imageImportService;

    public GenerateImportReportUseCase(IImageImportService imageImportService)
    {
        _imageImportService = imageImportService;
    }

    public Task<ImportResult> ExecuteAsync(ImportResult importResult)
    {
        return Task.FromResult(importResult);
    }
}

public class GetImportStatisticsUseCase
{
    public GetImportStatisticsUseCase() { }

    public Task<ImportStatistics> ExecuteAsync(ImportResult importResult)
    {
        var statistics = new ImportStatistics
        {
            TotalImages = importResult.TotalImages,
            SuccessfullyImported = importResult.SuccessfullyImported,
            FailedToImport = importResult.FailedToImport,
            MetadataExtractionFailures = importResult.Errors.Count(e => e.ErrorType == "MetadataExtraction"),
            UnsupportedFormatFailures = importResult.Errors.Count(e => e.ErrorType == "UnsupportedFormat"),
            OtherFailures = importResult.Errors.Count(e => e.ErrorType != "MetadataExtraction" && e.ErrorType != "UnsupportedFormat")
        };

        return Task.FromResult(statistics);
    }
}

public class ImportStatistics
{
    public int TotalImages { get; set; }
    public int SuccessfullyImported { get; set; }
    public int FailedToImport { get; set; }
    public int MetadataExtractionFailures { get; set; }
    public int UnsupportedFormatFailures { get; set; }
    public int OtherFailures { get; set; }
}