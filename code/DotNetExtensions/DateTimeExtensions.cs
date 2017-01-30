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

        public static bool IsDate(this object element, CultureInfo culture)
        {
            if (element == null ||
                            culture == null)
            {
                return false;
            }

            DateTime newDate;
            var styles = DateTimeStyles.None;

            return DateTime.TryParse(element.ToString(), culture, styles, out newDate);
        }

        public static bool IsWeekend(this DateTime dateTime)
        {
            return (dateTime.DayOfWeek == DayOfWeek.Saturday ||
                    dateTime.DayOfWeek == DayOfWeek.Sunday);
        }

    }

}