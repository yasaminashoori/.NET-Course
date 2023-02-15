using System;

namespace Palindrome_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var palindromeOne = new Solution();
            Console.WriteLine(palindromeOne.IsPalindrome());
        }

        public class Solution
        {
            public bool IsPalindrome(int x = 123)
            {
                Console.Write("x = ");
                x = int.Parse(Console.ReadLine());
                string reverse = String.Empty;

                while (x >= -2147483648 && x <= 2147483648 - 1)
                {
                    for (int i = x.ToString().Length - 1; i >= 0; i--)
                    {
                        reverse += x.ToString()[i];
                    }
                    if (reverse == x.ToString())
                    {
                        return true;
                    }
                    else if (reverse != x.ToString())
                    {
                        return false;
                    }
                }
                return Convert.ToBoolean("not in range !");
            }
        }

    }
}
