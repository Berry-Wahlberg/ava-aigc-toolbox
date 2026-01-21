using AIGenManager.Core.Domain.Entities;
using AIGenManager.Core.Domain.Services;
using System.IO;

namespace AIGenManager.Infrastructure.Services;

public class ImageImportService : IImageImportService
{
    private readonly FileSystemService _fileSystemService;
    private readonly IMetadataExtractionService _metadataExtractionService;

    public ImageImportService(FileSystemService fileSystemService, IMetadataExtractionService metadataExtractionService)
    {
        _fileSystemService = fileSystemService;
        _metadataExtractionService = metadataExtractionService;
    }

    public async Task<ImportResult> ImportImagesFromFolderAsync(string folderPath, bool recursive = true)
    {
        var result = new ImportResult();

        if (!Directory.Exists(folderPath))
        {
            result.Errors.Add(new ImportError
            {
                FilePath = folderPath,
                ErrorType = "FolderNotFound",
                ErrorMessage = "Folder does not exist"
            });
            return result;
        }

        try
        {
            var imageFiles = _fileSystemService.GetImageFiles(folderPath, recursive);
            result.TotalImages = imageFiles.Count;

            foreach (var imagePath in imageFiles)
            {
                try
                {
                    var fileName = Path.GetFileName(imagePath);
                    var relativePath = _fileSystemService.GetRelativePath(imagePath, folderPath);

                    var metadataResult = await _metadataExtractionService.ExtractMetadataAsync(imagePath);

                    var image = new Image(imagePath, fileName)
                    {
                        Path = relativePath,
                        FileName = fileName,
                        CreatedDate = File.GetCreationTime(imagePath),
                        ModifiedDate = File.GetLastWriteTime(imagePath),
                        FileSize = _fileSystemService.GetFileSize(imagePath)
                    };

                    if (metadataResult.Success)
                    {
                        image.Prompt = metadataResult.Prompt;
                        image.NegativePrompt = metadataResult.NegativePrompt;
                        image.Steps = metadataResult.Steps ?? 0;
                        image.Sampler = metadataResult.Sampler;
                        image.CFGScale = metadataResult.CFGScale ?? 7.0m;
                        image.Seed = metadataResult.Seed ?? -1;
                        image.Width = metadataResult.Width ?? 0;
                        image.Height = metadataResult.Height ?? 0;
                        image.Model = metadataResult.ModelName;
                        image.ModelHash = metadataResult.ModelHash;
                        image.NoMetadata = false;
                        image.ImportStatus = ImportStatus.Success;
                        result.SuccessfullyImported++;
                    }
                    else
                    {
                        image.NoMetadata = true;
                        image.ImportStatus = ImportStatus.RequiresManualEntry;
                        image.ImportErrorMessage = metadataResult.ErrorMessage;
                        image.ManualMetadataRequired = true;
                        result.FailedToImport++;

                        result.Errors.Add(new ImportError
                        {
                            FilePath = imagePath,
                            ErrorType = metadataResult.RequiresManualEntry ? "MetadataExtraction" : "Other",
                            ErrorMessage = metadataResult.ErrorMessage ?? "Unknown error"
                        });
                    }

                    result.ImportedFilePaths.Add(imagePath);
                }
                catch (Exception ex)
                {
                    result.FailedToImport++;
                    result.Errors.Add(new ImportError
                    {
                        FilePath = imagePath,
                            ErrorType = "ImportError",
                            ErrorMessage = ex.Message
                    });
                }
            }
        }
        catch (Exception ex)
        {
            result.Errors.Add(new ImportError
            {
                FilePath = folderPath,
                ErrorType = "SystemError",
                ErrorMessage = $"Import failed: {ex.Message}"
            });
        }

        return result;
    }
}