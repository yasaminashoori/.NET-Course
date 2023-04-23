using System;

namespace Add_Two_Integers_Leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            SumOfInts();
        }

        static void SumOfInts()
        {
            Console.WriteLine("Enter your first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int sum = num1 + num2;
            Console.WriteLine($"Sum of numbers :{sum}");
        }
    }
}
