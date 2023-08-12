using System.Reflection.Metadata;
using System.Security.Cryptography;

namespace Em_Sin;
class Program
{
    static void Main(string[] args)
    {
        string haftSin = new string[] { "samanou", "sabzeh", "sir", "serkeh", "senjed", "sekeh", "sib" };
        Console.WriteLine("Enter a number between 1 to 7");
        var userNumber = Console.ReadLine().ToLower();

        if (userNumber >= 1)
        {
            for (int i = 0; i < haftSin.Length; i++)
            {
                foreach (var item in haftSin)
                {
                    haftSin[item] = userNumber;
                    Console.WriteLine(item);
                }
            }
        }
    }
}
