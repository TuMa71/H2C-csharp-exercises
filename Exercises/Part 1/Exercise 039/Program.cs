using System;

namespace exercise_39
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      int sum = 0;

      while (true)
            {
                Console.WriteLine("Give a number: ");
                int userInput = Convert.ToInt32(Console.ReadLine());
                if (userInput == 0)
                {
                    break;
                } else 
                {
                    sum = sum + userInput;
                }
       
    }
    Console.WriteLine("Total sum of numbers: " + sum);
    Console.ReadLine(); 

    }
  }
}
