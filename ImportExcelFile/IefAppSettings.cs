using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Globalization;

namespace ImportExcelFile
{
    public class IefAppSettings
    {
        public string AppName { get; set; }
        public string DbConnection { get; set; }

        public static CultureInfo CurCulture()
        {
            CultureInfo.CurrentCulture = new CultureInfo("en-US");
            CultureInfo _CurCulture = CultureInfo.CurrentCulture;
            return _CurCulture;
        }

        public static int WeekOfYear(CultureInfo Culture, DateTime dt)
        {
            DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;
            Calendar cal = dfi.Calendar;

            int _wkOfYear = cal.GetWeekOfYear(dt, dfi.CalendarWeekRule,
                                          dfi.FirstDayOfWeek);

            return _wkOfYear;
        }

    }
}
