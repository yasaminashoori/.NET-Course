using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14;
            Console.WriteLine(pi); //read-only

            int x; //declaration
            x = 150; //initialization

            bool status = false;
            double y = -12.498;
            float floatNumber = 12.484F;
            long bigInt = 1303039933;
            Console.WriteLine("variables are " +  x +  y +  floatNumber +  bigInt);

            int first = 32, second, third = 29;

            Console.WriteLine($"the results are: {first}{third}");
        }
    }
}

