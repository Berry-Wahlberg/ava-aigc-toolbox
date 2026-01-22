using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace BerryAIGC.Toolkit.ViewModels;

public partial class PromptsViewModel : ObservableObject
{
    private ObservableCollection<PromptViewModel> _prompts = new();
    private PromptViewModel? _selectedPrompt;

    public ObservableCollection<PromptViewModel> Prompts
    {
        get => _prompts;
        set => SetProperty(ref _prompts, value);
    }

    public PromptViewModel? SelectedPrompt
    {
        get => _selectedPrompt;
        set => SetProperty(ref _selectedPrompt, value);
    }
}

public class PromptViewModel : ObservableObject
{
    private string _name = "";
    private string _description = "";
    private string _promptText = "";

    public string Name
    {
        get => _name;
        set => SetProperty(ref _name, value);
    }

    public string Description
    {
        get => _description;
        set => SetProperty(ref _description, value);
    }

    public string PromptText
    {
        get => _promptText;
        set => SetProperty(ref _promptText, value);
    }
}
