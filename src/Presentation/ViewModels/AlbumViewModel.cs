using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AIGenManager.Core.Domain.Entities;
using AIGenManager.Application.UseCases.Albums;

namespace BerryAIGCToolbox.ViewModels;

public partial class AlbumViewModel : ViewModelBase
{
    private readonly GetAllAlbumsUseCase _getAllAlbumsUseCase;
    private readonly AddAlbumUseCase _addAlbumUseCase;

    [ObservableProperty]
    private ObservableCollection<Album> _albums = [];

    [ObservableProperty]
    private Album? _selectedAlbum;

    [ObservableProperty]
    private string _newAlbumName = string.Empty;

    [ObservableProperty]
    private string _searchQuery = string.Empty;

    [ObservableProperty]
    private bool _isLoading = false;

    [ObservableProperty]
    private string _statusMessage = string.Empty;

    [ObservableProperty]
    private bool _hasData = false;

    public bool HasSelectedAlbum => SelectedAlbum != null;

    public bool IsNotLoading => !IsLoading;

    partial void OnSelectedAlbumChanged(Album? value)
    {
        OnPropertyChanged(nameof(HasSelectedAlbum));
    }

    partial void OnSearchQueryChanged(string value)
    {
        ApplyFilters();
    }

    public AlbumViewModel(
        GetAllAlbumsUseCase getAllAlbumsUseCase,
        AddAlbumUseCase addAlbumUseCase)
    {
        _getAllAlbumsUseCase = getAllAlbumsUseCase;
        _addAlbumUseCase = addAlbumUseCase;
    }

    [RelayCommand]
    private async Task LoadAlbums()
    {
        try
        {
            IsLoading = true;
            StatusMessage = "Loading albums...";
            
            var albums = await _getAllAlbumsUseCase.ExecuteAsync();
            Albums = new ObservableCollection<Album>(albums);
            HasData = Albums.Any();
            
            StatusMessage = $"Loaded {Albums.Count} albums";
        }
        catch (Exception ex)
        {
            StatusMessage = $"Error loading albums: {ex.Message}";
        }
        finally
        {
            IsLoading = false;
        }
    }

    [RelayCommand]
    private async Task AddNewAlbum()
    {
        if (!string.IsNullOrWhiteSpace(NewAlbumName))
        {
            try
            {
                IsLoading = true;
                StatusMessage = $"Adding album: {NewAlbumName}...";
                
                var request = new AddAlbumRequest(NewAlbumName);
                var album = await _addAlbumUseCase.ExecuteAsync(request);
                if (album != null)
                {
                    Albums.Add(album);
                    NewAlbumName = string.Empty;
                    StatusMessage = $"Album '{album.Name}' added successfully";
                }
            }
            catch (Exception ex)
            {
                StatusMessage = $"Error adding album: {ex.Message}";
            }
            finally
            {
                IsLoading = false;
            }
        }
    }

    [RelayCommand]
    private async Task DeleteSelectedAlbum()
    {
        if (SelectedAlbum != null)
        {
            try
            {
                IsLoading = true;
                StatusMessage = "Deleting album...";
                
                Albums.Remove(SelectedAlbum);
                SelectedAlbum = null;
                
                StatusMessage = "Album deleted successfully";
            }
            catch (Exception ex)
            {
                StatusMessage = $"Error deleting album: {ex.Message}";
            }
            finally
            {
                IsLoading = false;
            }
        }
    }

    [RelayCommand]
    private async Task RefreshAlbums()
    {
        await LoadAlbums();
    }

    private void ApplyFilters()
    {
        IEnumerable<Album> filtered;

        if (string.IsNullOrWhiteSpace(SearchQuery))
        {
            filtered = Albums;
        }
        else
        {
            var query = SearchQuery.ToLowerInvariant();
            filtered = Albums.Where(a => a.Name.ToLowerInvariant().Contains(query));
        }

        Albums = new ObservableCollection<Album>(filtered);
    }

    partial void OnIsLoadingChanged(bool value)
    {
        OnPropertyChanged(nameof(IsNotLoading));
    }

    partial void OnHasDataChanged(bool value)
    {
        OnPropertyChanged(nameof(ShowEmptyState));
    }

    public bool ShowEmptyState => !IsLoading && !HasData;

    public bool ShowMainContent => !IsLoading && HasData;
}
