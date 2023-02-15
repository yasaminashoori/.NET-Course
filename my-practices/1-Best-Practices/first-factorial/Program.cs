using System;

namespace first_factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstFactorial();
        }

        static void FirstFactorial()
        {
            int factorial = 1;
            Console.WriteLine("enter your number:");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                factorial = factorial * i;
            }
            Console.WriteLine($"the factorial of {number} is {factorial}");
        }
    }
}