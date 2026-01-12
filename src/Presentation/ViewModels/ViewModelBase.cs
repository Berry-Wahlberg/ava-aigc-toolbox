using CommunityToolkit.Mvvm.ComponentModel;
using Avalonia.Controls;

namespace BerryAIGCToolbox.ViewModels;

public abstract class ViewModelBase : ObservableObject
{
    // Static reference to the main window for dialog access
    public static Window? MainWindow { get; set; }
}
