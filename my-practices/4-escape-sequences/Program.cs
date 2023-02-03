using System;

namespace escape_sequences
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int totalLines = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= totalLines; i++)
            {
                for (int x = i; x <= totalLines; x++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*" + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}