using System;

namespace _43_access_modifires
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee1 = new Employee();
            employee1.Salary = 15000000;
            Console.WriteLine($"Monthly salar for this emplyee is {employee1.Salary} Million.");
        }

        class Employee
        {
            int _salary;
            public int Salary { get; set; }
        }
    }
}
