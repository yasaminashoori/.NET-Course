namespace chap_moraba;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        var starNums = int.Parse(Console.ReadLine());
        for (int i = 1; i <= starNums; i++)
        {
            Console.Write("*");
            if (i == starNums)
            {
                for (int j = 1; j <= starNums - 2; i++)
                {
                    Console.WriteLine("*");
                }
            }
        }
    }
}
