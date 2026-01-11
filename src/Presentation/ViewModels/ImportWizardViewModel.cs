using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
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
            return;
        }

        IsImporting = true;
        CurrentProgress = 0;
        TotalProgress = 0;
        _errors = [];

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
    }

    [RelayCommand]
    private void CloseManualMetadataEntry()
    {
        ShowManualMetadataEntry = false;
        ManualMetadataFilePath = null;
    }

    [RelayCommand]
    private void ClearImportResult()
    {
        ImportResult = null;
        _errors = [];
        CurrentProgress = 0;
        TotalProgress = 0;
        CurrentFile = string.Empty;
    }
}