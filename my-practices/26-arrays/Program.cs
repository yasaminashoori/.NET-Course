using System;
using System.Linq;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] froots = { "apple", "melon" };
            double[] bigNumbers = { 2274, 24000, 12123340, 2385 };

            froots[1] = "Lemon"; //Changing the valuee of array
            Console.WriteLine(froots); //print the name space
            Console.WriteLine(bigNumbers[0]);
            Console.WriteLine(Array.Sort(bigNumbers));


            for (int i = 0; i < froots.Length; i++) //print all of the values of array
            {
                Console.WriteLine(froots[i]);
            }

            Console.WriteLine($" max of numbers are : {bigNumbers.Max()}");
            Console.WriteLine($" Min of numbers are : {bigNumbers.Min()}");
            Console.WriteLine($" Sum of numbers are : {bigNumbers.Sum()}");

            //other ways for declration
            string[] apps = new string[2];
            apps[0] = "telegram";
            apps[0] = "Instagram";
            apps[0] = "Discord";
            string[] students = new string[] { "yalda", "amir" };
            foreach (var applications in apps)
            {
                Console.WriteLine($"the indexes are : {applications}");
            }
            

            //Another array :  declares an 1D Array of string
            string[] coffeeShop;

            // allocating memory for coffee names.
            coffeeShop = new string[] {"Americano, ", "Cafe au lait, ",
                              "Espresso, ", "Cappuccino, ",
                              "Long Black, ", "Macchiato" };

            // Displaying Elements of the array
            Console.WriteLine("Different types of coffee: ");
            Console.WriteLine();
            foreach (string coffeename in coffeeShop)
                Console.WriteLine(coffeename + " ");
        }
    }
}
