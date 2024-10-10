using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WpfAppGlobalizationLocalization1
{
    internal class CalendarTypeToCalendarInformationConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var c = value as Calendar;
            if (c == null) return null;
            var callText = new StringBuilder(50);
            callText.Append(c.ToString());
            callText.Remove(0, 21);
            callText.Replace("Calendar", "");

            GregorianCalendar gregCal = c as GregorianCalendar;
            if(gregCal != null)
                callText.Append($" {gregCal.CalendarType}");

            return callText.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
