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
            // var between = high - low + 1;
            int[] nums = new int[high - low + 1];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(nums[i] = low);
                ++low;
            }
        }
    }
}
