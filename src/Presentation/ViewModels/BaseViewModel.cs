using System.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace BerryAIGC.Toolkit.ViewModels;

public partial class BaseViewModel : ObservableObject
{
    private bool _isDirty;
    public bool IsDirty
    {
        get => _isDirty;
        set => SetProperty(ref _isDirty, value);
    }

    public void SetDirty()
    {
        IsDirty = true;
    }

    public void SetPristine()
    {
        IsDirty = false;
    }

    protected bool SetProperty<T>(ref T field, T value, [System.Runtime.CompilerServices.CallerMemberName] string? propertyName = null)
    {
        var result = SetProperty(ref field, value, propertyName);
        if (result)
        {
            SetDirty();
        }
        return result;
    }

    public void RegisterObservableChanges<T>(IObservableCollection<T> collection)
    {
        collection.CollectionChanged += (s, e) =>
        {
            if (e.Action == NotifyCollectionChangedAction.Add ||
                e.Action == NotifyCollectionChangedAction.Remove ||
                e.Action == NotifyCollectionChangedAction.Replace ||
                e.Action == NotifyCollectionChangedAction.Move ||
                e.Action == NotifyCollectionChangedAction.Reset)
            {
                SetDirty();
            }
        };
    }
}
