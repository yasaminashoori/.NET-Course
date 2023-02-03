using System;

namespace ArithmeticsOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 3;
            
            number += 2;
            number++;
            Console.WriteLine(number);

            number = number + 6;
            number--;
            Console.WriteLine(number);

            number = number / 2;
            number /= 2;
            Console.WriteLine(number);

            number = number % 2;
            number %= 2;
            Console.WriteLine(number);

            number = number * 2;
            number *= 2;
            Console.WriteLine(number);
            
            // odd or even number with % 
            Console.WriteLine("Enter your number : ");
            double numberPercent = Convert.ToDouble(Console.ReadLine());
            numberPercent %= 2;
            if (numberPercent == 0)
            {
                Console.WriteLine("this is an even number !");
            }
            else
            {
                Console.WriteLine("this is an odd number !");
            }
        }
    }
}
