using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AIGenManager.Core.Domain.Entities;
using AIGenManager.Application.UseCases.Prompts;

namespace BerryAIGCToolbox.ViewModels;

public partial class PromptViewModel : ViewModelBase
{
    private readonly GetAllPromptsUseCase _getAllPromptsUseCase;
    private readonly AddPromptUseCase _addPromptUseCase;
    private readonly DeletePromptUseCase _deletePromptUseCase;

    [ObservableProperty]
    private ObservableCollection<Prompt> _prompts = [];

    [ObservableProperty]
    private Prompt? _selectedPrompt;

    [ObservableProperty]
    private string _newPromptName = string.Empty;

    [ObservableProperty]
    private string _newPromptContent = string.Empty;

    [ObservableProperty]
    private string _searchQuery = string.Empty;

    [ObservableProperty]
    private bool _isLoading = false;

    [ObservableProperty]
    private string _statusMessage = string.Empty;

    [ObservableProperty]
    private bool _hasData = false;

    public bool HasSelectedPrompt => SelectedPrompt != null;

    public bool IsNotLoading => !IsLoading;

    partial void OnSelectedPromptChanged(Prompt? value)
    {
        OnPropertyChanged(nameof(HasSelectedPrompt));
    }

    partial void OnSearchQueryChanged(string value)
    {
        ApplyFilters();
    }

    public PromptViewModel(
        GetAllPromptsUseCase getAllPromptsUseCase,
        AddPromptUseCase addPromptUseCase,
        DeletePromptUseCase deletePromptUseCase)
    {
        _getAllPromptsUseCase = getAllPromptsUseCase;
        _addPromptUseCase = addPromptUseCase;
        _deletePromptUseCase = deletePromptUseCase;
    }

    [RelayCommand]
    private async Task LoadPrompts()
    {
        try
        {
            IsLoading = true;
            StatusMessage = "Loading prompts...";
            
            var prompts = await _getAllPromptsUseCase.ExecuteAsync(new GetAllPromptsRequest());
            Prompts = new ObservableCollection<Prompt>(prompts);
            HasData = Prompts.Any();
            
            StatusMessage = $"Loaded {Prompts.Count} prompts";
        }
        catch (Exception ex)
        {
            StatusMessage = $"Error loading prompts: {ex.Message}";
        }
        finally
        {
            IsLoading = false;
        }
    }

    [RelayCommand]
    private async Task AddNewPrompt()
    {
        if (!string.IsNullOrWhiteSpace(NewPromptName))
        {
            try
            {
                IsLoading = true;
                StatusMessage = "Adding prompt...";
                
                var request = new AddPromptRequest(NewPromptName, NewPromptContent);
                var prompt = await _addPromptUseCase.ExecuteAsync(request);
                if (prompt != null)
                {
                    Prompts.Add(prompt);
                    NewPromptName = string.Empty;
                    NewPromptContent = string.Empty;
                    StatusMessage = $"Prompt '{prompt.Name}' added successfully";
                }
            }
            catch (Exception ex)
            {
                StatusMessage = $"Error adding prompt: {ex.Message}";
            }
            finally
            {
                IsLoading = false;
            }
        }
    }

    [RelayCommand]
    private async Task DeleteSelectedPrompt()
    {
        if (SelectedPrompt != null)
        {
            try
            {
                IsLoading = true;
                StatusMessage = "Deleting prompt...";
                
                var request = new DeletePromptRequest(SelectedPrompt.Id);
                await _deletePromptUseCase.ExecuteAsync(request);
                
                Prompts.Remove(SelectedPrompt);
                SelectedPrompt = null;
                
                StatusMessage = "Prompt deleted successfully";
            }
            catch (Exception ex)
            {
                StatusMessage = $"Error deleting prompt: {ex.Message}";
            }
            finally
            {
                IsLoading = false;
            }
        }
    }

    [RelayCommand]
    private async Task RefreshPrompts()
    {
        await LoadPrompts();
    }

    private void ApplyFilters()
    {
        IEnumerable<Prompt> filtered;

        if (string.IsNullOrWhiteSpace(SearchQuery))
        {
            filtered = Prompts;
        }
        else
        {
            var query = SearchQuery.ToLowerInvariant();
            filtered = Prompts.Where(p =>
                p.Name.ToLowerInvariant().Contains(query) ||
                p.Content.ToLowerInvariant().Contains(query));
        }

        Prompts = new ObservableCollection<Prompt>(filtered);
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
