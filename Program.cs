// See https://aka.ms/new-console-template for more information
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
  internal class Program
  {
    static void Main(string[] args)
    {
      string characterName = "Jonas";
      int characterAge = 35;

      Console.WriteLine("There was a guy named " + characterName);
      Console.WriteLine("He was " + characterAge + " years old");
      Console.WriteLine("He really liked the name " + characterName);
      Console.WriteLine("But didn't like being " + characterAge);
    }
  }
}