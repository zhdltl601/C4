using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfBomb
{
    public static class TimeUtility
    {
        public const string DEFAULT_TIME = "00:00";
        public static string ConvertTimeToString(in int hour, in int minute)
        {
            return string.Format("{0:D2}:{1:D2}", hour, minute);
        }
        public static void ConvertTimeToBase60(in int hour, in int minute, out int rHour, out int rMinute)
        {
            rMinute = minute;
            rHour = hour;
            int minuteBase60 = MathfUtility.Base60(rMinute);
            rMinute -= 60 * minuteBase60;
            rHour += minuteBase60;
            rHour = Math.Min(rHour, 99);
        }

    }
}
