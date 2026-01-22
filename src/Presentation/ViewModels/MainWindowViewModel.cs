using System.Collections.ObjectModel;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using BerryAIGC.Toolkit.Themes;
using BerryAIGC.Toolkit.Localization;

namespace BerryAIGC.Toolkit.ViewModels;

public partial class MainWindowViewModel : BaseViewModel
{
    private readonly IThemeService _themeService;
    private readonly ILocalizationService _localizationService;
    private ObservableCollection<FolderViewModel> _folders = new();ILocalizationService _localizationService;
    private ObservableCollection<FolderViewModel> _folders = new();
    private ObservableCollection<ImageViewModel> _images = new();
    private FolderViewModel? _selectedFolder;
    private ImageViewModel? _selectedImage;
    private string _statusMessage = "Ready";
    private bool _isImporting = false;

    public MainWindowViewModel(IThemeService themeService)
    {
        _themeService = themeService;
        
        ImportCommand = new RelayCommand(ExecuteImport);
        SearchCommand = new RelayCommand(ExecuteSearch);
        SettingsCommand = new RelayCommand(ExecuteSettings);
        
        MinimizeButton_Click = new RelayCommand(ExecuteMinimize);
        MaximizeButton_Click = new RelayCommand(ExecuteMaximize);
        CloseButton_Click = new RelayCommand(ExecuteClose);
    }

    public ObservableCollection<FolderViewModel> Folders
    {
        get => _folders;
        set => SetProperty(ref _folders, value);
    }

    public ObservableCollection<ImageViewModel> Images
    {
        get => _images;
        set => SetProperty(ref _images, value);
    }

    public FolderViewModel? SelectedFolder
    {
        get => _selectedFolder;
        set => SetProperty(ref _selectedFolder, value);
    }

    public ImageViewModel? SelectedImage
    {
        get => _selectedImage;
        set => SetProperty(ref _selectedImage, value);
    }

    public string StatusMessage
    {
        get => _statusMessage;
        set => SetProperty(ref _statusMessage, value);
    }

    public bool IsImporting
    {
        get => _isImporting;
        set => SetProperty(ref _isImporting, value);
    }

    public IRelayCommand ImportCommand { get; }
    public IRelayCommand SearchCommand { get; }
    public IRelayCommand SettingsCommand { get; }
    public IRelayCommand MinimizeButton_Click { get; }
    public IRelayCommand MaximizeButton_Click { get; }
    public IRelayCommand CloseButton_Click { get; }

    private void ExecuteImport()
    {
        StatusMessage = "Importing images...";
        IsImporting = true;
        
        // TODO: Implement actual import logic
        // This will be connected to FileService and ScanningService
        
        SetDirty();
    }

    private void ExecuteSearch()
    {
        StatusMessage = "Searching...";
        
        // TODO: Implement search logic
        // This will be connected to SearchService
        
        SetDirty();
    }

    private void ExecuteSettings()
    {
        StatusMessage = "Opening settings...";
        
        // TODO: Implement settings navigation
        // This will be connected to NavigatorService
        
        SetDirty();
    }

    private void ExecuteMinimize()
    {
        // TODO: Implement minimize logic
    }

    private void ExecuteMaximize()
    {
        // TODO: Implement maximize logic
    }

    private void ExecuteClose()
    {
        // TODO: Implement close logic
    }
}

public class FolderViewModel : ObservableObject
{
    private string _name = "";
    private string _path = "";
    private int _imageCount = 0;

    public string Name
    {
        get => _name;
        set => SetProperty(ref _name, value);
    }

    public string Path
    {
        get => _path;
        set => SetProperty(ref _path, value);
    }

    public int ImageCount
    {
        get => _imageCount;
        set => SetProperty(ref _imageCount, value);
    }
}

public class ImageViewModel : ObservableObject
{
    private string _fileName = "";
    private string _thumbnail = "";
    private string _filePath = "";

    public string FileName
    {
        get => _fileName;
        set => SetProperty(ref _fileName, value);
    }

    public string Thumbnail
    {
        get => _thumbnail;
        set => SetProperty(ref _thumbnail, value);
    }

    public string FilePath
    {
        get => _filePath;
        set => SetProperty(ref _filePath, value);
    }
}
