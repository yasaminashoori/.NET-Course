using System;

namespace CLI_BMI
{
    class Program
    {

        static void Main(string[] args)
        {
            BmiCommand(args);
            Calculation(args);

        }

        static void Calculation(string[] args)
        {
            if (args[0] == "bmi" && args[1] == "--version")
            {
                VersionCommand();
                Environment.Exit(0);
            }
            else if (args[0] == "bmi" && args[1] == "--helps")
            {
                HelpsCommand();
                Environment.Exit(0);
            }
            else if (args[0] == "bmi" && args.Length == 5)
            {
                BmiCommand(args);
            }
            else
            {
                InvalidCommand();
                Environment.Exit(0);
            }
        }


        static void InvalidCommand()
        {
            Console.WriteLine("Invalid command :( \nUse --helps switch to show help");
        }

        static void VersionCommand()
        {
            Console.WriteLine("Current version is : 1.0");
        }

        static void HelpsCommand()
        {
            Console.WriteLine("\n --height \t Your height (centimeters) ");
            Console.WriteLine("\n --weight \t Your weight (kilograms) ");
            Console.WriteLine("\n --version \t Show current version ");
            Console.WriteLine("\n --helps \t Show command list ");
        }

        static void BmiCommand(string[] args)
        {
            // if (args.Length != 0 || args[0] != "bmi" || args.Length == 5)
            // {
            //     Calculation(args);
            // }
            if (args[1] == "--height" && args[3] == "--weight")
            {
                var height = Convert.ToDouble(args[4]);
                var weight = Convert.ToDouble(args[2]);
                BmiFormula(height, weight);
            }
            if (args[1] == "--weight" && args[3] == "--height")
            {
                var height = Convert.ToDouble(args[2]);
                var weight = Convert.ToDouble(args[4]);
                BmiFormula(height, weight);
            }
            else
            {
                Calculation(args);
            }
        }


        static void BmiFormula(double height, double weight)
        {
            height = Convert.ToDouble(Console.ReadLine());
            weight = Convert.ToDouble(Console.ReadLine());

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
