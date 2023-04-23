using System;
using System.Linq;

namespace my_console_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two number to power it:\nFirst number :");
            var firstNumberPow = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Second number :");
            var secondNumberPow = Convert.ToDouble(Console.ReadLine());

            var power = Pow(firstNumberPow, secondNumberPow);
            Console
                .WriteLine(firstNumberPow +
                " power " +
                secondNumberPow +
                " : " +
                power);

            Console.ReadLine();
            Console.Clear();

            Console
                .WriteLine("Enter 5 numbers : (Press enter for each number) ");

            var myArray = new double[5];
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = Convert.ToDouble(Console.ReadLine());
            }

            var maximum = MaximumOfNumbers(myArray);
            var minimum = MinimumOfNumbers(myArray);

            Console.WriteLine($"Maximum number is: {maximum}");
            Console.WriteLine($"Minimum number is: {minimum}");
        }

        static double Pow(double firstNumberPow, double secondNumberPow)
        {
            double number = firstNumberPow;

            if (firstNumberPow == 0)
            {
                return 0;
            }
            if (firstNumberPow == 0)
            {
                return 1;
            }
            else
            {
                for (int y = 1; y < secondNumberPow; y++)
                {
                    number *= firstNumberPow;
                }
            }
            return number;
        }

        
        static double MaximumOfNumbers(double[] myArray)
        {
            double maxElement = myArray[0];
            for (int index = 1; index < myArray.Length; index++)
            {
                if (myArray[index] > maxElement)
                {
                    maxElement = myArray[index];
                }
            }
            return maxElement;
        }

        static double MinimumOfNumbers(double[] myArray)
        {
            double minElement = myArray[0];
            for (int index = 1; index < myArray.Length; index++)
            {
                if (myArray[index] < minElement)
                {
                    minElement = myArray[index];
                }
            }
            return minElement;
        }
    }
}
