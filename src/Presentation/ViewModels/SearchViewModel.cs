using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace BerryAIGC.Toolkit.ViewModels;

public partial class SearchViewModel : ObservableObject
{
    private string _searchText = "";
    private ObservableCollection<SearchResultViewModel> _results = new();
    private bool _caseSensitive = false;
    private bool _includeFilename = true;
    private bool _includeTags = true;
    private bool _isSearching = false;

    public string SearchText
    {
        get => _searchText;
        set => SetProperty(ref _searchText, value);
    }

    public ObservableCollection<SearchResultViewModel> Results
    {
        get => _results;
        set => SetProperty(ref _results, value);
    }

    public bool CaseSensitive
    {
        get => _caseSensitive;
        set => SetProperty(ref _caseSensitive, value);
    }

    public bool IncludeFilename
    {
        get => _includeFilename;
        set => SetProperty(ref _includeFilename, value);
    }

    public bool IncludeTags
    {
        get => _includeTags;
        set => SetProperty(ref _includeTags, value);
    }

    public bool IsSearching
    {
        get => _isSearching;
        set => SetProperty(ref _isSearching, value);
    }

    public IRelayCommand SearchCommand { get; }

    public SearchViewModel()
    {
        SearchCommand = new RelayCommand(ExecuteSearch);
    }

    private void ExecuteSearch()
    {
        if (string.IsNullOrWhiteSpace(SearchText))
        {
            Results.Clear();
            return;
        }

        IsSearching = true;
        
        // TODO: Implement actual search logic
        // This will be connected to SearchService
        
        SetDirty();
    }
}

public class SearchResultViewModel : ObservableObject
{
    private string _fileName = "";
    private string _filePath = "";
    private string _fileSize = "";

    public string FileName
    {
        get => _fileName;
        set => SetProperty(ref _fileName, value);
    }

    public string FilePath
    {
        get => _filePath;
        set => SetProperty(ref _filePath, value);
    }

    public string FileSize
    {
        get => _fileSize;
        set => SetProperty(ref _fileSize, value);
    }
}
