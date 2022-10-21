using System;

namespace Guess_the_word
{
    class Program
    {
        static void Main(string[] args)
        {


            int min = 1;

            int max = 100;

            bool againPlay = true;

            Random random2 = new Random();
            do
            {

                int inputGuess2 = 0;
                int numberRound2 = 0;
                int randomNumber2 = random2.Next(min, max + 1);

                while (inputGuess2 != randomNumber2)
                {
                    Console.WriteLine("Guess a number between 1 - 100 :");
                    inputGuess2 = Convert.ToInt32(Console.ReadLine());

                    if (inputGuess2 < randomNumber2)
                    {
                        Console.WriteLine($"{inputGuess2} is too low! guess another number :");
                    }
                    else if (inputGuess2 > randomNumber2)
                    {
                        Console.WriteLine(inputGuess2 + "is too high! guess another number :");
                    }
                    numberRound2++;
                }
                Console.WriteLine("Well done! The answer was " + randomNumber2);
                Console.WriteLine($"{numberRound2} Rounds");

                Console.WriteLine("Do you want to play again ? yes / no");
                var answer = Console.ReadLine().ToUpper();
                againPlay = answer.ToUpper() == "YES";

            } while (againPlay);

            Console.WriteLine("Thank you for playing :))");


        }
    }
}