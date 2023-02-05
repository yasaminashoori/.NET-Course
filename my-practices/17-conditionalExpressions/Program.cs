using System;

namespace conditionalExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            var age = 20;
            var firstName = "yasamin";
            var result = firstName == age.ToString();
            Console.WriteLine(result);

            Console.WriteLine("Enter your name :");
            var name = Console.ReadLine();

            Console.WriteLine("Enter your grades :");
            var grade1 = Convert.ToUInt32(Console.ReadLine());
            var grade2 = Convert.ToUInt32(Console.ReadLine());
            var grade3 = Convert.ToUInt32(Console.ReadLine());
            var gpa = (grade1 + grade2 + grade3) / 3;
            if (gpa >= 17)
            {
                Console.WriteLine($" {name} have access to take more than 24");
            }
            else if (gpa == 12)
            {
                Console.WriteLine($"{name} son't have access");
            }
        }
    }
}
