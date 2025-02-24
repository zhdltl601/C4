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
        public static string ConvertTimeToString(in uint hour, in uint minute)
        {
            return string.Format("{0:D2}:{1:D2}", hour, minute);
        }
        public static void ConvertTimeToBase60(in uint hour, in uint minute, out uint rHour, out uint rMinute)
        {
            rMinute = minute;
            rHour = hour;
            uint minuteBase60 = MathfUtility.Base60(rMinute);
            rMinute -= 60 * minuteBase60;
            rHour += minuteBase60;
            rHour = Math.Min(rHour, 99);
        }

    }
}
