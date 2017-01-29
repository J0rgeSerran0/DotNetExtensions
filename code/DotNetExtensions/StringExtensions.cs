namespace DotNetExtensions
{

    using System;

    public static class StringExtensions
    {

        public static string Repeat(this char c, int count)
        {
            return new String(c, count);
        }

    }

}