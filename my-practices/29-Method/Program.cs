using System;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {      
            var myage = 21;
            var name = "Yas";
            GetUserInfo(myage, name);
        }

        static void GetUserInfo(int age, string name)
        {
            Console.WriteLine("enter your name : "+ name);
            Console.WriteLine("enter your age : "+ age);
        }
    }
}
