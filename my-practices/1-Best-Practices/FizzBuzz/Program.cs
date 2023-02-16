using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number :");
            var number = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("FizzBuzz result:");
            FizzBuzz(number);
        }

        public static void FizzBuzz(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
