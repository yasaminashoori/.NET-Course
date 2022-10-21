using System;
using System.Linq;
namespace BMI_cli
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine(BmiCalc(args));
        }
        public static string BmiCalc(string[] args)
        {
            const string help = "--helps";
            const string version = "--version";
            const string weight = "--weight";
            const string height = "--height";

            string bmistr = null;
            string versionStr = "1.0";

            double weightDouble;
            double heightDouble;
            double bmi;

            if (args.Length > 0)
            {


                if (args[0].ToLower() == "bmi")
                {
                    if (args.Length > 1)
                    {
                        switch (args[1].ToLower())
                        {
                            case help:
                                return ($"Options: \n{height}          Your height(m) \n{weight}          Your weight(kg) \n{version}         Show current version \n{help}           Show command list".ToString());

                            case version:
                                return ($"Current version is: {versionStr}").ToString();

                            case weight:
                            case height:
                                if (args.Contains(height) && args.Contains(weight))
                                {
                                    weightDouble = double.Parse(args[(Array.IndexOf(args, weight)) + 1]);
                                    heightDouble = double.Parse(args[(Array.IndexOf(args, height)) + 1]);
                                    bmi = weightDouble / Math.Pow(heightDouble, 2);

                                    if (bmi < 18.5)
                                    {
                                        bmistr = "Severe Thinness";
                                    }
                                    else if (bmi >= 18.5 && bmi < 25)
                                    {
                                        bmistr = "Normal";

                                    }
                                    else if (bmi >= 25 && bmi < 30)
                                    {
                                        bmistr = "Overweight";

                                    }
                                    else if (bmi >= 30)
                                    {
                                        bmistr = "Obese";

                                    }
                                    return ($"Your BMI Score is: \n{string.Format("{0:0.00}", bmi)} \nYour Status is: {bmistr}".ToString());
                                }
                                else
                                {
                                    return ($"invalid command \nEnter bmi {help}").ToString();
                                }


                            default:
                                return ($"Invalid command \nEnter bmi {help}").ToString();

                        }

                    }
                    else
                    {
                        return ($"options: \n{version}   current version \n{help}    show command list").ToString();

                    }

                }
                else
                {
                    return ($"Invalid command \nEnter bmi {help} to show help").ToString();
                }





            }
            else
            {
                return "Invalid command \nEnter bmi --helps to show help";
            }
        }

        }
    }

// using System;

// namespace CLI_BMI
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             var commandMessage = "Invalid command :( \nUse --helps switch to show help";
//             // string[] inputs = new string[7];
//             // inputs[0] = "bmi";

//             var bmiInput = inputs[0];
//             // bmiInput = Console.ReadLine();
//             var height = Convert.ToDouble(Console.ReadLine());

//             var weight = Convert.ToDouble(Console.ReadLine());

//             Result(inputs, commandMessage, height, weight);

//             // BmiFormula(height, weight, bmi);
//         }


//         static void Result(string[] inputs, string commandMessage, double height, double weight)
//         {
//             InvalidCommand(inputs, commandMessage, height, weight);
//             HelpsCommand(inputs);
//             VersionCommand(inputs);
//             BmiCommand(inputs, Convert.ToDouble(commandMessage), weight, Convert.ToString(height));
//             InputBmi();
//             BmiFormula(height, weight);

//         }

//         static void InvalidCommand(string[] inputs, string commandMessage, double height, double weight)
//         {
//             if ((inputs[1] != "--helps" || inputs[1] != "--version" || inputs[1] != "--height" || inputs[1] != "--weight" || inputs[2] != "--height" || inputs[2] != "--weight") && inputs[0] == "bmi")
//             {
//                 Console.WriteLine(commandMessage);
//             }
//             if (inputs.Length < 1)
//             {
//                 Console.WriteLine(commandMessage);
//             }
//         }

//         static void HelpsCommand(string[] inputs)
//         {
//             if (inputs[1] == "--helps" && inputs[0] == "bmi")
//             {
//                 Console.WriteLine("\n --height \t Your height (centimeters) ");
//                 Console.WriteLine("\n --weight \t Your weight (kilograms) ");
//                 Console.WriteLine("\n --version \t Show current version ");
//                 Console.WriteLine("\n --helps \t Show command list ");
//             }
//         }

//         static void VersionCommand(string[] inputs)
//         {
//             if (inputs[1] == "--version" && inputs[0] == "bmi")
//             {
//                 Console.WriteLine("Current version is : 1.0");
//             }
//         }

//         static void BmiCommand(string[] inputs, double height, double weight, string commandMessage)
//         {
//             if (inputs[0] == "bmi" && inputs[1] == "--height" && inputs[2] == Convert.ToString(height) && inputs[3] == "--weight" && inputs[4] == Convert.ToString(weight))
//             {
//                 BmiFormula(height, weight);
//             }
//             if (inputs[0] == "bmi" && inputs[1] == "--weight" && inputs[2] == Convert.ToString(weight) && inputs[3] == "--height" && inputs[4] == Convert.ToString(height))
//             {
//                 BmiFormula(height, weight);
//             }
//             else
//             {
//                 InvalidCommand(inputs, commandMessage, height, weight);
//             }
//         }


//         static void InputBmi()
//         {

//             Console.WriteLine("Enter your height in cm :");
//             var height = Convert.ToDouble(Console.ReadLine());


//             Console.WriteLine("Enter your weight in kg:");
//             var weight = Convert.ToDouble(Console.ReadLine());
//         }


//         static void BmiFormula(double height, double weight)
//         {

//             var bmi = Math.Round(weight / Math.Pow(height / 100, 2), 2);

//             if (bmi <= 18.4)
//             {
//                 Console.WriteLine($"BMI = {bmi} You are Underweight");
//             }

//             else if (bmi >= 18.52 && bmi <= 24.9)
//             {
//                 Console.WriteLine($"BMI = {bmi} You are Normal");
//             }

//             else if (bmi >= 25.0 && bmi <= 39.9)
//             {
//                 Console.WriteLine($"BMI = {bmi} You are Overweight");
//             }

//             else
//             {
//                 Console.WriteLine($"BMI = {bmi} You are Obese");
//             }
//         }

//     }
// }

