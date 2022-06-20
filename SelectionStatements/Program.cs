using System;

namespace SelectionStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int favNumber = 7;

            Console.WriteLine("Guess my favorite number");
            int userGuess = int.Parse(Console.ReadLine());

            if (userGuess < favNumber)
            {
                Console.WriteLine("Too Low");
            }
            else if (userGuess > favNumber)
            {
                Console.WriteLine("Too High");
            }
            else if (userGuess == favNumber)
            {
                Console.WriteLine("YOU GOT IT!!");
            }
            else 
            {
                Console.WriteLine("nevermind");
            }
        }
    }
}
