using System;

namespace exercise_38
{
  class Program
  {
    public static void Main(string[] args)
    {
     int sum = 0;
     while (true)
            {
                Console.WriteLine("Give a number: ");
                int userInput = Convert.ToInt32(Console.ReadLine());
                if (userInput == 0)
                {
                    break;
                } else if (userInput < 0)
                {
                    sum = sum + 1;
                }
       
    }
    Console.WriteLine("Total amoount of  negative numbers: " + sum);
    Console.ReadLine(); 

    }
  }
}
