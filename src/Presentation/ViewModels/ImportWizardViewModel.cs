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
    private ObservableCollection<ImportErrorDTO> _importErrors = [];

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
    private async Task SelectFolderAsync()
    {
        var dialog = new Microsoft.Win32.OpenFileDialog();
        dialog.Filter = "Folders|*.none";
        dialog.CheckFileExists = false;
        dialog.CheckPathExists = true;
        dialog.FileName = "Select Folder";

        if (dialog.ShowDialog() == true)
        {
            SelectedFolderPath = System.IO.Path.GetDirectoryName(dialog.FileName);
        }
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
        ImportErrors.Clear();

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
                ImportErrors = new ObservableCollection<ImportErrorDTO>(ImportResult.Errors);
            }
        }
        finally
        {
            IsImporting = false;
        }
    }

    [RelayCommand]
    private void ShowManualMetadataEntry(ImportErrorDTO error)
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
        ImportErrors.Clear();
        CurrentProgress = 0;
        TotalProgress = 0;
        CurrentFile = string.Empty;
    }
}