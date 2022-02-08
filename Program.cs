// See https://aka.ms/new-console-template for more information
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
  internal class Program
  {
    static void Main(string[] args)
    {
      // Line jump
      Console.WriteLine("Giraffe\nAcademy");
      // Escaping double quotes
      Console.WriteLine("Giraffe\"Academy");
      // Print a variable content
      string sentence = "Giraffe Academy";
      Console.WriteLine(sentence);
      // Concatenation
      Console.WriteLine("Concatenation is " + "cool");
      // Print a string length
      Console.WriteLine(sentence.Length);
      // uppercase method
      Console.WriteLine(sentence.ToUpper());
      // Contains method
      Console.WriteLine(sentence.Contains("Academy"));
      Console.WriteLine(sentence.Contains("Academies"));
      // First character
      Console.WriteLine(sentence[0]);
      // Index Of
      Console.WriteLine(sentence.IndexOf("Academy"));
      Console.WriteLine(sentence.IndexOf("f"));
      Console.WriteLine(sentence.IndexOf("z"));
      // Substring
      Console.WriteLine(sentence.Substring(8, 3));

      Console.ReadLine();


    }
  }
}