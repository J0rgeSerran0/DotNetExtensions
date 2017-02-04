namespace DotNetExtensions
{

    using System;
    using System.Drawing;
    using System.Globalization;

    public static class ColorExtensions
    {

        private static string ToHexCode(byte r, byte g, byte b)
        {
            return String.Format(CultureInfo.InvariantCulture, "{0:X2}{1:X2}{2:X2}", r, g, b);
        }

        public static bool IsHexCode(this string hexCode)
        {
            int value;
            Int32.TryParse(hexCode, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out value);

            if (value != 0 ||
                (value == 0 &&
                hexCode == "000000"))
            {
                return true;
            }

            return false;
        }

        public static Color? ToColor(this string hexCode)
        {

            if (String.IsNullOrEmpty(hexCode) ||
                !hexCode.IsHexCode())
            {
                return null;
            }

            int r, g, b = 0;

            // factor 1 for hexCode with 3 characters
            // factor 2 for hexCode with 6 characters
            int factor = 1;

            if (hexCode.Length == 6)
            {
                factor = 2;
            }

            r = Int32.Parse(hexCode.Substring(0 * factor, 1 * factor), NumberStyles.AllowHexSpecifier);
            g = Int32.Parse(hexCode.Substring(1 * factor, 1 * factor), NumberStyles.AllowHexSpecifier);
            b = Int32.Parse(hexCode.Substring(2 * factor, 1 * factor), NumberStyles.AllowHexSpecifier);

            if ((r < 0 || r > 255) ||
                (g < 0 || g > 255) ||
                (b < 0 || b > 255))
            {
                return null;
            }

            return Color.FromArgb(r, g, b);
        }

        public static string ToHexCode(this Color color)
        {
            return ToHexCode(color.R, color.G, color.B);
        }

    }

}