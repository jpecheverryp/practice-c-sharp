// See https://aka.ms/new-console-template for more information
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
  internal class Program
  {
    static void Main(string[] args)
    {
      // Strings
      string sentence = "This is some text";
      // Characters
      char grade = 'A';
      // Integers
      int integerNumber = 24;
      // Floats
      float floatNumber = 0.5F;
      decimal decimalFloat = 0.10M;
      // Booleans
      bool isGreater = true;

      Console.WriteLine(sentence);
      Console.WriteLine(grade);
      Console.WriteLine(integerNumber);
      Console.WriteLine(floatNumber);
      Console.WriteLine(decimalFloat);
      Console.WriteLine(isGreater);
    }
  }
}