namespace Soal_Zard;

class Program
{
    static void Main(string[] args)
    {
          Console.WriteLine("Enter a number:");
        var input1 = Convert.ToInt32(Console.ReadLLine());
        string result = "W" + "o" * input1 + "w!";
        Console.WriteLine(result);
    }
}
