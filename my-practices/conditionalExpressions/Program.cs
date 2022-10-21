using System;

namespace conditionalExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            // comparison operators
            //  states the answer true or false 

            // var firstNumber = 25;
            // var secondNumber = 143; 
            // var result = secondNumber > firstNumber;
            // Console.WriteLine( secondNumber > firstNumber);
            //


            var firstNumber =  20;
            var secondNumber = "yasamin";
            var result = secondNumber == firstNumber.ToString();
            // every data type could cast to string 
            Console.WriteLine(result);



            // if satatement

            // boolean
            // var result2 = secondNumber == "ashoori";

            if (secondNumber != "ashoori")
            // if (true) => always this condition runs
            {
                Console.WriteLine("hiii");
            }
            else
            {
                Console.WriteLine("This is another");
            }


            





        }
    }
}
