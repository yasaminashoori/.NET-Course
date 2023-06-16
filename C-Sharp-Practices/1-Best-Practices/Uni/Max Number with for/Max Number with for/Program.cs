using System;
class Program
{
    static void Main()
    {

        int max = -1, number;
        for (number = int.Parse(System.Console.ReadLine()); number >= 0; number = int.Parse(System.Console.ReadLine()))
            if (number > max)
                max = number;
        if (max >= 0)
            System.Console.WriteLine(max);
        else
            System.Console.WriteLine("Meow");

    }
}
