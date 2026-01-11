using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using AIGenManager.Application.UseCases.Images;
using AIGenManager.Application.DTOs;

namespace AIGenManager.Presentation.ViewModels;

public partial class ImportWizardViewModel : ViewModelBase
{
    private readonly ScanFolderUseCase _scanFolderUseCase;
    private readonly GetImportStatisticsUseCase _getImportStatisticsUseCase;

    [ObservableProperty]
    private string _selectedFolderPath = string.Empty;

    [ObservableProperty]
    private bool _isRecursive = true;

    [ObservableProperty]
    private bool _isImporting = false;

    [ObservableProperty]
    private int _currentProgress = 0;

    [ObservableProperty]
    private int _totalProgress = 0;

    [ObservableProperty]
    private string _currentFile = string.Empty;

    [ObservableProperty]
    private ImportResultDTO? _importResult;

    [ObservableProperty]
    private ObservableCollection<ImportErrorDTO> _errors = [];

    [ObservableProperty]
    private bool _showManualMetadataEntry = false;

    [ObservableProperty]
    private string? _manualMetadataFilePath;

    [ObservableProperty]
    private MetadataDTO _manualMetadata = new();

    [ObservableProperty]
    private string _statusMessage = string.Empty;

    public bool IsNotImporting => !IsImporting;

    public ImportWizardViewModel(ScanFolderUseCase scanFolderUseCase, GetImportStatisticsUseCase getImportStatisticsUseCase)
    {
        _scanFolderUseCase = scanFolderUseCase;
        _getImportStatisticsUseCase = getImportStatisticsUseCase;
    }

    [RelayCommand]
    private async Task StartImportAsync()
    {
        if (string.IsNullOrWhiteSpace(SelectedFolderPath))
        {
            StatusMessage = "Please select a folder to import.";
            return;
        }

        IsImporting = true;
        CurrentProgress = 0;
        TotalProgress = 0;
        _errors = [];
        StatusMessage = "Starting import...";

        try
        {
            var result = await _scanFolderUseCase.ExecuteAsync(SelectedFolderPath, IsRecursive);
            ImportResult = new ImportResultDTO
            {
                TotalImages = result.TotalImages,
                SuccessfullyImported = result.SuccessfullyImported,
                FailedToImport = result.FailedToImport,
                Errors = result.Errors.Select(e => new ImportErrorDTO
                {
                    FilePath = e.FilePath,
                    ErrorType = e.ErrorType,
                    ErrorMessage = e.ErrorMessage
                }).ToList(),
                ImportedFilePaths = result.ImportedFilePaths
            };

            var statistics = await _getImportStatisticsUseCase.ExecuteAsync(result);
            TotalProgress = statistics.TotalImages;
            CurrentProgress = statistics.SuccessfullyImported + statistics.FailedToImport;

            if (statistics.FailedToImport > 0)
            {
                var errors = result.Errors.Select(e => new ImportErrorDTO
                {
                    FilePath = e.FilePath,
                    ErrorType = e.ErrorType,
                    ErrorMessage = e.ErrorMessage
                }).ToList();
                
                foreach (var error in errors)
                {
                    _errors.Add(error);
                }
            }

            StatusMessage = $"Import completed: {statistics.SuccessfullyImported} succeeded, {statistics.FailedToImport} failed.";
        }
        catch (Exception ex)
        {
            StatusMessage = $"Import failed: {ex.Message}";
        }
        finally
        {
            IsImporting = false;
        }
    }

    [RelayCommand]
    private void ShowManualMetadataEntryForError(ImportErrorDTO error)
    {
        ManualMetadataFilePath = error.FilePath;
        ShowManualMetadataEntry = true;
        StatusMessage = $"Entering manual metadata for: {System.IO.Path.GetFileName(error.FilePath)}";
    }

    [RelayCommand]
    private void CloseManualMetadataEntry()
    {
        ShowManualMetadataEntry = false;
        ManualMetadataFilePath = null;
        ManualMetadata = new MetadataDTO();
        StatusMessage = "Manual metadata entry cancelled.";
    }

    [RelayCommand]
    private async Task SaveManualMetadataAsync()
    {
        if (string.IsNullOrWhiteSpace(ManualMetadataFilePath))
        {
            StatusMessage = "No file selected for manual metadata entry.";
            return;
        }

        // Validate required fields
        var validationErrors = new List<string>();
        
        if (string.IsNullOrWhiteSpace(ManualMetadata.Prompt))
        {
            validationErrors.Add("Prompt is required.");
        }
        
        if (!ManualMetadata.Steps.HasValue || ManualMetadata.Steps.Value <= 0)
        {
            validationErrors.Add("Steps must be greater than 0.");
        }
        
        if (string.IsNullOrWhiteSpace(ManualMetadata.Sampler))
        {
            validationErrors.Add("Sampler is required.");
        }
        
        if (!ManualMetadata.CFGScale.HasValue || ManualMetadata.CFGScale.Value <= 0)
        {
            validationErrors.Add("CFG Scale must be greater than 0.");
        }
        
        if (!ManualMetadata.Seed.HasValue || ManualMetadata.Seed.Value < 0)
        {
            validationErrors.Add("Seed must be a positive number.");
        }
        
        if (!ManualMetadata.Width.HasValue || ManualMetadata.Width.Value <= 0)
        {
            validationErrors.Add("Width must be greater than 0.");
        }
        
        if (!ManualMetadata.Height.HasValue || ManualMetadata.Height.Value <= 0)
        {
            validationErrors.Add("Height must be greater than 0.");
        }

        if (validationErrors.Any())
        {
            StatusMessage = $"Validation failed: {string.Join(", ", validationErrors)}";
            return;
        }

        try
        {
            // In a real implementation, this would save the metadata to the database
            // For now, we'll just simulate the save operation
            await Task.Delay(500);
            
            // Remove the error from the list since it's been resolved
            var errorToRemove = _errors.FirstOrDefault(e => e.FilePath == ManualMetadataFilePath);
            if (errorToRemove != null)
            {
                _errors.Remove(errorToRemove);
            }

            StatusMessage = $"Manual metadata saved successfully for: {System.IO.Path.GetFileName(ManualMetadataFilePath)}";
            ShowManualMetadataEntry = false;
            ManualMetadataFilePath = null;
            ManualMetadata = new MetadataDTO();
        }
        catch (Exception ex)
        {
            StatusMessage = $"Failed to save manual metadata: {ex.Message}";
        }
    }

    [RelayCommand]
    private void ClearImportResult()
    {
        ImportResult = null;
        _errors = [];
        CurrentProgress = 0;
        TotalProgress = 0;
        CurrentFile = string.Empty;
        StatusMessage = "Import results cleared.";
    }
}