using System;

namespace fisaghoresLaw
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your side A : ");

            var firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your side B : ");
            
            var secondNumber = Convert.ToInt32(Console.ReadLine());


            var pythagoras = Math.Sqrt(firstNumber * firstNumber + secondNumber * secondNumber);

            Console.WriteLine($"your result is : {pythagoras}");


        }
    }
}
