using System;

namespace first_factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int factorial = 1;
            Console.WriteLine("enter your number:");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < number; i++)
            {
                factorial = factorial * i;
                Console.WriteLine("the factorial of {number} is factorial}");
            }
            // int factorial = 1;

            // Console.WriteLine("enter your number:");

            //  int number = Convert.ToInt32(Console.ReadLine());

            // for (int counter = 1; counter <= number; counter++)
            // {
            //     factorial = factorial * counter;

            // }

            // Console.WriteLine("The factorial of {0} is {1}", number, factorial);
        }
    }
}

// static void Main(string[] args)
//         {
//             Console.WriteLine("Please enter an int number : ");
//             int result = Convert.ToInt32(Console.ReadLine());
//             Console.WriteLine(FirstFactorial(result));
//         }

//         public static int FirstFactorial(int num)
//         {
//             if (num == 1)
//                 return 1;
//             return num * FirstFactorial(--num);
//         }