using System;

namespace math
{
    class Program
    {
        static void Main(string[] args)
        {

            int number2 = 10;
            double result = Math.Pow(number2, 2);
            Console.WriteLine(result);

            double result2 = Math.Pow(number2, 3);
            Console.WriteLine(result2);

            int number4 = 36;
            int result3 = (int)Math.Sqrt(number4);
            Console.WriteLine(result3);

            double number3 = 32.56;

            double result0 = Math.Abs(number2);
            Console.WriteLine(result0);

            double result4 = Math.Round(number3);
            Console.WriteLine(result4);

            double result5 = Math.Ceiling(number3);
            Console.WriteLine(result5);

            double result6 = Math.Floor(number3);
            Console.WriteLine(result6);
            
            double result7 = Math.Max(number3, number2);
            Console.WriteLine(result7);

            double result8 = Math.Min(number3, number2);
            Console.WriteLine(result8);

            double result9 = Math.PI;
            Console.WriteLine(result9);
        }
    }
}
