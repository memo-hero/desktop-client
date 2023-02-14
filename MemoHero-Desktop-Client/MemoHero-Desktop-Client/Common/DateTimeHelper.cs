using System;

namespace MemoHeroDesktopClient.Common
{
    static internal class DateTimeHelper
    {
        internal static DateTime EpochToDateTime(long unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            var dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dateTime = dateTime.AddDays(unixTimeStamp).ToLocalTime();
            return dateTime;
        }

        internal static int DateTimeToEpoch(DateTime dateTime)
        {
            var epochBase = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            return (int)dateTime.Subtract(epochBase).TotalDays;
        }
    }
}
