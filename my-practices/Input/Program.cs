using System;

namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string result1 = Console.ReadLine();
            // double result1 = Convert.ToDouble(input);
            // with convert to method input just accepts the defined type not string if we want to string should't used any 
            // convert to method

            Console.WriteLine("Enter your age:");
            double result2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("your result1 is " + result1 + "and result2 is " + result2);

            Console.WriteLine("Enter your ID : ");
            string input = Console.ReadLine();
            double result3 = Convert.ToInt32(input);

        }
    }
}
