using System;
using System.Globalization;
using System.Windows.Data;

namespace UT4_Actividad4
{
    public class BordeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value is bool)
            {
                if((bool)value == true)
                {
                    return 3;
                }
            }
            return 0;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value is bool)
            {
                if((bool)value == false)
                {
                    return 0;
                }
            }
            return 3;
        }
    }
}
