using System;

namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string result1 = Console.ReadLine();
            
            Console.WriteLine("Enter your age:");
            double result2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("your result1 is " + result1 + "and result2 is " + result2);

            Console.WriteLine("Enter your ID : ");
            string input = Console.ReadLine();
            double result3 = Convert.ToInt32(input);

        }
    }
}
