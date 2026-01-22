using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using BerryAIGC.Toolkit.Themes;

namespace BerryAIGC.Toolkit.ViewModels;

public partial class SettingsViewModel : ObservableObject
{
    private readonly IThemeService _themeService;
    private int _themeIndex = 0;
    private int _thumbnailSize = 1;
    private int _viewMode = 0;
    private bool _showFilenames = true;
    private bool _showTags = true;
    private bool _showMetadata = true;

    public SettingsViewModel(IThemeService themeService)
    {
        _themeService = themeService;
        
        SaveCommand = new RelayCommand(ExecuteSave);
    }

    public int ThemeIndex
    {
        get => _themeIndex;
        set => SetProperty(ref _themeIndex, value);
    }

    public int ThumbnailSize
    {
        get => _thumbnailSize;
        set => SetProperty(ref _thumbnailSize, value);
    }

    public int ViewMode
    {
        get => _viewMode;
        set => SetProperty(ref _viewMode, value);
    }

    public bool ShowFilenames
    {
        get => _showFilenames;
        set => SetProperty(ref _showFilenames, value);
    }

    public bool ShowTags
    {
        get => _showTags;
        set => SetProperty(ref _showTags, value);
    }

    public bool ShowMetadata
    {
        get => _showMetadata;
        set => SetProperty(ref _showMetadata, value);
    }

    public IRelayCommand SaveCommand { get; }

    private void ExecuteSave()
    {
        // TODO: Implement actual save logic
        // This will be connected to Settings service
        
        SetDirty();
    }
}
