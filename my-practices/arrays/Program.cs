using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] froots = { "apple", "melon" };
            int[] bigOnes = { 2, 24, 12, 235 };

            Console.WriteLine(froots);
            // Console.WriteLine(bigOnes[0]);
            Array.Sort(bigOnes);

            string[] apps = new string[2];
            apps[0] = "telegram";

            string[] students = new string[] { "yalda", "amir" };

            for (int i = 0; i < bigOnes.Length; i++)
            {
                Console.WriteLine(bigOnes[i]);
            }

            Console.WriteLine($" max of numbers are : {bigOnes.Max()}");
            //**************************************************** search for max it didn't work !

            double[] ints = { 2, 24, 12, 235 };

            foreach (var applications in apps)
            {
                Console.WriteLine($"the indexes are : {applications}");
            }
        }
    }
}
