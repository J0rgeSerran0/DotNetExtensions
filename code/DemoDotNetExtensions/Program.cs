namespace DemoDotNetExtensions
{

    using DotNetExtensions;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
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
            // CountWords
            text = "This is a sample of seven " + Environment.NewLine + "  words";
            Console.WriteLine($"CountWords => {text} => {text.CountWords()}");
            // IsString
            text = "Another text sample";
            Console.WriteLine($"IsString => {text} => {text.IsString()}");
            Console.WriteLine();
            // ************************************



            // ************************************
            // CollectionExtensions
            // ************************************
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("CollectionExtensions");
            Console.ForegroundColor = ConsoleColor.White;
            // Clone
            var collection = new List<string>() { "One", "2", "Three" };
            var collection2 = collection.Clone<string>();
            collection2.Add("4");
            foreach (var item in collection)
            {
                Console.WriteLine($"Clone => " + item);
            }
            Console.WriteLine("...");
            foreach (var item in collection2)
            {
                Console.WriteLine($"Clone => " + item);
            }
            // IsNull
            List<string> data = null;
            Console.WriteLine("IsNull => " + data.IsNull<string>());
            // IsNullAsync
            Console.WriteLine("IsNullAsync => " + data.IsNullAsync<string>().Result);
            // IsNullOrEmpty
            data = new List<string>();
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
            // GetDescriptionFromEnum
            var demoType = DemoType.One;
            var enumDescription = demoType.GetDescriptionFromEnum();
            Console.WriteLine($"GetDescriptionFromEnum => {enumDescription}");
            // GetEnumFromDescription
            var descriptionEnumType = "TwoFoo";
            demoType = descriptionEnumType.GetEnumFromDescription<DemoType>();
            Console.WriteLine($"GetEnumFromDescription => {demoType}");
            // IsValid
            var stringDemoType = "Twoo";
            var result = stringDemoType.IsValid<DemoType>();
            Console.WriteLine($"IsValid => {stringDemoType} = {result}");
            stringDemoType = "Two";
            result = stringDemoType.IsValid<DemoType>();
            Console.WriteLine($"IsValid => {stringDemoType} = {result}");
            // ToEnum
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
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("ExceptionExtensions");
            Console.ForegroundColor = ConsoleColor.White;
            // GetMessagesFromInnerExceptions
            try
            {
                DemoExceptionExtensions.GenerateException();
            }
            catch (Exception ex)
            {
                var info = ex.GetMessagesFromInnerExceptions().ToString();
                Console.WriteLine($"GetMessagesFromInnerExceptions => {info}");
            }
            // ToException
            var @object = new Object();
            var exception = @object.ToException<InvalidCastException>("foo exception text");
            var information = exception.GetMessagesFromInnerExceptions().ToString();
            Console.WriteLine($"ToException => {information}");
            // ThrowIfNull
            @object = null;
            try
            {
                @object.ThrowIfNull<object>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ThrowIfNull => {ex.GetMessagesFromInnerExceptions().ToString()}");
            }
            Console.WriteLine();
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



            // ************************************
            // RandomExtensions
            // ************************************
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("RandomExtensions");
            Console.ForegroundColor = ConsoleColor.White;
            // Shuffle (integer values)
            List<int> numbers = null;
            var cards = numbers.Shuffle(1, 12);
            if (cards != null)
            {
                foreach (var card in cards)
                {
                    Console.WriteLine($"Shuffle (int values) => {card}");
                }
            }
            // Shuffle (collection items)
            var names = new List<string>() { "Paul", "Jose", "Adams", "Leticia", "Mary" };
            foreach (var item in names)
            {
                Console.WriteLine($"Shuffle (collection items) [original value] => {item}");
            }
            names.Shuffle();
            foreach (var item in names)
            {
                Console.WriteLine($"Shuffle (collection items) [shuffle value] => {item}");
            }
            Console.WriteLine();


            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Press any key to close the App");
            Console.ReadLine();
        }

    }

    public enum DemoType
    {
        [Description("OneFoo")]
        One,
        [Description("TwoFoo")]
        Two,
        Three
    }

}