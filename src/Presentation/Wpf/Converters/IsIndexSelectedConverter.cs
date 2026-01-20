using System;
using BerryAIGC.Common;
using System.Globalization;
using System.Windows.Data;

namespace BerryAIGC.Toolkit.Converters;

public class IsIndexSelectedConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        return (int)value > -1;
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}







