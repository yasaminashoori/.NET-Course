using System;

namespace do_while
{
    class Program
    {
        static void Main(string[] args)
        {
            string age = null;
            do
            {
                Console.WriteLine("Enter your age : ");
                age = Console.ReadLine();
            } while (age == null);

            Console.WriteLine($"your age is : {age}");
        }
    }
}
