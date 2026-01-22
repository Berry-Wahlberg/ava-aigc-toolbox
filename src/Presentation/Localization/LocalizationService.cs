using Avalonia.Styling;

namespace BerryAIGC.Toolkit.Localization;

public interface ILocalizationService
{
    string GetString(string key);
    event EventHandler? LanguageChanged;
}

public class LocalizationService : ILocalizationService
{
    private readonly Dictionary<string, string> _resources = new();
    private string _currentLanguage = "en-US";

    public LocalizationService()
    {
        LoadResources("en-US");
    }

    public string GetString(string key)
    {
        return _resources.TryGetValue(key, out var value) ? value : key;
    }

    public void SetLanguage(string language)
    {
        if (_currentLanguage != language)
        {
            _currentLanguage = language;
            LoadResources(language);
            LanguageChanged?.Invoke(this, EventArgs.Empty);
        }
    }

    private void LoadResources(string language)
    {
        _resources.Clear();
        
        // Load resources based on language
        // TODO: Load from JSON files or embedded resources
        
        if (language == "en-US")
        {
            _resources["App.Title"] = "Berry AIGC Toolbox";
            _resources["Search.Title"] = "Search";
            _resources["Settings.Title"] = "Settings";
            _resources["Models.Title"] = "Models";
            _resources["Prompts.Title"] = "Prompts";
        }
        else if (language == "zh-CN")
        {
            _resources["App.Title"] = "Berry AIGC 工具箱";
            _resources["Search.Title"] = "搜索";
            _resources["Settings.Title"] = "设置";
            _resources["Models.Title"] = "模型";
            _resources["Prompts.Title"] = "提示词";
        }
    }
}
