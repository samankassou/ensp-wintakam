using System.Globalization;

namespace Wintakam.Converters
{
    public class FavoriConverter : IValueConverter
    {
        public object Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value is bool estFavori)
            {
                return estFavori ? "❤️" : "🤍";
            }
            return "🤍";
        }

        public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
