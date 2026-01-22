using System;
using System.Threading.Tasks;
using Avalonia.Controls;
using Avalonia.Threading;

namespace BerryAIGC.Toolkit.Services;

public interface IToastService
{
    void Show(string message, ToastType type = ToastType.Info);
    void ShowSuccess(string message);
    void ShowError(string message);
    void ShowWarning(string message);
}

public enum ToastType
{
    Info,
    Success,
    Warning,
    Error
}

public class ToastService : IToastService
{
    private Window? _ownerWindow;

    public ToastService(Window? ownerWindow = null)
    {
        _ownerWindow = ownerWindow;
    }

    public void Show(string message, ToastType type = ToastType.Info)
    {
        Avalonia.Threading.Dispatcher.UIThread.Post(() =>
        {
            var toast = CreateToast(message, type);
            ShowToast(toast);
        });
    }

    public void ShowSuccess(string message)
    {
        Show(message, ToastType.Success);
    }

    public void ShowError(string message)
    {
        Show(message, ToastType.Error);
    }

    public void ShowWarning(string message)
    {
        Show(message, ToastType.Warning);
    }

    private Border CreateToast(string message, ToastType type)
    {
        var border = new Border
        {
            Background = GetToastColor(type),
            CornerRadius = new CornerRadius(5),
            Padding = new Thickness(15),
            Margin = new Thickness(10),
            MinWidth = 200,
            MaxWidth = 400
        };

        var stackPanel = new StackPanel
        {
            Orientation = Avalonia.Layout.Orientation.Horizontal,
            Spacing = 10
        };

        var icon = GetToastIcon(type);
        var textBlock = new TextBlock
        {
            Text = message,
            VerticalAlignment = Avalonia.Layout.VerticalAlignment.Center
        };

        stackPanel.Children.Add(icon);
        stackPanel.Children.Add(textBlock);
        border.Child = stackPanel;

        return border;
    }

    private void ShowToast(Border toast)
    {
        var overlay = new Border
        {
            Background = Avalonia.Media.Colors.Black.WithAlpha(0.5),
            IsHitTestVisible = false
        };

        var canvas = new Canvas();
        canvas.Children.Add(overlay);
        canvas.Children.Add(toast);

        var window = Avalonia.Application.Current?.ApplicationLifetime is Avalonia.Controls.ApplicationLifetimes.IClassicDesktopStyleApplicationLifetime desktop
            ? desktop.MainWindow
            : _ownerWindow;

        if (window != null)
        {
            var overlayLayer = new Panel();
            overlayLayer.Children.Add(canvas);
            
            window.Content = new Grid
            {
                Children =
                {
                    window.Content,
                    overlayLayer
                }
            };

            Task.Delay(3000).ContinueWith(_ =>
            {
                Avalonia.Threading.Dispatcher.UIThread.Post(() =>
                {
                    canvas.Children.Remove(toast);
                    canvas.Children.Remove(overlay);
                    overlayLayer.Children.Remove(canvas);
                });
            });
        }
    }

    private Avalonia.Media.IBrush GetToastColor(ToastType type)
    {
        return type switch
        {
            ToastType.Success => Avalonia.Media.Brushes.Green,
            ToastType.Error => Avalonia.Media.Brushes.Red,
            ToastType.Warning => Avalonia.Media.Brushes.Orange,
            ToastType.Info => Avalonia.Media.Brushes.Blue,
            _ => Avalonia.Media.Brushes.Gray
        };
    }

    private TextBlock GetToastIcon(ToastType type)
    {
        return new TextBlock
        {
            Text = type switch
            {
                ToastType.Success => "✓",
                ToastType.Error => "✕",
                ToastType.Warning => "⚠",
                ToastType.Info => "ℹ",
                _ => ""
            },
            FontSize = 20,
            FontWeight = Avalonia.Media.FontWeight.Bold
        };
    }
}
