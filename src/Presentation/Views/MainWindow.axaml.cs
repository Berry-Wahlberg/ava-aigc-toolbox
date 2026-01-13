using Avalonia.Controls;
using AIGenManager.Core.Domain.Entities;

namespace BerryAIGCToolbox.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void OnImageDoubleTapped(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        if (sender is ListBox listBox && listBox.SelectedItem is Image image)
        {
            var viewModel = DataContext as ViewModels.MainWindowViewModel;
            viewModel?.OpenImage(image);
        }
    }
}