using System;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your height in cm :");

            var height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter your weight in kg:");

            var weight = Convert.ToDouble(Console.ReadLine());

            var bmi = Math.Round(weight / Math.Pow(height / 100, 2), 2);

        
            if (bmi <= 18.4)
            {
                Console.WriteLine($"BMI = {bmi} You are Underweight");
            }

            else if (bmi >= 18.52 && bmi <= 24.9)
            {
                Console.WriteLine($"BMI = {bmi} You are Normal");
            }

            else if (bmi >= 25.0 && bmi <= 39.9)
            {
                Console.WriteLine($"BMI = {bmi} You are Overweight");
            }

            else
            {
                Console.WriteLine($"BMI = {bmi} You are Obese");
            }


        }
    }
}
