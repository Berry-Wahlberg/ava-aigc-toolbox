using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using AIGenManager.Presentation.ViewModels;
using AIGenManager.Application.UseCases.Images;
using AIGenManager.Application.DTOs;
using AIGenManager.Core.Domain.Services;

namespace AIGenManager.Infrastructure.Tests;

public class ImportWizardViewModelTests
{
    private readonly MockScanFolderUseCase _mockScanFolderUseCase;
    private readonly MockGetImportStatisticsUseCase _mockGetImportStatisticsUseCase;
    private readonly ImportWizardViewModel _viewModel;

    public ImportWizardViewModelTests()
    {
        _mockScanFolderUseCase = new MockScanFolderUseCase();
        _mockGetImportStatisticsUseCase = new MockGetImportStatisticsUseCase();
        _viewModel = new ImportWizardViewModel(_mockScanFolderUseCase, _mockGetImportStatisticsUseCase);
    }

    [Fact]
    public void Constructor_ShouldInitializeProperties()
    {
        // Assert
        Assert.Equal(string.Empty, _viewModel.SelectedFolderPath);
        Assert.True(_viewModel.IsRecursive);
        Assert.False(_viewModel.IsImporting);
        Assert.Equal(0, _viewModel.CurrentProgress);
        Assert.Equal(0, _viewModel.TotalProgress);
        Assert.Null(_viewModel.ImportResult);
        Assert.Empty(_viewModel.Errors);
        Assert.False(_viewModel.ShowManualMetadataEntry);
        Assert.Null(_viewModel.ManualMetadataFilePath);
        Assert.NotNull(_viewModel.ManualMetadata);
        Assert.Equal(string.Empty, _viewModel.StatusMessage);
    }

    [Fact]
    public async Task StartImportAsync_ShouldNotImportWhenFolderNotSelected()
    {
        // Arrange
        _viewModel.SelectedFolderPath = string.Empty;

        // Act
        await _viewModel.StartImportCommand.ExecuteAsync(null);

        // Assert
        Assert.Equal("Please select a folder to import.", _viewModel.StatusMessage);
        Assert.False(_viewModel.IsImporting);
    }

    [Fact]
    public async Task StartImportAsync_ShouldSetImportingState()
    {
        // Arrange
        _viewModel.SelectedFolderPath = @"C:\TestImages";
        var mockResult = new ImportResult
        {
            TotalImages = 10,
            SuccessfullyImported = 8,
            FailedToImport = 2,
            Errors = new List<ImportError>
            {
                new ImportError { FilePath = @"C:\TestImages\error1.png", ErrorType = "MetadataExtraction", ErrorMessage = "No metadata found" },
                new ImportError { FilePath = @"C:\TestImages\error2.png", ErrorType = "UnsupportedFormat", ErrorMessage = "Invalid format" }
            },
            ImportedFilePaths = new List<string>
            {
                @"C:\TestImages\image1.png",
                @"C:\TestImages\image2.png"
            }
        };

        _mockScanFolderUseCase.SetResult(mockResult);

        // Act
        await _viewModel.StartImportCommand.ExecuteAsync(null);

        // Assert
        Assert.True(_viewModel.IsImporting);
        Assert.NotNull(_viewModel.ImportResult);
        Assert.Equal(10, _viewModel.ImportResult.TotalImages);
        Assert.Equal(8, _viewModel.ImportResult.SuccessfullyImported);
        Assert.Equal(2, _viewModel.ImportResult.FailedToImport);
        Assert.Equal(2, _viewModel.Errors.Count);
    }

    [Fact]
    public void ShowManualMetadataEntryForError_ShouldSetManualEntryState()
    {
        // Arrange
        var error = new ImportErrorDTO
        {
            FilePath = @"C:\TestImages\error.png",
            ErrorType = "MetadataExtraction",
            ErrorMessage = "No metadata found"
        };

        // Act
        _viewModel.ShowManualMetadataEntryForErrorCommand.Execute(error);

        // Assert
        Assert.True(_viewModel.ShowManualMetadataEntry);
        Assert.Equal(@"C:\TestImages\error.png", _viewModel.ManualMetadataFilePath);
        Assert.Contains("error.png", _viewModel.StatusMessage);
    }

    [Fact]
    public void CloseManualMetadataEntry_ShouldResetManualEntryState()
    {
        // Arrange
        _viewModel.ShowManualMetadataEntry = true;
        _viewModel.ManualMetadataFilePath = @"C:\TestImages\error.png";
        _viewModel.ManualMetadata.Prompt = "Test prompt";

        // Act
        _viewModel.CloseManualMetadataEntryCommand.Execute(null);

        // Assert
        Assert.False(_viewModel.ShowManualMetadataEntry);
        Assert.Null(_viewModel.ManualMetadataFilePath);
        Assert.Null(_viewModel.ManualMetadata.Prompt);
        Assert.Contains("cancelled", _viewModel.StatusMessage);
    }

    [Fact]
    public async Task SaveManualMetadataAsync_ShouldValidateRequiredFields()
    {
        // Arrange
        _viewModel.ManualMetadataFilePath = @"C:\TestImages\error.png";
        _viewModel.ManualMetadata = new MetadataDTO
        {
            Prompt = string.Empty,
            Steps = null,
            Sampler = string.Empty,
            CFGScale = null,
            Seed = null,
            Width = null,
            Height = null
        };

        // Act
        await _viewModel.SaveManualMetadataCommand.ExecuteAsync(null);

        // Assert
        Assert.Contains("Validation failed", _viewModel.StatusMessage);
        Assert.Contains("Prompt is required", _viewModel.StatusMessage);
    }

    [Fact]
    public async Task SaveManualMetadataAsync_ShouldRemoveErrorAfterSuccessfulSave()
    {
        // Arrange
        var error = new ImportErrorDTO
        {
            FilePath = @"C:\TestImages\error.png",
            ErrorType = "MetadataExtraction",
            ErrorMessage = "No metadata found"
        };
        _viewModel.Errors.Add(error);
        _viewModel.ManualMetadataFilePath = error.FilePath;
        _viewModel.ManualMetadata = new MetadataDTO
        {
            Prompt = "Test prompt",
            Steps = 20,
            Sampler = "Euler a",
            CFGScale = 7.0m,
            Seed = 1234567890,
            Width = 512,
            Height = 512,
            ModelName = "Test Model",
            ModelHash = "TestHash"
        };

        // Act
        await _viewModel.SaveManualMetadataCommand.ExecuteAsync(null);

        // Assert
        Assert.DoesNotContain(error, _viewModel.Errors);
        Assert.False(_viewModel.ShowManualMetadataEntry);
        Assert.Contains("saved successfully", _viewModel.StatusMessage);
    }

    [Fact]
    public void ClearImportResult_ShouldResetAllProperties()
    {
        // Arrange
        _viewModel.ImportResult = new ImportResultDTO
        {
            TotalImages = 10,
            SuccessfullyImported = 8,
            FailedToImport = 2
        };
        _viewModel.Errors.Add(new ImportErrorDTO
        {
            FilePath = @"C:\TestImages\error.png",
            ErrorType = "MetadataExtraction",
            ErrorMessage = "No metadata found"
        });
        _viewModel.CurrentProgress = 10;
        _viewModel.TotalProgress = 10;

        // Act
        _viewModel.ClearImportResultCommand.Execute(null);

        // Assert
        Assert.Null(_viewModel.ImportResult);
        Assert.Empty(_viewModel.Errors);
        Assert.Equal(0, _viewModel.CurrentProgress);
        Assert.Equal(0, _viewModel.TotalProgress);
        Assert.Contains("cleared", _viewModel.StatusMessage);
    }

    [Fact]
    public void IsNotImporting_ShouldReturnTrueWhenNotImporting()
    {
        // Arrange
        _viewModel.IsImporting = false;

        // Act
        var result = _viewModel.IsNotImporting;

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsNotImporting_ShouldReturnFalseWhenImporting()
    {
        // Arrange
        _viewModel.IsImporting = true;

        // Act
        var result = _viewModel.IsNotImporting;

        // Assert
        Assert.False(result);
    }
}

// Mock use cases for testing
public class MockScanFolderUseCase : ScanFolderUseCase
{
    private ImportResult? _result;

    public MockScanFolderUseCase() : base(null!) { }

    public void SetResult(ImportResult result)
    {
        _result = result;
    }

    public new Task<ImportResult> ExecuteAsync(string folderPath, bool recursive = true)
    {
        return Task.FromResult(_result ?? new ImportResult());
    }
}

public class MockGetImportStatisticsUseCase : GetImportStatisticsUseCase
{
    public MockGetImportStatisticsUseCase() : base() { }

    public new Task<ImportStatistics> ExecuteAsync(ImportResult importResult)
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