using System;

namespace _54_Enum
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Alphabet.C);
            Console.WriteLine((int)Months.April);

            var numberMonths = (Months) 3;
            Console.WriteLine(numberMonths);

            Console.WriteLine("Guess decimal value of A or a : ");
            var guessedInput = Console.ReadLine();
            var guessedNumber =  Enum.Parse(typeof(Alphabet), guessedInput);
            switch (guessedNumber)
            {
                case Alphabet.A:
                Console.WriteLine("TRUE");
                break;
                case Alphabet.a:
                Console.WriteLine("TRUE");
                break;
                default:
                Console.WriteLine("Wrong answer.");
                break;
            }
        }
    }
}
