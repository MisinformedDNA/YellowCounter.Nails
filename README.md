[![NuGet](https://img.shields.io/nuget/v/YellowCounter.Nails.svg)](https://www.nuget.org/packages/YellowCounter.Nails/)

# YellowCounter.Nails
A few Ruby and Rails-like extension methods for .NET

I always found it odd that when I wanted to know if a value _was_ entered, by the user, I had to ask if it _wasn't_ entered.
Not only that, I had to ask if wasn't null and wasn't empty.
All I want to know is if the user provided a value!
I'm sure there were similar reasons for why Ruby and Ruby on Rails felt then need to include these methods in their frameworks.

This library replicate 4 simple methods with simple abstractions.
As such, this library is very small and simple, but, IMO, the value lies in its simplicity.

## IsNull()

Determines whether the instance is null.

```csharp
object value = null;
int? number = null;

Console.WriteLine(value == null);  // true 
Console.WriteLine(value.IsNull()); // true 

Console.WriteLine(number == null);  // true 
Console.WriteLine(number.IsNull()); // true 
```

## IsEmpty()

Determines whether the collection or string is empty. This is equivalent to testing the length of the collection or string for a value of zero.

```csharp
int[] array = new int[0];
string str = string.Empty;

Console.WriteLine(array.Length == 0); // true 
Console.WriteLine(array.IsEmpty());   // true 

Console.WriteLine(str.Length == 0); // true 
Console.WriteLine(str.IsEmpty());   // true 
```

## IsBlank()

Determines whether the instance is null, empty, whitespace or false.

- On a collection, this is equivalent to `IsEmpty()`.
- On a string, this is equivalent to `string.IsNullOrWhiteSpace()`.
- On a bool, this is equivalent to comparing to `false`
- On any other object, this is equivalent to `IsNull`

## IsPresent()

Determines whether the instance is present. This is the opposite of `IsBlank()`
