using System;

namespace exercise_23
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
      int sum = intFirst + intSecond;
      int min = intFirst - intSecond;
      int mul = intFirst * intSecond;
      double div = intFirst / (double)intSecond;
      Console.WriteLine(intFirst + " + " + intSecond + " = " + sum);
      Console.WriteLine(intFirst + " - " + intSecond + " = " + min);
      Console.WriteLine(intFirst + " * " + intSecond + " = " + mul);
      Console.WriteLine(intFirst + " / " + intSecond + " = " + div);
      Console.ReadLine();

    }
  }
}
