﻿using System;

namespace exercise_10
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("I will tell a story, but I need some information.");
            Console.WriteLine("Give a name for main character:");
            string name = Console.ReadLine();
            Console.WriteLine("Give the character a profession:");
            string profesion = Console.ReadLine();
            Console.WriteLine("Here is the story:");
            Console.WriteLine("Once upon a time there was " + profesion + " called " + name);
            Console.WriteLine("On her way to work, " + name + " often pondered what being " + profesion + " meant to them.");
            Console.WriteLine("When you work as " + profesion + " you meet interesting people.");
            Console.WriteLine(name + " enjoys their work as " + profesion + ", The end.");
           


        }
    }
}
