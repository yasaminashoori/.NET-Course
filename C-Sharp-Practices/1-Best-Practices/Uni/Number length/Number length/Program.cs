using System;

class Program
{
    static void Main()
    {
        int number, j = 0;
        number = int.Parse(Console.ReadLine());
        for (int i = number; i != 0; i /= 10) ++j;
        Console.WriteLine(j);
    }
}