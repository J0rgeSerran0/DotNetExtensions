# DotNetExtensions
General .NET Extensions that you can use on your projects

## Extension Methods
![C# Logo](/images/CSharp.png)

I want to share with you  some C# Extensions that I have used sometime in my projects.

I hope that helps.

The source code has two projects:

A project with the Extensions in C#, and a demo project to show you the use of all them.



## List of Extension Methods

- [`CollectionExtensions`](#collectionextensions)
- [`ColorExtensions`](#colorextensions)
- [`DateTimeExtensions`](#datetimeextensions)
- [`EnumExtensions`](#enumextensions)
- [`ExceptionExtensions`](#exceptionextensions)
- [`NumberExtensions`](#numberextensions)
- [`RandomExtensions`](#randomextensions)
- [`SocialExtensions`](#socialextensions)
- [`StreamExtensions`](#streamextensions)
- [`StringExtensions`](#stringextensions)



#### ![Separator](/images/ExtensionMethod.png) `CollectionExtensions`

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


#### ![Separator](/images/ExtensionMethod.png) `ColorExtensions`

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


#### ![Separator](/images/ExtensionMethod.png) `DateTimeExtensions`

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

![Separator](/images/bullet_green.png) **`NextWorkingDay`** - Calculates the next working day from a date.

```csharp
var dateTimeNow = DateTime.Now;
var nextWorkingDay = dateTimeNow.NextWorkingDay();

```


#### ![Separator](/images/ExtensionMethod.png) `EnumExtensions`

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


#### ![Separator](/images/ExtensionMethod.png) `ExceptionExtensions`

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


#### ![Separator](/images/ExtensionMethod.png) `NumberExtensions`

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


#### ![Separator](/images/ExtensionMethod.png) `RandomExtensions`

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


#### ![Separator](/images/ExtensionMethod.png) `SocialExtensions`

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


#### ![Separator](/images/ExtensionMethod.png) `StreamExtensions`

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


#### ![Separator](/images/ExtensionMethod.png) `StringExtensions`

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
