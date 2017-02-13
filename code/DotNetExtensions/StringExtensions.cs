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

        public static bool IsAsPattern(this string source, string pattern)
        {
            if (source == null ||
                String.IsNullOrEmpty(pattern))
            {
                return false;
            }

            var regexPattern = "^" + Regex.Escape(pattern) + "$";

            regexPattern = regexPattern.Replace(@"\[!", "[^")
                                       .Replace(@"\[", "[")
                                       .Replace(@"\]", "]")
                                       .Replace(@"\?", ".")
                                       .Replace(@"\*", ".*")
                                       .Replace(@"\#", @"\d");

            try
            {
                return Regex.IsMatch(source, regexPattern);
            }
            catch (ArgumentException ex)
            {
                throw new ArgumentException($"Invalid pattern: {pattern}", ex);
            }
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

        public static string Repeat(this char character, int count)
        {
            return new String(character, count);
        }

        public static string Reverse(this string source)
        {
            var characters = source.ToCharArray();

            Array.Reverse(characters);

            return new string(characters);
        }

        public static string StringFormatWith(this string source, params object[] parameters)
        {
            if (source == null)
            {
                return source;
            }

            return String.Format(source, parameters);
        }

        public static string ToEmptyIfNull(this string source)
        {
            return source ?? String.Empty;
        }

        public static string ToSlug(this string source, char slugCharacter = '-')
        {
            source = source.ReplaceDiacritics();

            var bytes = Encoding.GetEncoding("Cyrillic").GetBytes(source);

            return Regex.Replace(Regex.Replace(Encoding.ASCII.GetString(bytes), @"\s{2,}|[^\w]", " ", RegexOptions.ECMAScript).Trim(), @"\s+", slugCharacter.ToString()).ToLowerInvariant();
        }
        
        public static string TruncateWith(this string source, int maxLength, string pattern = "...")
        {
            if (source == null)
            {
                return source;
            }

            var sourceLength = source.Length;

            if (maxLength > sourceLength)
            {
                if (pattern.Length > sourceLength)
                {
                    return source;
                }

                maxLength = sourceLength - pattern.Length;
            }

            return source.Substring(0, maxLength).TrimEnd() + pattern;
        }

    }

}