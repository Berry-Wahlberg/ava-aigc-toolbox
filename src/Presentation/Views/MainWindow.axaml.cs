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
        if (sender is Border border && border.DataContext is AIGenManager.Core.Domain.Entities.Image image)
        {
            var viewModel = DataContext as ViewModels.MainWindowViewModel;
            viewModel?.OpenImage(image);
        }
    }
}