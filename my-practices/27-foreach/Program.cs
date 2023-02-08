using System;
using System.Collections.Generic;

namespace _27_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            var fibNumbers = new List<int> { 0, 1, 1, 2, 3, 5, 8, 13 };
            foreach (int element in fibNumbers)
            {
                Console.Write($"{element} ");
            }
            // Output:
            // 0 1 1 2 3 5 8 13

            Span<int> numbers = new int[] { 3, 14, 15, 92, 6 };
            foreach (int number in numbers)
            {
                Console.Write($"{number} ");
            }
            // Output:
            // 3 14 15 92 6
        }
    }
}
