using System;
using System.Collections.Generic;

namespace _3_dividing_2numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    OperationDivide();
                    break;
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Enter another number !");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Try again !");
                }
            }
        }

        static void OperationDivide()
        {
            Console.WriteLine("Enter your first number :");
            var firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your second number :");
            var secondNum = Convert.ToInt32(Console.ReadLine());
            var result = firstNum / secondNum;
            Console.WriteLine($"your result is : {result}");
        }
    }
}
