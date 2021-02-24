using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            var r = new Random();
            Console.WriteLine("Guess the number!!");
            var userInput = int.Parse(Console.ReadLine());
            int favNumber = r.Next(1, 69);
            if (userInput < favNumber)
            {
                Console.WriteLine("You got to go up!");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine("Go down a bit!");
            }
            else if (userInput == favNumber)
            {
                Console.WriteLine("Great job!!!");
            }
            else
            {
                Console.WriteLine("Nevermind.");
            }


        }
    }
}
 