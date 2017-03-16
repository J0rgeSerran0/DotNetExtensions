# DotNetExtensions
General .NET Extensions that you can use on your projects

## ![](/images/ExtensionMethod.png) Extension Methods
![C# Logo](/images/CSharp.png)

I want to share with you  some C# Extensions that I have used sometime in my projects.

I hope that helps.

The source code has two projects:

A project with the Extensions in C#, and a demo project to show you the use of all them.



## List of Extension Methods

- [x] [`CollectionExtensions`](#collectionextensions)
- [x] [`ColorExtensions`](#colorextensions)
- [`CurrencyExtensions`](#currencyextensions)
- [`DateTimeExtensions`](#datetimeextensions)
- [`EnumExtensions`](#enumextensions)
- [`ExceptionExtensions`](#exceptionextensions)
- [`NumericExtensions`](#numericextensions)
- [`RandomExtensions`](#randomextensions)
- [`SocialExtensions`](#socialextensions)
- [`StreamExtensions`](#streamextensions)
- [`StringExtensions`](#stringextensions)



### `CollectionExtensions`

![Separator](/images/bullet_green.png) **`AddToFirstPosition`** - Adds an item to the beginning of a collection.

```csharp
var collection = new List<string>() { "One", "2", "Three" };
collection.AddToFirstPosition("Zero");

```

![Separator](/images/bullet_green.png) **`Clone`** - Clone a collection to avoid reference problems.

```csharp
var collection = new List<string>() { "One", "2", "Three" };
var collection2 = collection.Clone<string>();
collection2.Add("4");

```

![Separator](/images/bullet_green.png) **`EmptyIfNull`** - Initializes a collection if the collection is null.

```csharp
List<string> data = null;
data = data.EmptyIfNull<string>().ToList();

```

![Separator](/images/bullet_green.png) **`JoinWithDelimiter`** - Joins the data of a collection with a delimiter between its data.

```csharp
public class PersonModel
{
    public string Name { get; set; }
    public byte Age { get; set; }
}

// With the fields of a model
var personCollection = new List<PersonModel>() { new PersonModel() { Age = 23, Name = "Mary" }, new PersonModel() { Age = 34, Name = "Peter" } };
var result = personCollection.JoinWithDelimiter<PersonModel>((x => $"{x.Name} is {x.Age} years old"));

// With a string collection
var data = new List<string>() { "One", "2", "Three", "4", "Five" };
var result = data.JoinWithDelimiter<string>(x => x);

```

![Separator](/images/bullet_green.png) **`IsNull`** - Checks if a collection is null, returning true or false.

```csharp
var data = null;
var collectionIsNull = data.IsNull<string>();

// true if is a null
// false in whatever other case
```

![Separator](/images/bullet_green.png) **`IsNullAsync`** - Async method that checks if a collection is null, returning true or false.

```csharp
var data = null;
var collectionIsNullAsync = await data.IsNullAsync<string>();

// true if is a null
// false in whatever other case
```

![Separator](/images/bullet_green.png) **`IsNullOrEmpty`** - Checks if a collection is null or has one or more items, returning true or false.

```csharp
var data = new List<string>();
var collectionIsNullOrEmpty = data.IsNullOrEmpty<string>();

// true if is a null or empty collection
// false in whatever other case
```

![Separator](/images/bullet_green.png) **`IsNullOrEmptyAsync`** - Async method that checks if a collection is null or has one or more items, returning true or false.

```csharp
var data = new List<string>();
var collectionIsNullOrEmptyAsync = await data.IsNullOrEmptyAsync<string>();

// true if is a null or empty collection
// false in whatever other case
```

![Separator](/images/bullet_green.png) **`ToStringWithDelimiter`** - Transforms a collection in a string with all fields delimited by a delimiter that can be a character or a string.

```csharp
var data = new List<string>() { "One", "2", "Three", "4", "Five" };
var info = data.ToStringWithDelimiter<string>();

```



### `ColorExtensions`

![Separator](/images/bullet_green.png) **`IsHexCode`** - Checks if a string with the hex code value (without the # symbol) is a valid hex code.

```csharp
var hexCode = "00FF00";
var isValidHexCode = hexCode.IsHexCode();

// true if is a valid hex code
// false in whatever other case
```

![Separator](/images/bullet_green.png) **`ToColor`** - Convert a hex code to Color.

```csharp
var hexCode = "00FF00";
var color = hexCode.ToColor().Value;

// returns null if is nos a valid hex code or if there is any problem
```

![Separator](/images/bullet_green.png) **`ToHexCode`** - Convert a Color to a hex code.

```csharp
var color = Color.Red;
var hexCode = color.ToHexCode();

// returns the equivalent hex code for the Color
```



### `CurrencyExtensions`

![Separator](/images/bullet_green.png) **`ToCurrency`** - Converts a decimal value into a currency value.

```csharp
decimal value = 123.45;
var currencyData = value.ToCurrency("es-ES");

// returns 123,45 €
```



### `DateTimeExtensions`

![Separator](/images/bullet_green.png) **`CalculateAge`** - Calculates the age or the time between two dates. Returns an int value.

```csharp
var apollo11MoonDateTime = new DateTime(1969, 7, 20);
var age = apollo11MoonDateTime.CalculateAge();

// returns an int value
```

![Separator](/images/bullet_green.png) **`CalculateAgeWithPrecision`** - Calculates the age or the time between two dates. Returns a double value.

```csharp
var apollo11MoonDateTime = new DateTime(1969, 7, 20);
var age = apollo11MoonDateTime.CalculateAgeWithPrecision();

// returns a double value
```

![Separator](/images/bullet_green.png) **`Days`** - Similar function to the AddDays, adds some days to a DateTime.

```csharp
var apollo11MoonDateTime = new DateTime(1969, 7, 20);
var dateTimeCalculated = apollo11MoonDateTime.Add(1.Days());

var apollo11MoonDateTime = new DateTime(1969, 7, 20);
var dateTimeCalculated = apollo11MoonDateTime.Add(3.Days() + 1.Hours() + 20.Minutes() + 30.Seconds());

```

![Separator](/images/bullet_green.png) **`ElapsedUntilToday`** - Calculates the time (TimeSpan) elapsed until today.

```csharp
var apollo11MoonDateTime = new DateTime(1969, 7, 20);
var elapsedTime = apollo11MoonDateTime.ElapsedUntilToday();

// you can calculate the future time too, but you will get a negative value in this case.
```

![Separator](/images/bullet_green.png) **`ElapsedUtcUntilToday`** - Calculates the time (TimeSpan) elapsed until today (utc).

```csharp
var apollo11MoonDateTime = new DateTime(1969, 7, 20);
var elapsedUtcTime = apollo11MoonDateTime.ElapsedUtcUntilToday();

// you can calculate the future time too, but you will get a negative value in this case.
```

![Separator](/images/bullet_green.png) **`ElapsedWith`** - Calculates the time (TimeSpan) elapsed until a date passed by parameter.

```csharp
var apollo11MoonDateTime = new DateTime(1969, 7, 20);
var apollo11EarthDateTime = new DateTime(1969, 7, 24, 18, 50, 0);
var elapsedTime = apollo11MoonDateTime.ElapsedUtcUntilToday(apollo11EarthDateTime);

// you can calculate the future time too, but you will get a negative value in this case.
```

![Separator](/images/bullet_green.png) **`Hours`** - Similar function to the AddHous, adds some hours to a DateTime.

```csharp
var apollo11MoonDateTime = new DateTime(1969, 7, 20);
var dateTimeCalculated = apollo11MoonDateTime.Add(7.Hours());

var apollo11MoonDateTime = new DateTime(1969, 7, 20);
var dateTimeCalculated = apollo11MoonDateTime.Add(3.Days() + 1.Hours() + 20.Minutes() + 30.Seconds());

```

![Separator](/images/bullet_green.png) **`IsBetweenDates`** - Checks if a dateTime is between two dateTimes.

```csharp
var dateTimeToCheck = new DateTime(2017, 2, 12, 11, 23, 11);
var isbetweenDates = dateTimeToCheck.IsBetweenDates(new DateTime(2017, 2, 12, 11, 23, 10), new DateTime(2017, 2, 17))

// true if the dateTime is between the range of dateTime objects
// false in whatever other case
```

![Separator](/images/bullet_green.png) **`IsDate`** - Calculates if an object contains a correct DateTime for a specific culture.

```csharp
object dateTimeObject = "02/21/2017";
var isUkValidDateTime = dateTimeObject.IsDate(new CultureInfo("en-UK");

dateTimeObject = "21/02/2017";
var isEsValidDateTime = dateTimeObject.IsDate(new CultureInfo("es-ES");

// true if is a valid DateTime for the culture specified
// false in whatever other case
```

![Separator](/images/bullet_green.png) **`IsWeekend`** - Calculates if a date is weekend or not.

```csharp
var dateTimeNow = DateTime.Now;
var isWeekend = dateTimeNow.IsWeekend();

// true if is a weekend date
// false in whatever other case
```

![Separator](/images/bullet_green.png) **`IsWorkingDay`** - Calculates if a date is working day or not.

```csharp
var dateTimeNow = DateTime.Now;
var isWorkingDay = dateTimeNow.IsWorkingDay();

// true if is a working day
// false in whatever other case
```

![Separator](/images/bullet_green.png) **`Minutes`** - Similar function to the AddMinutes, adds some minutes to a DateTime.

```csharp
var apollo11MoonDateTime = new DateTime(1969, 7, 20);
var dateTimeCalculated = apollo11MoonDateTime.Add(10.Minutes());

var apollo11MoonDateTime = new DateTime(1969, 7, 20);
var dateTimeCalculated = apollo11MoonDateTime.Add(3.Days() + 1.Hours() + 20.Minutes() + 30.Seconds());

```

![Separator](/images/bullet_green.png) **`NextWorkingDay`** - Calculates the next working day from a date.

```csharp
var dateTimeNow = DateTime.Now;
var nextWorkingDay = dateTimeNow.NextWorkingDay();

```

![Separator](/images/bullet_green.png) **`Seconds`** - Similar function to the AddSeconds, adds some seconds to a DateTime.

```csharp
var apollo11MoonDateTime = new DateTime(1969, 7, 20);
var dateTimeCalculated = apollo11MoonDateTime.Add(1.Seconds());

var apollo11MoonDateTime = new DateTime(1969, 7, 20);
var dateTimeCalculated = apollo11MoonDateTime.Add(3.Days() + 1.Hours() + 20.Minutes() + 30.Seconds());

```



### `EnumExtensions`

![Separator](/images/bullet_green.png) **`GetDescriptionFromEnum`** - Get a description from an enum value.

```csharp
public enum DemoType
{
    [Description("OneFoo")]
    One,
    [Description("TwoFoo")]
    Two,
    Three
}


var demoType = DemoType.One;
var enumDescription = demoType.GetDescriptionFromEnum();

```

![Separator](/images/bullet_green.png) **`GetEnumFromDescription`** - Get an enum value from a description.

```csharp
public enum DemoType
{
    [Description("OneFoo")]
    One,
    [Description("TwoFoo")]
    Two,
    Three
}


var descriptionEnumType = "TwoFoo";
var demoType = descriptionEnumType.GetEnumFromDescription<DemoType>();

```

![Separator](/images/bullet_green.png) **`IsValid`** - Determinates if a string value is found in an enum type.

```csharp
public enum DemoType
{
    One,
    Two,
    Three
}


var stringDemoType = "Twoo";
var exists = stringDemoType.IsValid<DemoType>();

// true if is a valid string value
// false in whatever other case
```

![Separator](/images/bullet_green.png) **`ToEnum`** - Convert a string value in an enum type if it exists.

```csharp
public enum DemoType
{
    One,
    Two,
    Three
}


var demoType = DemoType.One;
var stringDemoType = "Two";
demoType = stringDemoType.ToEnum<DemoType>();

// In this sample code, returns Two as enum value.
// In whatever other cases, will return the first default value of the enum object.
```



### `ExceptionExtensions`

![Separator](/images/bullet_green.png) **`GetMessagesFromInnerExceptions`** - Returns an *StringBuilder* object with the *Exception* object and the *InnerException* object's information when the *Exception* has one or more *InnerException* objects inside.

```csharp
var info = ex.GetMessagesFromInnerExceptions().ToString();

// ex is the Exception object
```

![Separator](/images/bullet_green.png) **`ToException`** - Generates an Exception object with the message that we want include in the object.

```csharp
var @object = new Object();
var exception = @object.ToException<InvalidCastException>("foo exception text");
throw exception;

// ex is the Exception object
```

![Separator](/images/bullet_green.png) **`ThrowIfNull`** - Generates an ArgumentNullException object if the class is null.

```csharp
var @object = new Object();
@object.ThrowIfNull<object>();
throw exception;

// ex is the Exception object
```



### `NumericExtensions`

![Separator](/images/bullet_green.png) **`GetPercentageOf`** - Gets the percentage of a value.

```csharp
var value = 49;
int percentage = 50;
var result = Convert.ToDecimal(value).GetPercentageOf(percentage);

var value = 49;
decimal percentage = 50.0M;
var result = Convert.ToDecimal(value).GetPercentageOf(percentage);

```

![Separator](/images/bullet_green.png) **`IsPrime`** - Checks if an int number is prime number or is not a prime number.

```csharp
var number = 7;
var isPrimeNumber = number.IsPrime();

// true if is a prime number
// false in whatever other case
```

![Separator](/images/bullet_green.png) **`ToByte`** - Converts an object into a Byte value if is possible.

```csharp
var value = 123;
var valueConverted = value.ToByte();

var value = 123;
var valueConverted = value.ToByte(1);

```

![Separator](/images/bullet_green.png) **`ToDecimal`** - Converts an object into a Decimal value if is possible.

```csharp
var value = 123;
var valueConverted = value.ToDecimal();

var value = 123;
var valueConverted = value.ToDecimal(1);

```

![Separator](/images/bullet_green.png) **`ToDouble`** - Converts an object into a Double value if is possible.

```csharp
var value = 123;
var valueConverted = value.ToDouble();

var value = 123;
var valueConverted = value.ToDouble(1);

```

![Separator](/images/bullet_green.png) **`ToFloat`** - Converts an object into a Float value if is possible.

```csharp
var value = 123;
var valueConverted = value.ToFloat();

var value = 123;
var valueConverted = value.ToFloat(1);

```

![Separator](/images/bullet_green.png) **`ToInt32`** - Converts an object into a Int value if is possible.

```csharp
var value = 123;
var valueConverted = value.ToInt32();

var value = 123;
var valueConverted = value.ToInt32(1);

```

![Separator](/images/bullet_green.png) **`ToInt64`** - Converts an object into a Long value if is possible.

```csharp
var value = 123;
var valueConverted = value.ToInt64();

var value = 123;
var valueConverted = value.ToInt64(1);

```

![Separator](/images/bullet_green.png) **`ToSByte`** - Converts an object into a SByte value if is possible.

```csharp
var value = 123;
var valueConverted = value.ToSByte();

var value = 123;
var valueConverted = value.ToSByte(1);

```

![Separator](/images/bullet_green.png) **`ToShort`** - Converts an object into a Short value if is possible.

```csharp
var value = 123;
var valueConverted = value.ToShort();

var value = 123;
var valueConverted = value.ToShort(1);

```

![Separator](/images/bullet_green.png) **`ToUInt`** - Converts an object into a UInt value if is possible.

```csharp
var value = 123;
var valueConverted = value.ToUInt();

var value = 123;
var valueConverted = value.ToUInt(1);

```

![Separator](/images/bullet_green.png) **`ToULong`** - Converts an object into a ULong value if is possible.

```csharp
var value = 123;
var valueConverted = value.ToULong();

var value = 123;
var valueConverted = value.ToULong(1);

```

![Separator](/images/bullet_green.png) **`ToUShort`** - Converts an object into a UShort value if is possible.

```csharp
var value = 123;
var valueConverted = value.ToUShort();

var value = 123;
var valueConverted = value.ToUShort(1);

```



### `RandomExtensions`

![Separator](/images/bullet_green.png) **`Shuffle`** - For integer values, generate a collection of shuffle values starting in a number with a size of numbers to calculate.

```csharp
List<int> numbers = null;
var cards = numbers.Shuffle(1, 12);

// null if the values are negative or invalid
// null if the size of numbers to calculate is 0 or negative
```

![Separator](/images/bullet_green.png) **`Shuffle`** - Shuffle a collection's items.

```csharp
var names = new List<string>() { "Paul", "Jose", "Adams", "Leticia", "Mary" };
names.Shuffle();

// null if the collection is null
```



### `SocialExtensions`

![Separator](/images/bullet_green.png) **`IsValidEmail`** - Checks if the string is a valid email or not.

```csharp
var email = "foo@dom.co.uk";
var isEmail = email.IsValidEmail();

// true if is a valid email
// false in the other cases
```

![Separator](/images/bullet_green.png) **`IsValidFtp`** - Checks if the string is a valid ftp address or not.

```csharp
var ftp = "ftp://foo.com";
var isFtp = ftp.IsValidFtp();

// true if is a valid ftp address
// false in the other cases
```

![Separator](/images/bullet_green.png) **`IsValidUrl`** - Checks if the string is a valid url or not.

```csharp
var url = "http://www.google.com";
var isUrl = url.IsValidUrl();

// true if is a valid url address
// false in the other cases
```



### `StreamExtensions`

![Separator](/images/bullet_green.png) **`ConvertToString`** - Converts a stream object to a string object.

```csharp
var text = stream.ConvertToString();

```

![Separator](/images/bullet_green.png) **`GetMD5`** - Gets the MD5 value from a stream content.

```csharp
var text = "Foo sample text";
var stream = text.ConvertToStream();
var md5 = stream.GetMD5();

// 24643f9c4657b2d3281bdaa2e001a54c
```



### `StringExtensions`

![Separator](/images/bullet_green.png) **`ContainsCharacters`** - Checks if some character or characters are found in a text, returning true or false.

```csharp
var text = "Sample.here";
char[] characters = { ',', 'H' };

var result = text.ContainsCharacters(characters, StringComparison.OrdinalIgnoreCase);

// true if some characters have been found in the text
// false in whatever other cases
```

![Separator](/images/bullet_green.png) **`ContainsText`** - Checks if a text pattern is found in the source text, returning true or false.

```csharp
var text = "Sample.here";
var result = text.ContainsText("Her", StringComparison.OrdinalIgnoreCase);

// true if the pattern has been found in the text
// false in whatever other case
```

![Separator](/images/bullet_green.png) **`ConvertToStream`** - Converts a string to a stream object.

```csharp
var text = "Foo text";
var stream = text.ConvertToStream();

```

![Separator](/images/bullet_green.png) **`CountWords`** - Count the number of words in a text.

```csharp
var text = "This is a sample of seven" + Environment.NewLine + "words";
var counter = text.CountWords();

```

![Separator](/images/bullet_green.png) **`IsAsPattern`** - Checks if a string covers a pattern.

```csharp
var text = "abc";
var pattern = "a??";
var isAsPattern = text.IsAsPattern(pattern);

// true if the string is correct
// false in the other cases
```

![Separator](/images/bullet_green.png) **`IsString`** - Checks if an object is a string or not.

```csharp
var text = "Sample.here";
var result = text.IsString();

// true if the object is a string object
// false if the object is null or is not a string object
```

![Separator](/images/bullet_green.png) **`Repeat`** - Returns a character repeated a number of times.

```csharp
var text = '-'.Repeat(23);

```

![Separator](/images/bullet_green.png) **`Reverse`** - Reverses the characters of a string.

```csharp
var text = "elbat";
var reverseText = text.Reverse();

```

![Separator](/images/bullet_green.png) **`RemoveFirstCharacters`** - Remove the first characters of a string.

```csharp
var text = "Sample text";
var result = text.RemoveFirstCharacters(7);

```

![Separator](/images/bullet_green.png) **`RemoveLastCharacters`** - Remove the last characters of a string.

```csharp
var text = "Sample text";
var result = text.RemoveLastCharacters(5);

```

![Separator](/images/bullet_green.png) **`ReplaceDiacritics`** - Replaces the diacritics characters by their equivalent non diacritic character.

```csharp
var text = "Hí I'm Mr O'Cônnor áéíóú äëïöü ñ àèìòù & other -- a \\ b";
var result = text.ReplaceDiacritics();

```

![Separator](/images/bullet_green.png) **`StringFormatWith`** - Returns a text with parameters as String.Format action.

```csharp
var text = "Hi {0}, I'm {1}";
var response = text.StringFormatWith("Peter", "Mary");

```

![Separator](/images/bullet_green.png) **`ToEmptyIfNull`** - Initializes a string object to an empty string if is null.

```csharp
var text = null;
text = text.ToEmptyIfNull();

```

![Separator](/images/bullet_green.png) **`ToSlug`** - Converts a text to their slug text.

```csharp
var text = "Hí I'm Mr O'Cônnor áéíóú äëïöü ñ àèìòù & other -- a \\ b";
var result = text.ToSlug();

```

![Separator](/images/bullet_green.png) **`TruncateWith`** - Truncates a text with a maximum length of characters.

```csharp
var text = "This is a sample of text to be truncated";
var result = text.TruncateWith(15);

// This is a sampl...
```

