using System;

namespace first_reverse
{
    class Primary
    {
        public static string FirstReverse(string str)
        {

            string reverse = String.Empty;

            for (int i = str.Length - 1; i >= 0; i--)
            {
                reverse += str[i];
            }
            return reverse;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter your favourite text : ");
            Console.WriteLine(FirstReverse(Console.ReadLine()));
        }
    }
}

