using System;
using System.Collections.Generic;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            var foods = new List<string>();
            foods.Add("Pizza");
            foods.Add("Burger");
            foods.Add("Kebab");
            foods.Insert(1, "frenchfries");

            foreach (var food in foods)
            {
                Console.WriteLine(food);
            }

            Console.WriteLine(foods.Contains("Burger"));
            Console.WriteLine(foods.Count);
        }
    }
}

