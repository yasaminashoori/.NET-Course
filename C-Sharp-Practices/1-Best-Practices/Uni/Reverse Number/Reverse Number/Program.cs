using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter a number:");
        int number = int.Parse(Console.ReadLine());

        int reversedNumber = 0;

        while (number != 0)
        {
            int digit = number % 10;
            reversedNumber = (reversedNumber * 10) + digit;
            number /= 10;
        }

        Console.WriteLine($"Reversed number: {reversedNumber}");

        Console.ReadLine();
    }
}