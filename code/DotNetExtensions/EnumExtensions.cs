namespace DotNetExtensions
{

    using System;
    using System.ComponentModel;

    public static class EnumExtensions
    {

        public static string GetDescriptionFromEnum(this Enum value)
        {
            var fieldInfo = value.GetType().GetField(value.ToString());

            DescriptionAttribute[] attributes =
                (DescriptionAttribute[])fieldInfo.GetCustomAttributes(
                typeof(DescriptionAttribute),
                false);

            if (attributes != null &&
                attributes.Length > 0)
            {
                return attributes[0].Description;
            }
            else
            {
                return value.ToString();
            }
        }

        public static T GetEnumFromDescription<T>(this string description)
        {
            var type = typeof(T);

            if (!type.IsEnum)
            {
                throw new InvalidOperationException();
            }

            foreach (var field in type.GetFields())
            {
                var attribute = Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) as DescriptionAttribute;

                if (attribute != null)
                {
                    if (attribute.Description == description)
                    {
                        return (T)field.GetValue(null);
                    }
                }
                else
                {
                    if (field.Name == description)
                    {
                        return (T)field.GetValue(null);
                    }
                }
            }

            return default(T);
        }

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