using System;
using BerryAIGC.Common;
using System.Globalization;
using System.Windows.Data;
using BerryAIGC.Common.Query;

namespace BerryAIGC.Toolkit.Converters;

public class TagsModeConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return ((TagsMode)value).ToString() == (string)parameter;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return (string)parameter == "AND" ? TagsMode.AND : TagsMode.OR;
    }
}







