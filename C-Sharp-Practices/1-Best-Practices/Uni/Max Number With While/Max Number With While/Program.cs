using System;

class Program
{
    static void Main()
    {
        int max, number;
        max = -1;
        number = int.Parse(System.Console.ReadLine());
        while (number > 0)
        {
            if (number > max)
                max = number;
            number = int.Parse(System.Console.ReadLine());

        }
        if (max > 0)
            Console.WriteLine(max);
        else
            System.Console.WriteLine("meow");



    }
}

