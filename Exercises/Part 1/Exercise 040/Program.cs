using System;

namespace exercise_40
{
  class Program
  {
    public static void Main(string[] args)
    {

      int sum = 0;
      int sum2 = 0;

      while (true)
            {
                Console.WriteLine("Give a number: ");
                int userInput = Convert.ToInt32(Console.ReadLine());
                if (userInput == 0)
                {
                    break;
                } else 
                {
                    sum = sum + 1;
                    sum2 = sum2 + userInput;
                }
       
    }
    Console.WriteLine("Total sum of numbers: " + sum2);
    Console.WriteLine("Total amount of numbers: " + sum);
    Console.ReadLine(); 
    }
  }
}
