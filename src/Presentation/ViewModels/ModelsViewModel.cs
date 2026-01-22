using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace BerryAIGC.Toolkit.ViewModels;

public partial class ModelsViewModel : ObservableObject
{
    private ObservableCollection<ModelViewModel> _models = new();
    private ModelViewModel? _selectedModel;

    public ObservableCollection<ModelViewModel> Models
    {
        get => _models;
        set => SetProperty(ref _models, value);
    }

    public ModelViewModel? SelectedModel
    {
        get => _selectedModel;
        set => SetProperty(ref _selectedModel, value);
    }
}

public class ModelViewModel : ObservableObject
{
    private string _name = "";
    private string _description = "";
    private string _thumbnail = "";
    private string _modelType = "";

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

    public string Thumbnail
    {
        get => _thumbnail;
        set => SetProperty(ref _thumbnail, value);
    }

    public string ModelType
    {
        get => _modelType;
        set => SetProperty(ref _modelType, value);
    }
}
