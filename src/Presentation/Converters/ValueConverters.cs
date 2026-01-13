using System;
using System.Globalization;
using System.IO;
using Avalonia.Data.Converters;
using AIGenManager.Core.Domain.Entities;

namespace BerryAIGCToolbox.Converters;

public class IsNullConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        return value == null || (value is string str && string.IsNullOrEmpty(str));
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}

public class IsNotNullConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        return value != null;
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}

public class StringToUriConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is string path && !string.IsNullOrEmpty(path))
        {
            try
            {
                if (Path.IsPathRooted(path))
                {
                    // For absolute paths in Avalonia, we need to use the file:/// scheme
                    var uriPath = path.Replace('\\', '/');
                    return new Uri($"file:///{uriPath}", UriKind.Absolute);
                }
                return new Uri(path, UriKind.Relative);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error converting path to URI: {ex.Message}");
                return null;
            }
        }
        return null;
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}


