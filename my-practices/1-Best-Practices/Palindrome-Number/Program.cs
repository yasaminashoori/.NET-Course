using System;

namespace Palindrome_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            PalindromeChecker();
        }

        public static void PalindromeChecker()
        {
            Console.WriteLine("Enter an inteeger number : ");
            var str = Console.ReadLine();
            string reverse = String.Empty;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reverse += str[i];
            }
            if (reverse == str)
            {
                Console.WriteLine($"{reverse} True, IT is a palindrome number.");
            }
            else
            {
                Console.WriteLine($"{reverse} Flase : not a palindrome number");
            }
        }
    }
}
