using System;

namespace workspace_code
{
    class Program
    {
        static void Main(string[] args)
        {
            // Challenge 1 : calculate sqrt / the easiest wqy 
            Console.WriteLine("Enter side A : ");
            double sideA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter side B : ");
            double sideB = Convert.ToDouble(Console.ReadLine());

            double result = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));

            Console.WriteLine($"your result is : {result}");

            // with class 
        }
    }
}
