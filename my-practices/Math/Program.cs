using System;

namespace math
{
    class Program
    {
        static void Main(string[] args)
        {

            int number2 = -10;
            double result2 = Math.Pow(number2, 3);
            Console.WriteLine(result2);

            double number = Math.Pow(number2, 2);
            Console.WriteLine(number);
            // double number means that the result of the Pow is double type although 3 is int


            int number4 = 36;
            int result3 = (int) Math.Sqrt(number4);
            Console.WriteLine(result3);
            // sqrt result is a double type but we convert the Math method to int

            double number3 = 32.56;

            double result = Math.Abs(number2);

            double result4 = Math.Round(number3);

            double result5 = Math.Ceiling(number3);

            double result6 = Math.Floor(number3);

            double result7 = Math.Max(number3, number2);
            double result8 = Math.Min(number3, number2);

            double result9 = Math.PI;
            // const of PI
        }
    }
}
