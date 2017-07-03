namespace DotNetExtensions
{

    using System;

    public static class NumericExtensions
    {

        public static decimal GetPercentageOf(this decimal value, decimal percent)
        {
            return (decimal)(value * percent / 100);
        }

        public static decimal GetPercentageOf(this decimal value, int percent)
        {
            return value.GetPercentageOf(Convert.ToDecimal(percent));
        }

        public static bool IsEven(this int number)
        {
            return number % 2 == 0;
        }

        public static bool IsOdd(this int number)
        {
            return number % 2 != 0;
        }

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

        public static byte ToByte(this object value, byte defaultValue = 0)
        {
            byte result = 0;

            return (byte.TryParse(value.ToString(), out result) ? result : defaultValue);
        }

        public static decimal ToDecimal(this object value, decimal defaultValue = 0)
        {
            decimal result = 0;

            return (decimal.TryParse(value.ToString(), out result) ? result : defaultValue);
        }

        public static double ToDouble(this object value, double defaultValue = 0)
        {
            double result = 0;

            return (double.TryParse(value.ToString(), out result) ? result : defaultValue);
        }

        public static float ToFloat(this object value, float defaultValue = 0)
        {
            float result = 0;

            return (float.TryParse(value.ToString(), out result) ? result : defaultValue);
        }

        public static int ToInt32(this object value, int defaultValue = 0)
        {
            var result = 0;

            return (int.TryParse(value.ToString(), out result) ? result : defaultValue);
        }

        public static long ToInt64(this object value, long defaultValue = 0)
        {
            long result = 0;

            return (long.TryParse(value.ToString(), out result) ? result : defaultValue);
        }

        public static sbyte ToSByte(this object value, sbyte defaultValue = 0)
        {
            sbyte result = 0;

            return (sbyte.TryParse(value.ToString(), out result) ? result : defaultValue);
        }

        public static short ToShort(this object value, short defaultValue = 0)
        {
            short result = 0;

            return (short.TryParse(value.ToString(), out result) ? result : defaultValue);
        }

        public static uint ToUInt(this object value, uint defaultValue = 0)
        {
            uint result = 0;

            return (uint.TryParse(value.ToString(), out result) ? result : defaultValue);
        }

        public static ulong ToULong(this object value, ulong defaultValue = 0)
        {
            ulong result = 0;

            return (ulong.TryParse(value.ToString(), out result) ? result : defaultValue);
        }

        public static ushort ToUShort(this object value, ushort defaultValue = 0)
        {
            ushort result = 0;

            return (ushort.TryParse(value.ToString(), out result) ? result : defaultValue);
        }

    }

}