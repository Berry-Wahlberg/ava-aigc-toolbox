using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AIGenManager.Core.Domain.Entities;
using AIGenManager.Application.UseCases.Tags;

namespace BerryAIGCToolbox.ViewModels;

public partial class TagViewModel : ViewModelBase
{
    private readonly GetAllTagsUseCase _getAllTagsUseCase;
    private readonly AddTagUseCase _addTagUseCase;

    [ObservableProperty]
    private ObservableCollection<Tag> _tags = [];

    [ObservableProperty]
    private Tag? _selectedTag;

    [ObservableProperty]
    private string _newTagName = string.Empty;

    [ObservableProperty]
    private string _searchQuery = string.Empty;

    [ObservableProperty]
    private bool _isLoading = false;

    [ObservableProperty]
    private string _statusMessage = string.Empty;

    [ObservableProperty]
    private bool _hasData = false;

    public bool HasSelectedTag => SelectedTag != null;

    public bool IsNotLoading => !IsLoading;

    partial void OnSelectedTagChanged(Tag? value)
    {
        OnPropertyChanged(nameof(HasSelectedTag));
    }

    partial void OnSearchQueryChanged(string value)
    {
        ApplyFilters();
    }

    public TagViewModel(
        GetAllTagsUseCase getAllTagsUseCase,
        AddTagUseCase addTagUseCase)
    {
        _getAllTagsUseCase = getAllTagsUseCase;
        _addTagUseCase = addTagUseCase;
    }

    [RelayCommand]
    private async Task LoadTags()
    {
        try
        {
            IsLoading = true;
            StatusMessage = "Loading tags...";
            
            var tags = await _getAllTagsUseCase.ExecuteAsync();
            Tags = new ObservableCollection<Tag>(tags);
            HasData = Tags.Any();
            
            StatusMessage = $"Loaded {Tags.Count} tags";
        }
        catch (Exception ex)
        {
            StatusMessage = $"Error loading tags: {ex.Message}";
        }
        finally
        {
            IsLoading = false;
        }
    }

    [RelayCommand]
    private async Task AddNewTag()
    {
        if (!string.IsNullOrWhiteSpace(NewTagName))
        {
            try
            {
                IsLoading = true;
                StatusMessage = $"Adding tag: {NewTagName}...";
                
                var request = new AddTagRequest(NewTagName);
                var tag = await _addTagUseCase.ExecuteAsync(request);
                if (tag != null)
                {
                    Tags.Add(tag);
                    NewTagName = string.Empty;
                    StatusMessage = $"Tag '{tag.Name}' added successfully";
                }
            }
            catch (Exception ex)
            {
                StatusMessage = $"Error adding tag: {ex.Message}";
            }
            finally
            {
                IsLoading = false;
            }
        }
    }

    [RelayCommand]
    private async Task DeleteSelectedTag()
    {
        if (SelectedTag != null)
        {
            try
            {
                IsLoading = true;
                StatusMessage = "Deleting tag...";
                
                Tags.Remove(SelectedTag);
                SelectedTag = null;
                
                StatusMessage = "Tag deleted successfully";
            }
            catch (Exception ex)
            {
                StatusMessage = $"Error deleting tag: {ex.Message}";
            }
            finally
            {
                IsLoading = false;
            }
        }
    }

    [RelayCommand]
    private async Task RefreshTags()
    {
        await LoadTags();
    }

    private void ApplyFilters()
    {
        IEnumerable<Tag> filtered;

        if (string.IsNullOrWhiteSpace(SearchQuery))
        {
            filtered = Tags;
        }
        else
        {
            var query = SearchQuery.ToLowerInvariant();
            filtered = Tags.Where(t => t.Name.ToLowerInvariant().Contains(query));
        }

        Tags = new ObservableCollection<Tag>(filtered);
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
