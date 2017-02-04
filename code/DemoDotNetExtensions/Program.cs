namespace DemoDotNetExtensions
{

    using DotNetExtensions;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Globalization;

    public class Program
    {

        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            var title = "Demo - DotNetExtensions";


            // ************************************
            // StringExtensions
            // ************************************
            // Repeat
            Console.WriteLine('-'.Repeat(title.Length));
            Console.WriteLine(title);
            Console.WriteLine('-'.Repeat(23));
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("StringExtensions");
            Console.ForegroundColor = ConsoleColor.White;
            var text = "Sample.here";
            char[] characters = { ',', 'H' };
            // ContainsCharacters
            Console.WriteLine("ContainsCharacters => " + text.ContainsCharacters(characters, StringComparison.OrdinalIgnoreCase));
            // ContainsText
            Console.WriteLine("ContainsText => " + text.ContainsText("Her", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine();
            // ************************************



            // ************************************
            // CollectionExtensions
            // ************************************
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("CollectionExtensions");
            Console.ForegroundColor = ConsoleColor.White;
            // IsNullOrEmpty
            var data = new List<string>();
            Console.WriteLine("IsNullOrEmpty => " + data.IsNullOrEmpty<string>());
            // IsNullOrEmptyAsync
            Console.WriteLine("IsNullOrEmptyAsync => " + data.IsNullOrEmptyAsync<string>().Result);
            Console.WriteLine();
            // ************************************



            // ************************************
            // ColorExtensions
            // ************************************
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("ColorExtensions");
            Console.ForegroundColor = ConsoleColor.White;
            // IsHexCode
            var hexCode = "00FF00";
            Console.WriteLine($"IsHexCode {hexCode} => " + hexCode.IsHexCode());
            // ToColor
            Color color = hexCode.ToColor().Value;
            Console.WriteLine("ToColor => " + color);
            // ToHexCode
            Console.WriteLine("ToHexCode => " + color.ToHexCode());
            Console.WriteLine();
            // ************************************



            // ************************************
            // DateTimeExtensions
            // ************************************
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("DateTimeExtensions");
            Console.ForegroundColor = ConsoleColor.White;
            // CalculateAge
            var apollo11MoonDateTime = new DateTime(1969, 7, 20);
            Console.WriteLine("CalculateAge => " + apollo11MoonDateTime.CalculateAge());
            // CalculateAgeWithPrecision
            Console.WriteLine("CalculateAgeWithPrecision => " + apollo11MoonDateTime.CalculateAgeWithPrecision());
            // IsDate
            object dateTimeObject = "02/21/2017";
            Console.WriteLine($"Is valid date {dateTimeObject} for en-UK? => " + dateTimeObject.IsDate(new CultureInfo("en-UK")));
            dateTimeObject = "21/02/2017";
            Console.WriteLine($"Is valid date {dateTimeObject} for es-ES? => " + dateTimeObject.IsDate(new CultureInfo("es-ES")));
            // IsWeekend
            var dateTimeNow = DateTime.Now;
            Console.WriteLine($"{dateTimeNow} is weekend? " + dateTimeNow.IsWeekend());
            Console.WriteLine();
            // ************************************



            // ************************************
            // EnumExtensions
            // ************************************
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("EnumExtensions");
            Console.ForegroundColor = ConsoleColor.White;
            // IsValid
            var stringDemoType = "Twoo";
            var result = stringDemoType.IsValid<DemoType>();
            Console.WriteLine($"IsValid => {stringDemoType} = {result}");
            stringDemoType = "Two";
            result = stringDemoType.IsValid<DemoType>();
            Console.WriteLine($"IsValid => {stringDemoType} = {result}");
            // ToEnum
            var demoType = DemoType.One;
            Console.WriteLine($"Original value => {demoType}");
            stringDemoType = "Twoo";
            demoType = stringDemoType.ToEnum<DemoType>();
            Console.WriteLine($"ToEnum => {stringDemoType} as {demoType}");
            stringDemoType = "Two";
            demoType = stringDemoType.ToEnum<DemoType>();
            Console.WriteLine($"ToEnum => {stringDemoType} as {demoType}");
            Console.WriteLine();
            // ************************************



            // ************************************
            // ExceptionExtensions
            // ************************************
            try
            {
                DemoExceptionExtensions.GenerateException();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("ExceptionExtensions");
                Console.ForegroundColor = ConsoleColor.White;
                var info = ex.GetMessagesFromInnerExceptions().ToString();
                Console.WriteLine(info);
                Console.WriteLine();
            }
            // ************************************



            // ************************************
            // NumericExtensions
            // ************************************
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("NumericExtensions");
            Console.ForegroundColor = ConsoleColor.White;
            // IsPrime
            var number = 7;
            Console.WriteLine($"IsPrime {number} => " + number.IsPrime());
            Console.WriteLine();


            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Press any key to close the App");
            Console.ReadLine();
        }

    }

    public enum DemoType
    {
        One,
        Two,
        Three
    }

}