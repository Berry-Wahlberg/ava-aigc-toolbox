using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using AIGenManager.Application.UseCases.Images;
using AIGenManager.Infrastructure.Services;
using AIGenManager.Core.Domain.Services;

namespace AIGenManager.Infrastructure.Tests;

public class ImportUseCasesTests
{
    private readonly FileSystemService _fileSystemService;
    private readonly ImageImportService _imageImportService;

    public ImportUseCasesTests()
    {
        _fileSystemService = new FileSystemService();
        _imageImportService = new ImageImportService(_fileSystemService, new MockMetadataExtractionService());
    }

    [Fact]
    public async Task ImportImagesFromFolderAsync_ShouldReturnErrorForNonExistentFolder()
    {
        // Arrange
        var nonExistentPath = @"C:\NonExistentFolder\12345";

        // Act
        var result = await _imageImportService.ImportImagesFromFolderAsync(nonExistentPath, true);

        // Assert
        Assert.Equal(0, result.TotalImages);
        Assert.Equal(0, result.SuccessfullyImported);
        Assert.Equal(0, result.FailedToImport);
        Assert.Single(result.Errors);
        Assert.Equal("FolderNotFound", result.Errors[0].ErrorType);
    }

    [Fact]
    public async Task ImportImagesFromFolderAsync_ShouldImportAllImagesInFolder()
    {
        // Arrange
        var tempFolder = Path.Combine(Path.GetTempPath(), "TestImport_" + Guid.NewGuid());
        Directory.CreateDirectory(tempFolder);

        try
        {
            // Create test image files
            File.WriteAllText(Path.Combine(tempFolder, "image1.png"), "fake png 1");
            File.WriteAllText(Path.Combine(tempFolder, "image2.jpg"), "fake jpg 1");
            File.WriteAllText(Path.Combine(tempFolder, "image3.jpeg"), "fake jpeg 1");
            File.WriteAllText(Path.Combine(tempFolder, "notimage.txt"), "not an image");

            // Act
            var result = await _imageImportService.ImportImagesFromFolderAsync(tempFolder, false);

            // Assert
            Assert.Equal(3, result.TotalImages);
            Assert.Equal(3, result.SuccessfullyImported);
            Assert.Equal(0, result.FailedToImport);
            Assert.Empty(result.Errors);
            Assert.Equal(3, result.ImportedFilePaths.Count);
        }
        finally
        {
            Directory.Delete(tempFolder, true);
        }
    }

    [Fact]
    public async Task ImportImagesFromFolderAsync_ShouldImportFromSubfoldersWhenRecursive()
    {
        // Arrange
        var tempFolder = Path.Combine(Path.GetTempPath(), "TestImport_" + Guid.NewGuid());
        var subFolder = Path.Combine(tempFolder, "Subfolder");
        Directory.CreateDirectory(tempFolder);
        Directory.CreateDirectory(subFolder);

        try
        {
            // Create test files
            File.WriteAllText(Path.Combine(tempFolder, "root.png"), "root image");
            File.WriteAllText(Path.Combine(subFolder, "sub.png"), "sub image");

            // Act
            var result = await _imageImportService.ImportImagesFromFolderAsync(tempFolder, true);

            // Assert
            Assert.Equal(2, result.TotalImages);
            Assert.Equal(2, result.SuccessfullyImported);
            Assert.Equal(0, result.FailedToImport);
        }
        finally
        {
            Directory.Delete(tempFolder, true);
        }
    }

    [Fact]
    public async Task ImportImagesFromFolderAsync_ShouldNotImportFromSubfoldersWhenNotRecursive()
    {
        // Arrange
        var tempFolder = Path.Combine(Path.GetTempPath(), "TestImport_" + Guid.NewGuid());
        var subFolder = Path.Combine(tempFolder, "Subfolder");
        Directory.CreateDirectory(tempFolder);
        Directory.CreateDirectory(subFolder);

        try
        {
            // Create test files
            File.WriteAllText(Path.Combine(tempFolder, "root.png"), "root image");
            File.WriteAllText(Path.Combine(subFolder, "sub.png"), "sub image");

            // Act
            var result = await _imageImportService.ImportImagesFromFolderAsync(tempFolder, false);

            // Assert
            Assert.Equal(1, result.TotalImages);
            Assert.Equal(1, result.SuccessfullyImported);
            Assert.Equal(0, result.FailedToImport);
            Assert.EndsWith("root.png", result.ImportedFilePaths[0]);
        }
        finally
        {
            Directory.Delete(tempFolder, true);
        }
    }

    [Fact]
    public async Task ImportImagesFromFolderAsync_ShouldHandleMetadataExtractionFailures()
    {
        // Arrange
        var tempFolder = Path.Combine(Path.GetTempPath(), "TestImport_" + Guid.NewGuid());
        Directory.CreateDirectory(tempFolder);

        try
        {
            // Create test image files
            File.WriteAllText(Path.Combine(tempFolder, "image1.png"), "fake png 1");
            File.WriteAllText(Path.Combine(tempFolder, "image2.png"), "fake png 2");

            // Act
            var result = await _imageImportService.ImportImagesFromFolderAsync(tempFolder, false);

            // Assert
            Assert.Equal(2, result.TotalImages);
            Assert.Equal(2, result.SuccessfullyImported);
            Assert.Equal(0, result.FailedToImport);
        }
        finally
        {
            Directory.Delete(tempFolder, true);
        }
    }

    [Fact]
    public async Task ImportImagesFromFolderAsync_ShouldHandleUnsupportedFormats()
    {
        // Arrange
        var tempFolder = Path.Combine(Path.GetTempPath(), "TestImport_" + Guid.NewGuid());
        Directory.CreateDirectory(tempFolder);

        try
        {
            // Create test files with unsupported format
            File.WriteAllText(Path.Combine(tempFolder, "image1.bmp"), "fake bmp");

            // Act
            var result = await _imageImportService.ImportImagesFromFolderAsync(tempFolder, false);

            // Assert
            Assert.Equal(0, result.TotalImages);
            Assert.Equal(0, result.SuccessfullyImported);
            Assert.Equal(0, result.FailedToImport);
        }
        finally
        {
            Directory.Delete(tempFolder, true);
        }
    }

    [Fact]
    public async Task ImportImagesFromFolderAsync_ShouldPreserveRelativePaths()
    {
        // Arrange
        var tempFolder = Path.Combine(Path.GetTempPath(), "TestImport_" + Guid.NewGuid());
        var subFolder = Path.Combine(tempFolder, "Subfolder");
        Directory.CreateDirectory(tempFolder);
        Directory.CreateDirectory(subFolder);

        try
        {
            // Create test files
            File.WriteAllText(Path.Combine(tempFolder, "root.png"), "root image");
            File.WriteAllText(Path.Combine(subFolder, "sub.png"), "sub image");

            // Act
            var result = await _imageImportService.ImportImagesFromFolderAsync(tempFolder, true);

            // Assert
            Assert.Equal(2, result.ImportedFilePaths.Count);
            Assert.Contains("root.png", result.ImportedFilePaths);
            Assert.Contains(Path.Combine("Subfolder", "sub.png"), result.ImportedFilePaths);
        }
        finally
        {
            Directory.Delete(tempFolder, true);
        }
    }
}

// Mock metadata extraction service for testing
public class MockMetadataExtractionService : IMetadataExtractionService
{
    public Task<MetadataExtractionResult> ExtractMetadataAsync(string imagePath)
    {
        var result = new MetadataExtractionResult
        {
            Success = true,
            Prompt = "Test prompt",
            NegativePrompt = "Test negative prompt",
            Steps = 20,
            Sampler = "Euler a",
            CFGScale = 7.0m,
            Seed = 1234567890,
            Width = 512,
            Height = 512,
            ModelName = "Test Model",
            ModelHash = "TestHash"
        };

        return Task.FromResult(result);
    }
}