using System;

namespace exercise_22
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
      Console.WriteLine("Give the third number! ");
      string third = Console.ReadLine();
      int intFirst = Convert.ToInt32(first);
      int intSecond = Convert.ToInt32(second);
      int intThird= Convert.ToInt32(third);
      double ave = (intFirst + intSecond + intThird) / 3.0;
      Console.WriteLine("The average is " + ave);
      Console.ReadLine();

    }
  }
}
