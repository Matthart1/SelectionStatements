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

            Console.WriteLine("What was your favorite subject in school?");
            string subject = Console.ReadLine();

            switch (subject)
            {
                case "math":
                    Console.WriteLine("Math is pretty cool.");
                    Console.WriteLine("What a hoot!");
                    break;
                case "science":
                    Console.WriteLine("Now thats a subject that'll take you places!");
                    break;
                case "literature":
                    Console.WriteLine("All great minds enjoy literature!");
                    break;
                case "english":
                    Console.WriteLine("Lame, Loser subject");
                    break;
                case "history":
                    Console.WriteLine("Must remember the history!!");
                    break;
                default:
                    Console.WriteLine("I have to opinion.");
                    break;
            }


        }
    }
}
 