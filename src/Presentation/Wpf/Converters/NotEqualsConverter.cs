using System;
using BerryAIGC.Common;
using System.Globalization;
using System.Windows.Data;

namespace BerryAIGC.Toolkit.Converters;

public class NotEqualsConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        return !value.ToString().Equals(parameter);
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}







