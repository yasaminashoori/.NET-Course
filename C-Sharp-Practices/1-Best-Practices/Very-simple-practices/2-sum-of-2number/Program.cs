using System;

namespace _2_sum_of_2number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first number :");
            var firstNum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your second number :");
            var secondNum = Convert.ToDouble(Console.ReadLine());
            var result = firstNum + secondNum;
            Console.WriteLine($"your result is : {result}");
        }
    }
}
