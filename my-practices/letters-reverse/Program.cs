using System;

namespace letters_reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter letter 1 :");
            var letterOne = Console.ReadLine();
            Console.WriteLine("Enter letter 2:");
            var letterTwo = Console.ReadLine();
            Console.WriteLine("Enter letter 3 :");
            var letterThree = Console.ReadLine();
            string[] letters = { letterOne, letterTwo, letterThree };
            Array.Reverse(letters);
            Console.WriteLine(Array.Reverse(letters));
        }
    }
}
