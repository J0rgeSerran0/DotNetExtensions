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
- [`DateTimeExtensions`](#datetimeextensions)
- [`ExceptionExtensions`](#exceptionextensions)
- [`NumberExtensions`](#numberextensions)
- [`StringExtensions`](#stringextensions)



#### `CollectionExtensions`

![Separator](/images/bullet_green.png) **`IsNullOrEmpty`** - Checks if a collection is null or has one or more items, returning true or false.

```csharp
var data = new List<string>();
var collectionIsNullOrEmpty = data.IsNullOrEmpty<string>();

// true if is a null or empty collection
// false in whatever other case
```


#### `DateTimeExtensions`

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


#### `ExceptionExtensions`

![Separator](/images/bullet_green.png) **`GetMessagesFromInnerExceptions`** - Returns an *StringBuilder* object with the *Exception* object and the *InnerException* object's information when the *Exception* has one or more *InnerException* objects inside.

```csharp
var info = ex.GetMessagesFromInnerExceptions().ToString();

// ex is the Exception object
```


#### `NumberExtensions`

![Separator](/images/bullet_green.png) **`IsPrime`** - Checks if an int number is prime number or is not a prime number.

```csharp
var number = 7;
var isPrimeNumber = number.IsPrime();

// true if is a prime number
// false in whatever other case
```


#### `StringExtensions`

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

![Separator](/images/bullet_green.png) **`Repeat`** - Returns a character repeated a number of times.

```csharp
var text = '-'.Repeat(23);
```


> (Note: I will continue adding more extension methods in the next days)
