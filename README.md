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


#### `DateTimeExtensions`

![Separator](/images/bullet_green.png) **`CalculateAge`** - Calculates the age or the time between two dates. Returns an int value.

![Separator](/images/bullet_green.png) **`CalculateAgeWithPrecision`** - Calculates the age or the time between two dates. Returns a double value.


#### `ExceptionExtensions`

![Separator](/images/bullet_green.png) **`GetMessagesFromInnerExceptions`** - Returns an *StringBuilder* object with the *Exception* object and the *InnerException* object's information when the *Exception* has one or more *InnerException* objects inside.


#### `StringExtensions`

![Separator](/images/bullet_green.png) **`ContainsCharacters`** - Checks if some character or characters are found in a text, returning true or false.

![Separator](/images/bullet_green.png) **`ContainsText`** - Checks if a text pattern is found in the source text, returning true or false.

![Separator](/images/bullet_green.png) **`Repeat`** - Returns a character repeated a number of times.


> (Note: I will continue adding more extension methods in the next days)
