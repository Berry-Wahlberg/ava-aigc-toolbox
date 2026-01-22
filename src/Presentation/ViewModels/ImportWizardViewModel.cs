using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.ObjectModel;

namespace BerryAIGC.Toolkit.ViewModels;

public partial class ImportWizardViewModel : ViewModelBase
{
    // TODO: Implement actual use cases when services are available
    // private readonly AIGenManager.Application.UseCases.Images.ScanFolderUseCase _scanFolderUseCase;
    // private readonly AIGenManager.Application.UseCases.Images.GetImportStatisticsUseCase _getImportStatisticsUseCase;

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
    private string _statusMessage = string.Empty;

    [ObservableProperty]
    private bool _showManualMetadataEntry = false;

    [ObservableProperty]
    private string? _manualMetadataFilePath;

    [ObservableProperty]
    private MetadataDTO _manualMetadata = new();

    public bool IsNotImporting => !IsImporting;

    public ImportWizardViewModel()
    {
        // TODO: Initialize use cases when services are available
    }

    [RelayCommand]
    private void SelectFolder()
    {
        // For now, we'll just use a hardcoded path for testing
        SelectedFolderPath = "C:\\AI Images";
        StatusMessage = "Folder selected: " + SelectedFolderPath;
    }
}
