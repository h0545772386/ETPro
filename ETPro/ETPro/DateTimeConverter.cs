using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace ETPro
{
    class DateTimeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null || value.ToString().Length < 8) return DateTime.Now.Date;
            if (value is int val)
            {
                if (value.ToString().Length == 8)
                {
                    //YYYYMMDD
                    int year = val / 10000;
                    int month = (val / 100) % 100;
                    int day = val % 100;
                    return new DateTime(year, month, day);
                }
            }
            else if (value is long valLong)
            {
                if (value.ToString().Length == 12)
                {
                    //YYYYMMDDHHMM
                    int year = (int)(valLong / 100000000);
                    int month = (int)((valLong / 1000000) % 100);
                    int day = (int)((valLong / 10000) % 100);
                    int hour = (int)((valLong / 100) % 100);
                    int minit = (int)(valLong % 100);
                    DateTime dateTime = new DateTime(year, month, day, hour, minit, 0);
                    return dateTime;
                }
            }


            return DateTime.Now.Date;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null || value.ToString() == "")
                return 0;
            if (DateTime.TryParse(value.ToString(), out DateTime dt))
            {
                if (parameter.ToString() == "date")
                {
                    string str = dt.Year.ToString("D4") + dt.Month.ToString("D2") + dt.Day.ToString("D2");
                    return int.Parse(str);
                }
                else if (parameter.ToString() == "time")
                {
                    string str = dt.Year.ToString("D4") + dt.Month.ToString("D2") + dt.Day.ToString("D2") + dt.Hour.ToString("D2") + dt.Minute.ToString("D2");
                    return long.Parse(str);
                }
            }
            return 0;

        }
    }
}
