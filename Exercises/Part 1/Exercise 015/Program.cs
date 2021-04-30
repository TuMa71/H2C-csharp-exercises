using System;

namespace exercise_15
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("Give a string: ");
      string inputString = Console.ReadLine();
      Console.WriteLine("Give an integer: ");
      string userInt = Console.ReadLine();
      int intValue = Convert.ToInt32(userInt);
      Console.WriteLine("Give a double: ");
      string userDouble = Console.ReadLine();
      double doubleValue = Convert.ToDouble(userDouble);
      Console.WriteLine("Give a boolean: ");
      string userBoolean  = Console.ReadLine();
      Boolean  booleanValue = Convert.ToBoolean(userBoolean);
      Console.Write("Your string: " + inputString + "\n");
      Console.Write("Your integer: " + intValue + "\n");
      Console.Write("Your double: " + doubleValue + "\n");
      Console.Write("Your boolean: " + booleanValue + "\n");
      

    }
  }
}
