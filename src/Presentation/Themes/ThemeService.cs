using Avalonia.Styling;
using Avalonia.Media;

namespace BerryAIGC.Toolkit.Themes;

public enum AppTheme
{
    Light,
    Dark,
    System
}

public interface IThemeService
{
    AppTheme CurrentTheme { get; }
    void SetTheme(AppTheme theme);
    event EventHandler<AppTheme>? ThemeChanged;
}

public class ThemeService : IThemeService
{
    private AppTheme _currentTheme = AppTheme.System;
    public event EventHandler<AppTheme>? ThemeChanged;

    public AppTheme CurrentTheme
    {
        get => _currentTheme;
        private set
        {
            if (_currentTheme != value)
            {
                _currentTheme = value;
                ThemeChanged?.Invoke(this, value);
                ApplyTheme(value);
            }
        }
    }

    public void SetTheme(AppTheme theme)
    {
        CurrentTheme = theme;
    }

    private void ApplyTheme(AppTheme theme)
    {
        var app = Avalonia.Application.Current;
        if (app == null) return;

        var themeVariant = theme switch
        {
            AppTheme.Light => ThemeVariant.Light,
            AppTheme.Dark => ThemeVariant.Dark,
            AppTheme.System => GetSystemTheme(),
            _ => ThemeVariant.Light
        };

        app.RequestedThemeVariant = themeVariant;

        var resources = GetThemeResources(theme);
        ApplyResources(app, resources);
    }

    private ThemeResources GetThemeResources(AppTheme theme)
    {
        return theme switch
        {
            AppTheme.Light => new ThemeResources
            {
                Background = new SolidColorBrush(Color.Parse("#1E1E1E")),
                Foreground = new SolidColorBrush(Color.Parse("#E0E0E0")),
                SecondaryForeground = new SolidColorBrush(Color.Parse("#A0A0A0")),
                TitleBarBackground = new SolidColorBrush(Color.Parse("#2D2D2D")),
                TitleBarForeground = new SolidColorBrush(Color.Parse("#E0E0E0")),
                TitleBarButtonHover = new SolidColorBrush(Color.Parse("#3D3D3D")),
                SidebarBackground = new SolidColorBrush(Color.Parse("#252526")),
                ToolbarBackground = new SolidColorBrush(Color.Parse("#1E1E1E")),
                CardBackground = new SolidColorBrush(Color.Parse("#2D2D2D")),
                CardHover = new SolidColorBrush(Color.Parse("#3D3D3D")),
                BorderBrush = new SolidColorBrush(Color.Parse("#3D3D3D")),
                StatusText = new SolidColorBrush(Color.Parse("#A0A0A0")),
                Accent = new SolidColorBrush(Color.Parse("#0078D4")),
                AccentLight = new SolidColorBrush(Color.Parse("#1E90FF")),
                AccentDark = new SolidColorBrush(Color.Parse("#005A9E"))
            },
            AppTheme.Dark => new ThemeResources
            {
                Background = new SolidColorBrush(Color.Parse("#121212")),
                Foreground = new SolidColorBrush(Color.Parse("#E0E0E0")),
                SecondaryForeground = new SolidColorBrush(Color.Parse("#B0B0B0")),
                TitleBarBackground = new SolidColorBrush(Color.Parse("#1E1E1E")),
                TitleBarForeground = new SolidColorBrush(Color.Parse("#E0E0E0")),
                TitleBarButtonHover = new SolidColorBrush(Color.Parse("#2D2D2D")),
                SidebarBackground = new SolidColorBrush(Color.Parse("#1E1E1E")),
                ToolbarBackground = new SolidColorBrush(Color.Parse("#252526")),
                CardBackground = new SolidColorBrush(Color.Parse("#1E1E1E")),
                CardHover = new SolidColorBrush(Color.Parse("#2D2D2D")),
                BorderBrush = new SolidColorBrush(Color.Parse("#3D3D3D")),
                StatusText = new SolidColorBrush(Color.Parse("#B0B0B0")),
                Accent = new SolidColorBrush(Color.Parse("#BB86FC")),
                AccentLight = new SolidColorBrush(Color.Parse("#D1C4E9")),
                AccentDark = new SolidColorBrush(Color.Parse("#3700B3"))
            },
            AppTheme.System => GetSystemTheme() == ThemeVariant.Dark ? GetThemeResources(AppTheme.Dark) : GetThemeResources(AppTheme.Light),
            _ => GetThemeResources(AppTheme.Light)
        };
    }

    private void ApplyResources(Avalonia.Application app, ThemeResources resources)
    {
        app.Resources["Theme.Background"] = resources.Background;
        app.Resources["Theme.Foreground"] = resources.Foreground;
        app.Resources["Theme.SecondaryForeground"] = resources.SecondaryForeground;
        app.Resources["Theme.TitleBarBackground"] = resources.TitleBarBackground;
        app.Resources["Theme.TitleBarForeground"] = resources.TitleBarForeground;
        app.Resources["Theme.TitleBarButtonHover"] = resources.TitleBarButtonHover;
        app.Resources["Theme.SidebarBackground"] = resources.SidebarBackground;
        app.Resources["Theme.ToolbarBackground"] = resources.ToolbarBackground;
        app.Resources["Theme.CardBackground"] = resources.CardBackground;
        app.Resources["Theme.CardHover"] = resources.CardHover;
        app.Resources["Theme.BorderBrush"] = resources.BorderBrush;
        app.Resources["Theme.StatusText"] = resources.StatusText;
        app.Resources["Theme.Accent"] = resources.Accent;
        app.Resources["Theme.AccentLight"] = resources.AccentLight;
        app.Resources["Theme.AccentDark"] = resources.AccentDark;
    }

    private ThemeVariant GetSystemTheme()
    {
        return ThemeVariant.Light;
    }
}

public class ThemeResources
{
    public IBrush Background { get; set; }
    public IBrush Foreground { get; set; }
    public IBrush SecondaryForeground { get; set; }
    public IBrush TitleBarBackground { get; set; }
    public IBrush TitleBarForeground { get; set; }
    public IBrush TitleBarButtonHover { get; set; }
    public IBrush SidebarBackground { get; set; }
    public IBrush ToolbarBackground { get; set; }
    public IBrush CardBackground { get; set; }
    public IBrush CardHover { get; set; }
    public IBrush BorderBrush { get; set; }
    public IBrush StatusText { get; set; }
    public IBrush Accent { get; set; }
    public IBrush AccentLight { get; set; }
    public IBrush AccentDark { get; set; }
}
