using System;

namespace _20_while
{
    class Program
    {
        static void Main(string[] args)
        { 
            string name = null;

            while (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Enter your name : ");
                name = Console.ReadLine();
            }

            Console.WriteLine("your name is "  + name );


            int number = 0;
            while (number <= 10)
            {
                Console.WriteLine(number++);
            }
        }
    }
}
