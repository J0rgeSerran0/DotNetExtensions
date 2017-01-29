namespace DotNetExtensions
{

    using System;

    public static class StringExtensions
    {

        public static bool ContainsCharacters(this string source, char[] characters, StringComparison stringComparison = StringComparison.Ordinal)
        {
            if (characters.Length == 0 || 
                String.IsNullOrEmpty(source))
            {
                return true;
            }

            foreach (var character in characters)
            {
                var text = String.Join(String.Empty, character);
                if (source.ContainsText(text, stringComparison))
                {
                    return true;
                }
            }

            return false;
        }

        public static bool ContainsText(this string source, string pattern, StringComparison stringComparison = StringComparison.Ordinal)
        {
            if (String.IsNullOrEmpty(pattern) ||
                String.IsNullOrEmpty(source) ||
                source.IndexOf(pattern, stringComparison) >= 0)
            {
                return true;
            }

            return false;
        }

        public static string Repeat(this char c, int count)
        {
            return new String(c, count);
        }

    }

}