using System;

namespace Passenger.Infrastructure.Extensions
{
    public static class DateTimeExtensions
    {
        public static long ToTimeStamp(this DateTime datetime)
        {
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0);
            var time = datetime.Subtract(new TimeSpan(epoch.Ticks));
            return time.Ticks / 10000;
        }
    }
}