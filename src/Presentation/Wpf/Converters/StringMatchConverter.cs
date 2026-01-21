using System;
using BerryAIGC.Common;
using System.Globalization;
using System.Windows.Data;

namespace BerryAIGC.Toolkit.Converters;

public class StringMatchConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return ((string)value) == ((string)parameter);
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}







