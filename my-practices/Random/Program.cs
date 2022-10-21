using System;

namespace random
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomNumber = new Random();
            int result = randomNumber.Next(1, 100);
            Console.WriteLine(result);
            

            double result1 = randomNumber.NextDouble();
            Console.WriteLine(result1);
        }
    }
}
