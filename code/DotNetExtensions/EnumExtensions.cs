namespace DotNetExtensions
{

    using System;

    public static class EnumExtensions
    {

        public static bool IsValid<T>(this string value) where T : struct
        {
            try
            {
                var enumType = (T)Enum.Parse(typeof(T), value, true);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static T ToEnum<T>(this string value)
            where T : struct
        {
            var enumObject = default(T);

            return (Enum.TryParse(value, out enumObject) ? enumObject : default(T));
        }

    }

}