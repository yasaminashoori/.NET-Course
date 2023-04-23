using System;

namespace stringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            var myString1 = "yAsAmIn";
            var myString2 = "092-2324-123";
            var myString3 = "Yasamin Ashoori";
            
            var result1 = myString1.ToUpper();
            var result2 = myString1.ToLower();
            var result3 = myString2.Replace("-", "@");
            var result4 = myString3.Insert(0, "@");
            var result5= myString3.Substring(0, 6);
            var result6 = myString3.Substring(3, 10);
            var result7= myString3.Substring(4);
            var result8 = myString3.Length;
            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.WriteLine(result4);
            Console.WriteLine(result5);
            Console.WriteLine(result6);
            Console.WriteLine(result7);
            Console.WriteLine(result8);
            
        }
    }
}
