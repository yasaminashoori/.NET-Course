using System;

namespace Guess_the_word
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            
            int Guess = 0;

            int round = 1;

            var againPlay = false;
            do
            {
                Console.WriteLine("I am thinking of a number between 1-100.  Can you guess what it is?");
                int returnValue = random.Next(1, 100);

                while (Guess != returnValue)
                {
                    Guess = Convert.ToInt32(Console.ReadLine());

                    if (Guess < returnValue)
                    {
                        Console.WriteLine("No, the number I am thinking of is higher than " + Guess + ". Can you guess what it is?");
                        round++;
                    }
                    else if (Guess > returnValue)
                    {
                        Console.WriteLine("No, the number I am thinking of is lower than " + Guess + ". Can you guess what it is?");
                        round++;
                    }
                }
                Console.WriteLine("Well done! The answer was " + returnValue);
                Console.WriteLine($"Finished in {round} rounds");
                Console.WriteLine("DO you want to play more ? yes or no ");
                againPlay = Console.ReadLine().ToUpper() == "NO";

            } while (!againPlay);

            Console.WriteLine("Thanks for playing ^ --- ^ ");
        }
    }
}