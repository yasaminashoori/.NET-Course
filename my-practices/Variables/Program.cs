using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14;
            Console.WriteLine(pi);
            // const values couldn't change and they are read-only values

            int x; //declaration
            x = 150; // initialization

            bool status = false; // boolean data type

            double y = -12.498;
            float small = 12.484F;
            long bigInt = 1303039933;
            Console.WriteLine("variables are " +  x +  y +  small +  bigInt);

            // double first=12.3, second, third = 194.43;

            int second, third = 294, first = 32;

            // Console.WriteLine($"the results are: {first} {second} {third}");
            /*
            
            * search later about this error 
            and find the solution

            */

        }
    }
}

