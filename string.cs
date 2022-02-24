using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      string Greeting="Hello";
      int len = Greeting.Length;
      Console.WriteLine(Greeting + " has "+ len + " charecters");
      Console.WriteLine($"{Greeting} has {len} charecters");
      string upper = Greeting.ToUpper();
      string lower = Greeting.ToLower();
      Console.WriteLine($"{upper}");
      Console.WriteLine($"{lower}");
      string output = lower+upper+Greeting;
      Console.WriteLine($"{output}");
      
     }
  }
}
