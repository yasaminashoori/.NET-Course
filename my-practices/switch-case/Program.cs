using System;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your favourite language : ");
            var lang = Console.ReadLine();

            if (lang == "germany")
            {
                Console.WriteLine("your favourite lang added to your pannel : Germany");
            }
            else if (lang == "Turkey")
            {
                Console.WriteLine("your favourite lang added to your pannel : Turkey");
            }

            else if (lang == "Japanese")
            {
                Console.WriteLine("your favourite lang added to your pannel : Japanese");
            }

            else
            {
                Console.WriteLine("your lang doesn't supported");
            }

            // switch case if we have multiple switch case 

            switch (lang)
            {
                case "c#":
                case "python":
                    Console.WriteLine("c# is 7v");
                    break;
                case "php":
                    Console.WriteLine("php is 4v");
                    break;
                default:
                    Console.WriteLine("this is not supported");
                    break;
            }

            // ternary condition

            string result;
            if (lang == "c#")
            {
                result = "this is your favourite lang";
            }
            else
            {
                result = "this is not supported";
            }

            Console.WriteLine(result);

// ...............................................

            var finalResult = lang  ==  "php" ? "php is your lang" : "this is not supported";
            Console.WriteLine(finalResult);


        }
    }
}
