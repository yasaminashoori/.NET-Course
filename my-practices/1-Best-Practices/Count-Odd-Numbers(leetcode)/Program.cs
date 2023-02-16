using System;

namespace Count_Odd_Numbers_leetcode_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number more than 0 as low number:");
            var low = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number more than low number, as high number : ");
            var high = Convert.ToInt32(Console.ReadLine());
            // var between = high - low + 1;
            int[] nums = new int[high - low + 1];
            for (int i = 0; i < 10; i++)
            {
                nums[i] = low;
                var result = nums[i];
                ++low;
                if (result % 2 != 0)
                {
                    Console.WriteLine("The odds numbers are : " + nums[i]);
                }
            }
        }
    }
}
