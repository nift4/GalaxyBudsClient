using System;
using System.Globalization;
using Avalonia.Data.Converters;

namespace GalaxyBudsClient.Utils.Converters
{
    public class MonthValueConverter : IValueConverter
    {
        public static MonthValueConverter Instance = new();

        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            return value switch
            {
                null => null,
                int num /*when targetType == typeof(string)*/ =>
                    CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(num),
                _ => throw new NotSupportedException()
            };
        }

        public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}