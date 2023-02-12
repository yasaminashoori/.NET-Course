using System;

namespace workspace_code
{
    class Program
    {
        static void Main(string[] args)
        {
            // while (args[0] == "bmi" || args[0] == " ")
            if (args[0] == "bmi")
            {
                if (args[1] == "--helps")
                {
                    HelpsCommand();
                }
                if (args[1] == "--version")
                {
                    VersionCommand();
                }
                if (args[0] == "bmi" && args.Length == 5)
                {
                    BmiCalculator(args);
                }
            }
            else
            {
                ErrorMessage();
            }
        }

        static void ErrorMessage()
        {
            Console.WriteLine("Invalid Command :(  \n Use --helps switch to show help");
        }

        static void HelpsCommand()
        {
            Console.WriteLine("\n --height \t Your height (centimeters) ");
            Console.WriteLine("\n --weight \t Your weight (kilograms) ");
            Console.WriteLine("\n --version \t Show current version ");
            Console.WriteLine("\n --helps \t Show command list ");
        }

        static void VersionCommand()
        {
            Console.WriteLine("Current version is : 1.0");
        }

        static void BmiCalculator(string[] args, double height, double weight)
        {
            // // var height = "";
            // double heightNum;
            // // var weight = "";
            // double WeightNum;
            // height = Convert.ToDouble(Console.ReadLine());
            // weight = Convert.ToDouble(Console.ReadLine());
            var bmi = weight / Math.Pow(height, 2);
            if ((args[1] == "--height" && height == args[2] && args[3] == "--weight" && weight == args[4]))
            {
                if (bmi <= 18.4)
                {
                    Console.WriteLine($"Your BMI score is : \n {bmi} \n Your status is : \n Underweight");
                }

                else if (bmi >= 18.52 && bmi <= 24.9)
                {
                    Console.WriteLine($"Your BMI score is : \n {bmi} \n Your status is : \n Normal");
                }

                else if (bmi >= 25.0 && bmi <= 39.9)
                {
                    Console.WriteLine($"Your BMI score is : \n {bmi} \n Your status is : \n Overweight");
                }

                else
                {
                    Console.WriteLine($"Your BMI score is : \n {bmi} \n Your status is : \n Obese");
                }
            }
            else if ((args[3] == "--height" && heightNum == args[4] && args[1] == "--weight" && WeightNum == args[2]))
            {
                if (bmi <= 18.4)
                {
                    Console.WriteLine($"Your BMI score is : \n {bmi} \n Your status is : \n Underweight");
                }

                else if (bmi >= 18.52 && bmi <= 24.9)
                {
                    Console.WriteLine($"Your BMI score is : \n {bmi} \n Your status is : \n Normal");
                }

                else if (bmi >= 25.0 && bmi <= 39.9)
                {
                    Console.WriteLine($"Your BMI score is : \n {bmi} \n Your status is : \n Overweight");
                }

                else
                {
                    Console.WriteLine($"Your BMI score is : \n {bmi} \n Your status is : \n Obese");
                }
            }
        }
    }
}
