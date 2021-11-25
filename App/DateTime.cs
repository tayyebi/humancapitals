using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    static class DateTime
    {
        public static string DATE
        {
            get
            {
                var datetime = System.DateTime.Now;
                var persian = new PersianDateTime(datetime);
                var value = persian.ToString("yyyy-MM-dd");
                return value;
            }
        }
        public static string TIME
        {
            get
            {
                var datetime = System.DateTime.Now;
                var persian = new PersianDateTime(datetime);
                var value = persian.ToString("HH:mm:ss");
                return value;
            }
        }

        public static string AddDate(string date, int days)
        {
            var persianDate = Convert.ToInt32(IntExtensions.DigitsOnly(date));
            var shamsiDate = new PersianDateTime(persianDate);
            return shamsiDate.AddDays(days).ToString("yyyy-MM-dd");
        }

        public static int calculateShamsiDateDtsShiftInMinutes(string date)
        {
            var persianDate = Convert.ToInt32(IntExtensions.DigitsOnly(date));
            var shamsiDate = new PersianDateTime(persianDate);
            if (shamsiDate.Month < 7)
                return +1;
            return 0;
        }

        public static string AddTime(string time, int seconds)
        {
            return System.DateTime.ParseExact(time, "HH:mm:ss", CultureInfo.InvariantCulture).AddSeconds(seconds).ToString("HH:mm:ss", CultureInfo.InvariantCulture);
        }

    }

}
