using System;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            var myage = 24;
            Console.WriteLine("Enter your name :");
            var name = Console.ReadLine();
            Console.WriteLine(args[0]);
            GetUserInfo(age:myage, name);

        }

        static void GetUserInfo(int age, string name)
        {
            
            Console.WriteLine("enter your name:"+ name);
            Console.WriteLine("enter your age:"+ age);
            // var age = Console.ReadLine();
            // Console.WriteLine($"your name is {name} and you have {age} years old.");
        }
    }
}
