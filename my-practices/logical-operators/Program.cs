using System;

namespace logical_operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // logical operators

            string name = null;
            // var name = "";
            // var name = string.Empty;

            while (name == "")
            // while (string.IsNullOrEmpty(name))
            // while (name == "" || name = null)
            {
                Console.WriteLine("Enter your name : ");
                name = Console.ReadLine();
            }

            Console.WriteLine("your name is "  + name );
        }
    }
}
