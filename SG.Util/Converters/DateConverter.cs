using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Data;

namespace SG.Util.Converters
{
    public class DateToMonthConverter : IValueConverter
    {
        // If this fails, it will return -1
        private int errorCode;
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value != null)
            {
                DateTime dateToMonth = (DateTime) value;
                return dateToMonth.ToString("MMM");
            }
            else
            {
                // Is this important enough to log, can we pass in the container to log?  UnitTest
                errorCode = -1;
                return errorCode;
            }

        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            string strValue = value as string;
            DateTime resultDateTime;
            if (DateTime.TryParse(strValue, out resultDateTime))
            {
                return resultDateTime;
            }
            throw new Exception("Unable to convert string to date time");
        }
    }
}
