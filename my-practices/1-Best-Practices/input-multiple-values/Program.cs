using System;

class Program
{
    static void Main()
    {
        int[] inputValues;
        string prompt = $"Please enter multiple integers (1, 2, 3): ";
        Console.Write(prompt);
        while (!TryParseIntegerList(Console.ReadLine(), out inputValues))
        {
            Console.WriteLine("Invalid Input. Try Again...");
            Console.Write(prompt);
        }
        Console.WriteLine($"You input the values: {string.Join(", ", inputValues)}");

        Console.WriteLine("Press [enter] to continue...");
        Console.ReadLine();
    }

    public static bool TryParseIntegerList(string input, out int[] inputValues)
    {
        inputValues = default;
        string[] splits = input.Split(",");
        int[] result = new int[splits.Length];
        for (int i = 0; i < splits.Length; i++)
        {
            if (!int.TryParse(splits[i].Trim(), out result[i]))
            {
                return false;
            }
        }
        inputValues = result;
        return true;
    }
}