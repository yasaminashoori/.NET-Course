using System;

namespace print_name
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your full name :");
            var name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Hello : \n{name} !");
        }
    }
}
