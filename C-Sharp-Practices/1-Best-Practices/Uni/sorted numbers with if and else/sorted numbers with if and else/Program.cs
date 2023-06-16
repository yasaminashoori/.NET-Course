using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter three numbers:");

        Console.Write("Number 1: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Number 2: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.Write("Number 3: ");
        int num3 = int.Parse(Console.ReadLine());

        if (num1 >= num2 && num1 >= num3)
        {
            if (num2 >= num3)
            {
                Console.WriteLine(num1 + " > " + num2 + " > " + num3);
            }
            else
            {
                Console.WriteLine(num1 + " > " + num3 + " > " + num2);
            }
        }
        else if (num2 >= num1 && num2 >= num3)
        {
            if (num1 >= num3)
            {
                Console.WriteLine(num2 + " > " + num1 + " > " + num3);
            }
            else
            {
                Console.WriteLine(num2 + " > " + num3 + " > " + num1);
            }
        }
        else
        {
            if (num1 >= num2)
            {
                Console.WriteLine(num3 + " > " + num1 + " > " + num2);
            }
            else
            {
                Console.WriteLine(num3 + " > " + num2 + " > " + num1);
            }
        }
    }
}