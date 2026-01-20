using System;
using BerryAIGC.Common;
using System.Globalization;
using System.Windows.Data;
using BerryAIGC.Toolkit.Common;

namespace BerryAIGC.Toolkit.Converters;

public class IECFormatConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value == null) return "";

        return FileUtility.ToIECPrefix((long)value).FormattedSize;
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}







