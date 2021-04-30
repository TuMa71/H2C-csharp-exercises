using System;

namespace exercise_21
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      // Write your code here:
      Console.WriteLine("Give the first number! ");
      string first = Console.ReadLine();
      Console.WriteLine("Give the second number! ");
      string second = Console.ReadLine();
      int intFirst = Convert.ToInt32(first);
      int intSecond = Convert.ToInt32(second);
      double ave = (intFirst + intSecond) / 2.0;
      Console.WriteLine("The average is " + ave);
      Console.ReadLine();

    }
  }
}
