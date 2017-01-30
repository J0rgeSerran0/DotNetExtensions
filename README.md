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
- [`StringExtensions`](#stringextensions)



#### `CollectionExtensions`

![Separator](/images/bullet_green.png) **`IsNullOrEmpty`** - Checks if a collection is null or has one or more items, returning true or false.

```csharp
var data = new List<string>();
var collectionIsNullOrEmpty = data.IsNullOrEmpty<string>();

// <c>true</c> if is a null or empty collection
// <c>false</c> in whatever other case
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


#### `ExceptionExtensions`

![Separator](/images/bullet_green.png) **`GetMessagesFromInnerExceptions`** - Returns an *StringBuilder* object with the *Exception* object and the *InnerException* object's information when the *Exception* has one or more *InnerException* objects inside.

```csharp
var info = ex.GetMessagesFromInnerExceptions().ToString();

// ex is the Exception object
```


#### `StringExtensions`

![Separator](/images/bullet_green.png) **`ContainsCharacters`** - Checks if some character or characters are found in a text, returning true or false.

```csharp
var text = "Sample.here";
char[] characters = { ',', 'H' };

var result = text.ContainsCharacters(characters, StringComparison.OrdinalIgnoreCase);

// <c>true</c> if some characters have been found in the text
// <c>false</c> in whatever other cases
```

![Separator](/images/bullet_green.png) **`ContainsText`** - Checks if a text pattern is found in the source text, returning true or false.

```csharp
var text = "Sample.here";

var result = text.ContainsText("Her", StringComparison.OrdinalIgnoreCase);

// <c>true</c> if the pattern has been found in the text
// <c>false</c> in whatever other case
```

![Separator](/images/bullet_green.png) **`Repeat`** - Returns a character repeated a number of times.

```csharp
var text = '-'.Repeat(23);
```


> (Note: I will continue adding more extension methods in the next days)
