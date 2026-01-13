using System;
using System.Globalization;
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

public class ThumbnailLoadStatusConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        bool inverted = parameter?.ToString() == "Inverted";
        
        if (value is ThumbnailLoadStatus status)
        {
            bool shouldShow = status switch
            {
                ThumbnailLoadStatus.NotLoaded => true,
                ThumbnailLoadStatus.Loading => true,
                ThumbnailLoadStatus.Failed => true,
                _ => false
            };
            return inverted ? !shouldShow : shouldShow;
        }
        return inverted ? false : true;
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}

public class ThumbnailLoadingConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is ThumbnailLoadStatus status)
        {
            return status == ThumbnailLoadStatus.Loading;
        }
        return false;
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
