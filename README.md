# practice-c-sharp

Learning C# with a [tutorial](https://www.youtube.com/watch?v=GhQdlIFylQ8)

## Installation & Setup

I first [installed](https://dotnet.microsoft.com/en-us/download/dotnet-framework) .NET using the microsoft page and I also installed the [VSCode](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp) Extension for C# to get some intelisense and auto-completion.

I then created a repository and ran the command

`dotnet new console`

This command created a boilerplate where you can write your code. There are 2 different boilerplates that work for your first 'Hello World!' program.

The first one looks like this:

```
Console.WriteLine("Hello, World!");
```

The second one looks like this:

```using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
```

These two forms represent the same program and are valid. If you are working with an existing tutorial you can either use the first one and write the body of the `Main` method, or you can convert the program to the older style.

## Printing on Screen

You can print text on the screen by using the command:

`Console.WriteLine("Here you can write your text");`

If the terminal closes too quickly for you to see the text you can use the `ReadLine` command to stop the window from closing, it looks like this:

`Console.ReadLine()`

## Data Types

There are several primitive data types, the ones I saw in the first tutorial are:

- string: These are for words or sentences (more than one character)
- char: These are for a single character like a letter or a number
- int: Integers, numbers with no decimals
- bool: are booleans, this can be either true or false

There are 3 different ways you can implement decimal numbers this are:

- float
- double
- decimal
  TODO: describe what the difference is between these 3 ways

You can create variables like:

```
string variableName = "This is the value";
```

First you write the data type, then you write the variable name and the you can assign an initial value if you want, you can create a variable with no initial value if not necessary.

## Working with Strings

You can use \n to separate lines within a single Console.WriteLine like:

```
Console.WriteLine("Giraffe\nAcademy");
```

This would print

```
Giraffe
Academy
```

---

You can also escape double quotes using \"
Example:

```
Console.WriteLine("Giraffe\"Academy");
```

would print:

```
Giraffe"Academy
```

---

You can print strings inside a variable by putting the variable inside a WriteLine
Example:

```
string sentence = "Giraffe Academy";
Console.WriteLine(sentence);
```

Would print:

```
Giraffe Academy
```

---

you can also concatenate strings using the + operator
Example:

```
Console.WriteLine("Concatenation is " + "cool");
```

Would print:

```
Concatenation is cool
```

---

The .Length property can be used to determine a string length
Example:

```
string sentence = "Giraffe Academy";
Console.WriteLine(sentence.Length);
```

Will print:

```
15
```

---

Strings have methods you can use like toUpper() to transfrom the text inside and print everything in uppercase
Example:

```
string sentence = "Giraffe Academy";
Console.WriteLine(sentence.ToUpper());
```

Will print:

```
GIRAFFE ACADEMY
```

---

The method Contains() can be used to check if a string contains a character or a substring
Example:

```
string sentence = "Giraffe Academy";
Console.WriteLine(sentence.Contains("Academy"));
Console.WriteLine(sentence.Contains("Academies"));
```

Will print:

```
True
False
```

---

You can get a single character from a string by using square brackets [] and using the index of the desired character
Example:

```
string sentence = "Giraffe Academy";
Console.WriteLine(sentence[0]);
```

Will print:

```
G
```

IMPORTANT: The indexing will start at 0

---

.IndexOf() will return the index where the character or string used in the parameter is located in the string. If the character is not inside the string it will return -1.

```
string sentence = "Giraffe Academy";
Console.WriteLine(sentence.IndexOf("Academy"));
```

Will print:

```
8
```

---

You can use substring to select a few characters of a string, you can add one parameter to select where the substring is gonna start (zero indexed) and you can add a second optional parameter to limit the substring to a certain length.

```
string sentence = "Giraffe Academy";
Console.WriteLine(sentence.Substring(8, 3));
```

Will Print:

```
Aca
```

---
