using System;
using System.Collections.Generic;

namespace Return
{
    class Program
    {
        private static double result;

        static void Main(string[] args)
        {
            Console.WriteLine(Pow());
            Console.WriteLine(SecondInput());
        }

        static double Pow()
        {
            Console.WriteLine("Enter your number for power operation :");
            var firstInput = Convert.ToDouble(Console.ReadLine());
            var result = Math.Pow(firstInput, 2);
            return result;
        }
        static double SecondInput()
        {
            string[] secondInput = new string[3];

            for (int i = 0; i < secondInput.Length; i++)
            {
                
            }
            Console.WriteLine($" max of numbers are : {bigNumbers.Max()}");
        }
    }
}
