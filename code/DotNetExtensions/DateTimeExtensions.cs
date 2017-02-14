namespace DotNetExtensions
{

    using System;
    using System.Globalization;

    public static class DateTimeExtensions
    {

        private static double CommonCalculateAge(DateTime dateTime, DateTime? dateTimeToCompare)
        {
            var dateTimeNow = dateTimeToCompare ?? DateTime.UtcNow;

            if (dateTimeToCompare > dateTime)
            {
                dateTimeNow = DateTime.UtcNow;
            }

            if (dateTime.Year == dateTimeNow.Year)
            {
                return 0;
            }

            var actual = Convert.ToInt32(dateTimeNow.ToString("yyyyMMdd"));
            var old = Convert.ToInt32(dateTime.ToString("yyyyMMdd"));

            return (double)(actual - old) / 10000;
        }

        public static int CalculateAge(this DateTime dateTime, DateTime? dateTimeToCompare = null)
        {
            return (int)CommonCalculateAge(dateTime, dateTimeToCompare);
        }

        public static double CalculateAgeWithPrecision(this DateTime dateTime, DateTime? dateTimeToCompare = null)
        {
            return CommonCalculateAge(dateTime, dateTimeToCompare);
        }

        public static TimeSpan Days(this int days)
        {
            return TimeSpan.FromDays(days);
        }

        public static TimeSpan ElapsedUntilToday(this DateTime datetime)
        {
            return DateTime.Now - datetime;
        }

        public static TimeSpan ElapsedUtcUntilToday(this DateTime datetime)
        {
            return DateTime.UtcNow - datetime;
        }

        public static TimeSpan ElapsedWith(this DateTime datetime, DateTime dateTimeToCompare)
        {
            return dateTimeToCompare - datetime;
        }

        public static TimeSpan Hours(this int hours)
        {
            return TimeSpan.FromHours(hours);
        }

        public static bool IsBetweenDates(this DateTime dateTimeToCheck, DateTime lowerRange, DateTime upperRange)
        {
            return dateTimeToCheck.Ticks >= lowerRange.Ticks && dateTimeToCheck.Ticks <= upperRange.Ticks;
        }

        public static bool IsDate(this object data, CultureInfo culture)
        {
            if (data == null ||
                culture == null)
            {
                return false;
            }

            DateTime newDate;
            var styles = DateTimeStyles.None;

            return DateTime.TryParse(data.ToString(), culture, styles, out newDate);
        }

        public static bool IsWeekend(this DateTime dateTime)
        {
            return (dateTime.DayOfWeek == DayOfWeek.Saturday ||
                    dateTime.DayOfWeek == DayOfWeek.Sunday);
        }

        public static bool IsWorkingDay(this DateTime dateTime)
        {
            return !(dateTime.IsWeekend());
        }

        public static TimeSpan Minutes(this int minutes)
        {
            return TimeSpan.FromMinutes(minutes);
        }

        public static DateTime NextWorkingDay(this DateTime dateTime)
        {
            var nextWorkingDay = dateTime;

            while (!nextWorkingDay.IsWorkingDay())
            {
                nextWorkingDay = nextWorkingDay.AddDays(1);
            }

            return nextWorkingDay;
        }

        public static TimeSpan Seconds(this int seconds)
        {
            return TimeSpan.FromSeconds(seconds);
        }

    }

}