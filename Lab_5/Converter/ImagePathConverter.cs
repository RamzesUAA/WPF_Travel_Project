using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace Lab_5.Convertor
{
    public class ImagePathConverter : IValueConverter
    {
        private Dictionary<string, BitmapImage> cache = new Dictionary<string, BitmapImage>();
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var isAvailable = (bool)value;
            if (!cache.ContainsKey(isAvailable.ToString()))
            {
                var iconPath = isAvailable ? "check" : "uncheck";
                var uri = new Uri(string.Format(@"../Resources/Images/{0}.png", iconPath), UriKind.Relative);
                cache.Add(isAvailable.ToString(), new BitmapImage(uri));
            }

            return cache[isAvailable.ToString()];

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
