using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Konwertery.NaszKonwertery
{
    class BoolToDescriptionConverter: IValueConverter
    {
        //z kodu/właściwości do widoku
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool)
            {
                bool wartosc = (bool) value;
                return wartosc ? "Kontrolka zaznaczona" : "Kontrolka odznaczona";
            }

            return Binding.DoNothing;
        }

        //z widoku do kodu/właściwości
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
