using System;

namespace Count_Odd_Numbers_leetcode_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number more than 0 as low number:");
            var low = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number more than low as high number : ");
            var high = Convert.ToInt32(Console.ReadLine());
            bool status = false;
            if (high >= low)
            {
                while (status == false)
                {
                    int[] numbers = new int[high - low];
                    numbers[0] = low;
                    numbers[1] = low + 1;
                    numbers[2] = low + 2;
                    numbers[3] = low + 3;
                    // low = low + 1;
                    foreach (var item in numbers)
                    {
                        if (numbers.Length / 2 != 0)
                        {
                            Console.WriteLine($"The final result for Count Odd numbers : {item}");
                            // Console.WriteLine(item);
                        }
                        else
                        {
                            Console.WriteLine("There is no odd number.");
                        }
                    }
                    status = true;
                }
            }
        }
    }
}
