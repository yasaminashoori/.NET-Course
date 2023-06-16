using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter a number:");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("Digits of the number:");

        while (number > 0)
        {
            int digit = number % 10;
            Console.WriteLine(digit);
            number /= 10;
        }

        Console.ReadLine();
    }
}