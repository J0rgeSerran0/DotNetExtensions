namespace DotNetExtensions
{

    using System.Text.RegularExpressions;

    public static class SocialExtensions
    {

        private static bool ExecuteRegexExpression(string source, string regexExpression)
        {
            return new Regex(regexExpression).IsMatch(source);
        }

        public static bool IsValidEmail(this string source)
        {
            var regexExpression = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";

            return ExecuteRegexExpression(source, regexExpression);
        }

        public static bool IsValidFtp(this string source)
        {
            var regexExpression = @"ftp(s)?://([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?";

            return ExecuteRegexExpression(source, regexExpression);
        }

        public static bool IsValidUrl(this string source)
        {
            var regexExpression = @"http(s)?://([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?";

            return ExecuteRegexExpression(source, regexExpression);
        }

    }

} 