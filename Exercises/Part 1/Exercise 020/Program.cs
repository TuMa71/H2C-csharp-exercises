using System;

namespace exercise_20
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("Give the first number! ");
      string first = Console.ReadLine();
      Console.WriteLine("Give the second number! ");
      string second = Console.ReadLine();
      int intFirst = Convert.ToInt32(first);
      int intSecond = Convert.ToInt32(second);
      int mult = intFirst * intSecond;
      Console.WriteLine(intFirst + " * " + intSecond + " = " + mult);
      Console.ReadLine();
    }
  }
}
