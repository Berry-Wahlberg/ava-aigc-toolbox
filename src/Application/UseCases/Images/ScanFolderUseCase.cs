using AIGenManager.Core.Domain.Entities;
using AIGenManager.Core.Domain.Services;

namespace AIGenManager.Application.UseCases.Images;

public class ScanFolderUseCase
{
    private readonly IImageImportService _imageImportService;

    public ScanFolderUseCase(IImageImportService imageImportService)
    {
        _imageImportService = imageImportService;
    }

    public Task<ImportResult> ExecuteAsync(string folderPath, bool recursive = true)
    {
        return _imageImportService.ImportImagesFromFolderAsync(folderPath, recursive);
    }
}