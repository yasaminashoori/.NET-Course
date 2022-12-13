using System;

namespace _43_access_modifires
{
    class Program
    {
        static void Main(string[] args)
        {
            var Employee1 = new Employee();
            Employee1.Salary = 15000000;
            Console.WriteLine($"Monthly salar for this emplyee is {Employee1.Salary} Million.");
        }

        class Employee
        {
            int _salary;
            public int Salary { get; set; }
        }
    }
}
