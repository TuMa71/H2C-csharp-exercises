using System;

namespace exercise_37
{
  class Program
  {
    public static void Main(string[] args)
    {
      int sum = 0;
      // Write your code here:
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
                }
       
    }
    Console.WriteLine("Total amooun of numbers: " + sum);
    Console.ReadLine();
    }
  }
}
