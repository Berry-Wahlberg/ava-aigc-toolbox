using System;
using System.Globalization;
using Avalonia.Data.Converters;

namespace BerryAIGC.Toolkit.Converters;

public class IntToBoolConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is int intValue && parameter is int paramValue)
        {
            return intValue == paramValue;
        }
        return false;
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is bool boolValue && parameter is int paramValue)
        {
            return boolValue ? paramValue : 0;
        }
        return 0;
    }
}
