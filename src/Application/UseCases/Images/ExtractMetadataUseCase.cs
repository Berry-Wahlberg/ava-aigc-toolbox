using AIGenManager.Core.Domain.Entities;
using AIGenManager.Core.Domain.Services;

namespace AIGenManager.Application.UseCases.Images;

public class ExtractMetadataUseCase
{
    private readonly IMetadataExtractionService _metadataExtractionService;

    public ExtractMetadataUseCase(IMetadataExtractionService metadataExtractionService)
    {
        _metadataExtractionService = metadataExtractionService;
    }

    public Task<MetadataExtractionResult> ExecuteAsync(string imagePath)
    {
        return _metadataExtractionService.ExtractMetadataAsync(imagePath);
    }
}