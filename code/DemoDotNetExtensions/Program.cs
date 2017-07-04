namespace DemoDotNetExtensions
{

    using DotNetExtensions;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Globalization;
    using System.Linq;
    using System.Text;

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
            // ConvertToStream
            text = "Foo text";
            var stream = text.ConvertToStream();
            Console.WriteLine($"ConvertToStream => {text}");
            // CountWords
            text = "This is a sample of seven. " + Environment.NewLine + "  words";
            Console.WriteLine($"CountWords => {text} => {text.CountWords()}");
            // IsAsPattern
            text = "abc";
            var pattern = "Ab*";
            Console.WriteLine($"IsAsPattern => {text} ({pattern}) => {text.IsAsPattern(pattern)}");
            text = "abc";
            pattern = "ab*";
            Console.WriteLine($"IsAsPattern => {text} ({pattern}) => {text.IsAsPattern(pattern)}");
            text = "abc";
            pattern = "a*c";
            Console.WriteLine($"IsAsPattern => {text} ({pattern}) => {text.IsAsPattern(pattern)}");
            text = "abc";
            pattern = "a?";
            Console.WriteLine($"IsAsPattern => {text} ({pattern}) => {text.IsAsPattern(pattern)}");
            text = "abc";
            pattern = "a??";
            Console.WriteLine($"IsAsPattern => {text} ({pattern}) => {text.IsAsPattern(pattern)}");
            text = "a1c";
            pattern = "*#?";
            Console.WriteLine($"IsAsPattern => {text} ({pattern}) => {text.IsAsPattern(pattern)}");
            text = "a1cd";
            pattern = "*#?";
            Console.WriteLine($"IsAsPattern => {text} ({pattern}) => {text.IsAsPattern(pattern)}");
            text = "ABc";
            pattern = "[A-Z][a-z][a-z]";
            Console.WriteLine($"IsAsPattern => {text} ({pattern}) => {text.IsAsPattern(pattern)}");
            text = "Abc";
            pattern = "[A-Z][a-z][a-z]";
            Console.WriteLine($"IsAsPattern => {text} ({pattern}) => {text.IsAsPattern(pattern)}");
            text = "Abcd";
            pattern = "[A-Z][a-z][a-z]";
            Console.WriteLine($"IsAsPattern => {text} ({pattern}) => {text.IsAsPattern(pattern)}");
            text = "ABc2";
            pattern = "[A-Z][A-Z][a-z][0-2]";
            Console.WriteLine($"IsAsPattern => {text} ({pattern}) => {text.IsAsPattern(pattern)}");
            text = "ABc3";
            pattern = "[A-Z][A-Z][a-z][0-2]";
            Console.WriteLine($"IsAsPattern => {text} ({pattern}) => {text.IsAsPattern(pattern)}");
            // IsString
            text = "Another text sample";
            Console.WriteLine($"IsString => {text} => {text.IsString()}");
            // RemoveFirstCharacters
            text = "Sample text";
            Console.WriteLine($"RemoveFirstCharacters => {text} => {text.RemoveFirstCharacters(7)}");
            // RemoveLastCharacters
            text = "Sample text";
            Console.WriteLine($"RemoveLastCharacters => {text} => {text.RemoveLastCharacters(5)}");
            // ReplaceDiacritics
            text = "Hí I'm Mr O'Cônnor áéíóú äëïöü ñ àèìòù & other -- a \\ b";
            Console.WriteLine($"ReplaceDiacritics => {text} => {text.ReplaceDiacritics()}");
            // Reverse
            text = "elbat";
            Console.WriteLine($"Reverse => {text} => {text.Reverse()}");
            // StringFormatWith
            text = "Hi {0}, I'm {1}";
            Console.WriteLine($"StringFormatWith => {text} => {text.StringFormatWith("Peter", "Mary")}");
            // ToEmptyIfNull
            text = null;
            Console.WriteLine($"ToEmptyIfNull => {text.ToEmptyIfNull().Length} characters");
            // ToSlug
            text = "Hí I'm Mr O'Cônnor áéíóú äëïöü ñ àèìòù & other -- a \\ b";
            Console.WriteLine($"ToSlug => {text} => {text.ToSlug()}");
            // TruncateWith
            text = "This is a sample of text to be truncated";
            Console.WriteLine($"TruncateWith => {text} => {text.TruncateWith(15)}");
            Console.WriteLine();
            // ************************************



            // ************************************
            // CollectionExtensions
            // ************************************
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("CollectionExtensions");
            Console.ForegroundColor = ConsoleColor.White;
            // AddToFirstPosition
            var collection = new List<string>() { "One", "2", "Three" };
            collection.AddToFirstPosition("Zero");
            foreach (var item in collection)
            {
                Console.WriteLine($"AddToFirstPosition => {item}");
            }
            // Clone
            collection = new List<string>() { "One", "2", "Three" };
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
            // EmptyIfNull
            List<string> data = null;
            Console.WriteLine($"EmptyIfNull => {data == null}");
            data = data.EmptyIfNull<string>().ToList();
            Console.WriteLine($"EmptyIfNull => {data == null}");
            // IsNull
            data = null;
            Console.WriteLine("IsNull => " + data.IsNull<string>());
            // IsNullAsync
            Console.WriteLine("IsNullAsync => " + data.IsNullAsync<string>().Result);
            // IsNullOrEmpty
            data = new List<string>();
            Console.WriteLine("IsNullOrEmpty => " + data.IsNullOrEmpty<string>());
            // IsNullOrEmptyAsync
            Console.WriteLine("IsNullOrEmptyAsync => " + data.IsNullOrEmptyAsync<string>().Result);
            // ToStringWithDelimiter
            var personCollection = new List<PersonModel>() { new PersonModel() { Age = 23, Name = "Mary" }, new PersonModel() { Age = 34, Name = "Peter" } };
            Console.WriteLine($"JoinWithDelimiter => {personCollection.JoinWithDelimiter<PersonModel>((x => $"{x.Name} is {x.Age} years old"))}");
            data = new List<string>() { "One", "2", "Three", "4", "Five" };
            Console.WriteLine($"JoinWithDelimiter => {data.JoinWithDelimiter<string>(x => x)}");
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
            // CurrencyExtensions
            // ************************************
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("CurrencyExtensions");
            Console.ForegroundColor = ConsoleColor.White;
            // ToCurrency
            Console.OutputEncoding = Encoding.Unicode;
            decimal value = 123.45M;
            Console.WriteLine($"ToCurrency => {value} => {value.ToCurrency("es-ES")}");
            Console.WriteLine();



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
            // Days
            var dateTimeToCalculate = DateTime.Now;
            var dateTimeCalculated = dateTimeToCalculate.Add(1.Days());
            Console.WriteLine($"Days => {dateTimeToCalculate} => {dateTimeCalculated}");
            // ElapsedUntilToday
            Console.WriteLine($"ElapsedUntilToday => {apollo11MoonDateTime} {apollo11MoonDateTime.ElapsedUntilToday()}");
            // ElapsedUtcUntilToday
            Console.WriteLine($"ElapsedUtcUntilToday => {apollo11MoonDateTime} {apollo11MoonDateTime.ElapsedUtcUntilToday()}");
            // ElapsedWith
            var apollo11EarthDateTime = new DateTime(1969, 7, 24, 18, 50, 0);
            Console.WriteLine($"ElapsedWith => {apollo11MoonDateTime} - {apollo11EarthDateTime} {apollo11MoonDateTime.ElapsedWith(apollo11EarthDateTime)}");
            // GetDateWithCurrentTime
            var dateTime = new DateTime(2017, 2, 12);
            Console.WriteLine($"GetDateWithCurrentTime {dateTime} => " + dateTime.GetDateWithCurrentTime());
            // GetDateWithCurrentUtcTime
            dateTime = new DateTime(2017, 2, 12);
            Console.WriteLine($"GetDateWithCurrentUtcTime {dateTime} => " + dateTime.GetDateWithCurrentUtcTime());
            // Hours
            dateTimeToCalculate = DateTime.Now;
            dateTimeCalculated = dateTimeToCalculate.Add(23.Hours());
            Console.WriteLine($"Hours => {dateTimeToCalculate} => {dateTimeCalculated}");
            // IsBetweenDates
            var dateTimeToCheck = new DateTime(2017, 2, 12, 11, 23, 11);
            Console.WriteLine("IsBetweenDates => " + dateTimeToCheck.IsBetweenDates(new DateTime(2017, 2, 12, 11, 23, 10), new DateTime(2017, 2, 17)));
            // IsDate
            object dateTimeObject = "02/21/2017";
            Console.WriteLine($"Is valid date {dateTimeObject} for en-UK? => " + dateTimeObject.IsDate(new CultureInfo("en-UK")));
            dateTimeObject = "21/02/2017";
            Console.WriteLine($"Is valid date {dateTimeObject} for es-ES? => " + dateTimeObject.IsDate(new CultureInfo("es-ES")));
            // IsLastDayOfMonth
            var dateTimeNow = DateTime.Now;
            Console.WriteLine($"IsLastDayOfMonth {dateTimeNow} is last day of month? => " + dateTimeNow.IsLastDayOfMonth());
            // IsLeapYear
            dateTimeNow = DateTime.Now;
            Console.WriteLine($"IsLeapYear {dateTimeNow} is leap year? " + dateTimeNow.IsLeapYear());
            // IsWeekend
            dateTimeNow = DateTime.Now;
            Console.WriteLine($"IsWeekend {dateTimeNow} is weekend? " + dateTimeNow.IsWeekend());
            // IsWorkingDay
            dateTimeNow = DateTime.Now;
            Console.WriteLine($"IsWorkingDay {dateTimeNow} is working day? " + dateTimeNow.IsWorkingDay());
            // LastDayOfMonth
            dateTimeNow = DateTime.Now;
            Console.WriteLine($"LastDayOfMonth {dateTimeNow} last day of month => " + dateTimeNow.LastDayOfMonth());
            // Minutes
            dateTimeToCalculate = DateTime.Now;
            dateTimeCalculated = dateTimeToCalculate.Add(17.Minutes());
            Console.WriteLine($"Minutes => {dateTimeToCalculate} => {dateTimeCalculated}");
            // NextWorkingDay
            dateTimeNow = DateTime.Now;
            Console.WriteLine($"NextWorkingDay {dateTimeNow} is now, the next working day is " + dateTimeNow.NextWorkingDay());
            // Seconds
            dateTimeToCalculate = DateTime.Now;
            dateTimeCalculated = dateTimeToCalculate.Add(43.Seconds());
            Console.WriteLine($"Seconds => {dateTimeToCalculate} => {dateTimeCalculated}");
            // Days, Hours, Minutes, Seconds
            dateTimeToCalculate = DateTime.Now;
            dateTimeCalculated = dateTimeToCalculate.Add(3.Days() + 1.Hours() + 20.Minutes() + 30.Seconds());
            Console.WriteLine($"Days, Hours, Minutes, Seconds => {dateTimeToCalculate} => {dateTimeCalculated}");
            // ToJavaScriptDate
            dateTimeNow = DateTime.Now;
            Console.WriteLine($"ToJavaScriptDate {dateTimeNow} => " + dateTimeNow.ToJavaScriptDate());
            // ToUnixTimeStamp
            dateTimeNow = DateTime.Now;
            Console.WriteLine($"ToUnixTimeStamp {dateTimeNow} => " + dateTimeNow.ToUnixTimeStamp());
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
            // GetPercentageOf (decimal)
            value = 49;
            decimal percentage = 50.0M;
            Console.WriteLine($"GetPercentageOf {percentage}% for {value} => {Convert.ToDecimal(value).GetPercentageOf(percentage)}");
            // GetPercentageOf (int)
            value = 49;
            Console.WriteLine($"GetPercentageOf 50% for {value} => {Convert.ToDecimal(value).GetPercentageOf(50)}");
            // IsEven 
            var number = 7;
            Console.WriteLine($"IsEven {number} => {number.IsEven()}");
            // IsOdd
            number = 7;
            Console.WriteLine($"IsOdd {number} => {number.IsOdd()}");
            // IsPrime
            number = 7;
            Console.WriteLine($"IsPrime {number} => {number.IsPrime()}");
            // ToByte
            text = "123";
            byte valByte = text.ToByte();
            Console.WriteLine($"ToByte {text} => {valByte}");
            // ToDecimal
            decimal valDecimal = text.ToDecimal() * 1.2M;
            Console.WriteLine($"ToDecimal {text} => {valDecimal}");
            // ToDouble
            double valDouble = text.ToDouble() * 1.2;
            Console.WriteLine($"ToDouble {text} => {valDouble}");
            // ToFloat
            float valFloat = text.ToFloat() * 1.2F;
            Console.WriteLine($"ToFloat {text} => {valFloat}");
            // ToInt32
            int valInt32 = text.ToInt32() * 2.ToInt32();
            Console.WriteLine($"ToInt32 {text} => {valInt32}");
            // ToInt64
            long valInt64 = text.ToInt64() * "2".ToInt64();
            Console.WriteLine($"ToInt64 {text} => {valInt64}");
            // ToSByte
            sbyte valSByte = text.ToSByte();
            Console.WriteLine($"ToSByte {text} => {valSByte}");
            // ToShort
            short valShort = text.ToShort();
            Console.WriteLine($"ToShort {text} => {valShort}");
            // ToUInt
            uint valUInt = text.ToUInt() * "2".ToUInt();
            Console.WriteLine($"ToUInt {text} => {valUInt}");
            // ToULong
            ulong valULong = text.ToULong() * 2.ToULong();
            Console.WriteLine($"ToULong {text} => {valULong}");
            // ToUShort
            ushort valUShort = text.ToUShort();
            Console.WriteLine($"ToUShort {text} => {valUShort}");
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



            // ************************************
            // SocialExtensions
            // ************************************
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("SocialExtensions");
            Console.ForegroundColor = ConsoleColor.White;
            // IsValidEmail
            text = "foo@dom.co.uk";
            Console.WriteLine($"IsValidEmail => {text} => {text.IsValidEmail()}");
            // IsValidFtp
            text = "ftp://foo.com";
            Console.WriteLine($"IsValidFtp => {text} => {text.IsValidFtp()}");
            // IsValidUrl
            text = "https://www.google.com";
            Console.WriteLine($"IsValidUrl => {text} => {text.IsValidUrl()}");
            Console.WriteLine();


            // ************************************
            // StreamExtensions
            // ************************************
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("StreamExtensions");
            Console.ForegroundColor = ConsoleColor.White;
            // ConvertToString
            text = "Foo text";
            stream = text.ConvertToStream();
            var stringFromStream = stream.ConvertToString();
            Console.WriteLine($"ConvertToString => {text} => {stringFromStream}");
            // GetMD5
            text = "Foo sample text";
            stream = text.ConvertToStream();
            Console.WriteLine($"GetMD5 => {text} => {stream.GetMD5()}");
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