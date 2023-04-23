using System;

namespace CLI_BMI
{
    class Program
    {
        // create a program that when you typed dotnet run => use --help invalid command and

        // if typed dotnet run --helps not dotnet run bmi --helps worked
        // divide the program to the inner methods and pass them to the final(main) method .
        static void Main(string[] args)
        {
            CommandInputs(args);
            RunMainCommands(args);
        }

        static void NotRelatedCommands()
        {
            Console.WriteLine("Invalid command :( \n Use --helps switch to show help");
        }

        static void Helps()
        {
            Console.WriteLine("\n --height \t Your height (centimeters) ");
            Console.WriteLine("\n --weight \t Your weight (kilograms) ");
            Console.WriteLine("\n --version \t Show current version ");
            Console.WriteLine("\n --helps \t Show command list ");
        }

        static void Version()
        {
            Console.WriteLine("Current verson is : 1.0");
        }



        static void CommandInputs(string[] args)
        {
            if (args[1] == "--height" && args[3] == "--weight")
            {
                var weight = Convert.ToInt32(args[4]);
                var height = Convert.ToDouble(args[2]);
                BmiFormula(height, weight);
                
            }
            else if (args[1] == "--weight" && args[3] == "--height")
            {
                var weight = Convert.ToInt32(args[2]);
                var height = Convert.ToDouble(args[4]);
                BmiFormula(height, weight);
            }
        }

        

        static double BmiFormula(double height, double weight)
        {
            height = Convert.ToDouble(Console.ReadLine());

            weight = Convert.ToDouble(Console.ReadLine());

            var bmi = Math.Round(weight / Math.Pow(height / 100, 2), 2);

            if (bmi <= 18.4)
            {
                
                Console.WriteLine($"You are Underweight");
                return bmi;

            }
            else if (bmi >= 18.52 && bmi <= 24.9)
            {
                Console.WriteLine($"You are Normal");
                return bmi;
            }
            else if (bmi >= 25.0 && bmi <= 39.9)
            {
                Console.WriteLine($"You are Overweight");
                return bmi;
            }
            else
            {
                Console.WriteLine($"You are Obese");
                return bmi;
            }
        }


        static void RunMainCommands(string[] args)
        {
            if (args.Length > 0)
            {
                if (args[0] == "bmi")
                {
                    if (args.Length > 1)
                    {
                        if (args[1] == "--helps")
                        {
                            Helps();
                            Environment.Exit(0);
                        }
                        else if (args[1] == "--version")
                        {
                            Version();
                            Environment.Exit(0);
                        }
                        else if (args[0] == "bmi" && args.Length == 5)
                        {
                            CommandInputs(args);
                        }
                    }
                }
            }
            else
            {
                NotRelatedCommands();
                Environment.Exit(0);
            }
        }
    }
}
