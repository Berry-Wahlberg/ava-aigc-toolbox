using System;
using BerryAIGC.Common;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace BerryAIGC.Toolkit.Converters;

public class StretchConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return (bool)value ? Stretch.Uniform : Stretch.None;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}







