using System;

namespace _35_Error_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name :");
            try
            {
                string name = Console.ReadLine();
                Console.WriteLine("Enter your password :");
                double password = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"your name is {name} \n password : {password}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter an inteeger password and string names");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
