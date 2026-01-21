using Avalonia.Styling;

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
    }

    private ThemeVariant GetSystemTheme()
    {
        // TODO: Implement system theme detection for each platform
        return ThemeVariant.Light;
    }
}
