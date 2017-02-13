namespace DotNetExtensions
{

    using System;

    public static class NumericExtensions
    {

        public static bool IsPrime(this int value)
        {
            if (value == 1) return false;
            if (value == 2) return true;

            var boundary = (int)Math.Floor(Math.Sqrt(value));

            for (var i = 2; i <= boundary; ++i)
            {
                if (value % i == 0) return false;
            }

            return true;
        }

        public static decimal GetPercentageOf(this decimal value, decimal percent)
        {
            return (decimal)(value * percent / 100);
        }

        public static decimal GetPercentageOf(this decimal value, int percent)
        {
            return value.GetPercentageOf(Convert.ToDecimal(percent));
        }

    }

}