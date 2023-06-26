using System;

namespace conditional_statements
{
    class Program
    {
        static void Main(string[] args)
        {
            int weight = 700;
            Console.WriteLine(weight >= 500); // True
            char gender = 'm';
            Console.WriteLine(gender <= 'f'); // False
            double colorWaveLength = 1.630;
            Console.WriteLine(colorWaveLength > 1.621); // True
            int a = 5;
            int b = 7;
            bool condition = (b > a) && (a + b < a * b);
            Console.WriteLine(condition); // True
            Console.WriteLine('B' == 'A' + 1); // True
        }
    }
}
