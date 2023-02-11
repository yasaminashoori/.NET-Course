using System;

namespace _34_Method_overloading_overwriting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Area(10.5, 16.6));
            Console.WriteLine(Area(15, 23, 4));
            Console.WriteLine(InfoStudent("YAS"));
        }

        static double Area(double a, double b)
        {
            var result = (a * b);
            return result;
        }
        static int Area(int a, int b, int c)
        {
            var resultTwo = (a * b * c);
            return resultTwo;
        }

        static string InfoStudent(string name, int number = 093422423)
        {
            var results =  ("Name :" + name +  "and the number : "  + number);
            return results;
        }
    }
}
