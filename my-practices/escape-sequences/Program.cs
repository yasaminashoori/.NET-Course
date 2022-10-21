using System;

namespace escape_sequences
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, rows;
            n = 5;
            for (rows = 0; rows <= n; rows++)
            {
                for (int s = 5; s <= n; s--)
                {
                    Console.Write("-*");
                }
                Console.WriteLine();
            }
        }
    }
}