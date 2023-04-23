using System;
using System.Linq;

namespace _62_Lambda_expression
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentIds = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var result = studentIds.Where(x => x > 8);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Func<int, int, int> anonMethod = (x, y) => x * x;
            Console.WriteLine(anonMethod(5, 8));

            Action<string> tempMethod = name =>
            {
                var myName = "Hello " +  name;
                Console.WriteLine(myName);
            };
            tempMethod("yas");
        }
    }
}
