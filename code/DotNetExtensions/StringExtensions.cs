namespace DotNetExtensions
{

    using System;
    using System.Globalization;
    using System.IO;
    using System.Text;
    using System.Text.RegularExpressions;

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

        public static Stream ConvertToStream(this string source)
        {
            var byteArray = Encoding.UTF8.GetBytes(source);

            return new MemoryStream(byteArray);
        }

        public static int CountWords(this string source)
        {
            if (source == null)
            {
                return 0;
            }

            var delimiters = new char[] { ' ', '\r', '\n' };

            return source.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static bool IsString(this object @object)
        {
            if (@object == null)
            {
                return false;
            }

            return @object.GetType().Equals(typeof(string));
        }

        public static string ReplaceDiacritics(this string source)
        {
            var normalizedString = source.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();

            foreach (var character in normalizedString)
            {
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(character);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(character);
                }
            }

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }

        public static string RemoveFirstCharacters(this string source, int numberOfCharacters)
        {
            if (numberOfCharacters < 0)
            {
                return source;
            }

            var length = source.Length;

            numberOfCharacters = (numberOfCharacters > length ? length : numberOfCharacters);

            return source.Substring(numberOfCharacters);
        }

        public static string RemoveLastCharacters(this string source, int numberOfCharacters)
        {
            if (numberOfCharacters < 0)
            {
                return source;
            }

            var length = source.Length;

            numberOfCharacters = (numberOfCharacters > length ? length : numberOfCharacters);

            return source.Substring(0, length - numberOfCharacters);
        }

        public static string Repeat(this char c, int count)
        {
            return new String(c, count);
        }

        public static string ToEmptyIfNull(this string source)
        {
            return source ?? String.Empty;
        }

        public static string ToSlug(this string text, char slugCharacter = '-')
        {
            text = text.ReplaceDiacritics();

            var bytes = Encoding.GetEncoding("Cyrillic").GetBytes(text);

            return Regex.Replace(Regex.Replace(Encoding.ASCII.GetString(bytes), @"\s{2,}|[^\w]", " ", RegexOptions.ECMAScript).Trim(), @"\s+", slugCharacter.ToString()).ToLowerInvariant();
        }

    }

}