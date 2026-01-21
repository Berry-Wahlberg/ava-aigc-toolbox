namespace BerryAIGC.Toolkit.Configuration;
using BerryAIGC.Common;

public class SettingChangedEventArgs
{
    public string SettingName { get; set; }
    public object? OldValue { get; set; }
    public object? NewValue { get; set; }
}







