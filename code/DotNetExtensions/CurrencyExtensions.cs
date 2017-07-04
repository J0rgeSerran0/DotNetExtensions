namespace DotNetExtensions
{

    using System;
    using System.Globalization;

    public static class CurrencyExtensions 
    {

        public static string ToCurrency(this decimal value, string cultureName)
        {
            var currentCulture = new CultureInfo(cultureName);

            return String.Format(currentCulture, "{0:C}", value);
        }

    }

}