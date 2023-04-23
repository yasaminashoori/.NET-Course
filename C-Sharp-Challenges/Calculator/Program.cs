using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcOperations myCalc = new CalcOperations();
            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("--------------");
                    Console.WriteLine("Calculator Program");
                    Console.WriteLine("--------------");
                    Console.WriteLine("Enter number : {0}1 - Addition{0}2 - Substraction{0}3 - Multiplication{0}4 - Division", Environment.NewLine);
                    var userInput = int.Parse(Console.ReadKey().KeyChar.ToString());
                    Console.WriteLine();
                    GetUserInput(myCalc);
                    var getOperation = new double[] { myCalc.Counting(), myCalc.Subtraction(), myCalc.Multiplication(), myCalc.Division() };
                    Console.WriteLine(getOperation[userInput - 1]);
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Please enter another number more than 0.");
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Please enter a number.");
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                Console.WriteLine("Do you want to continue ? (Y or N): ");
            } while (Console.ReadLine().ToUpper() == "Y");

            Console.WriteLine("Thanks for using ^-^");
        }
        static void GetUserInput(CalcOperations calcOperations)
        {
            Console.WriteLine("Enter the number one : ");
            calcOperations.firstNum = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number two :");
            calcOperations.secondNum = double.Parse(Console.ReadLine());
        }
    }

    class CalcOperations
    {
        public double firstNum { get; set; }
        public double secondNum { get; set; }
        public double result { get; set; }

        public double Counting()
        {
            result = firstNum + secondNum;
            return result;
        }
        public double Subtraction()
        {
            result = firstNum - secondNum;
            return result;
        }
        public double Multiplication()
        {
            result = firstNum * secondNum;
            return result;
        }
        public double Division()
        {
            result = firstNum / secondNum;
            Console.Write("Your Result is ");
            return result;
        }
    }
}
