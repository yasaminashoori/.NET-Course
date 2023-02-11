using System;

namespace _44_abstract_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var bus1 = new Bus();
        }
        abstract class Vehicle
        {
            string name;
            public void Move()
            {
                Console.WriteLine($" {name} is moving right now ! ");
            }
        }
        sealed class Bus : Vehicle
        {
            string color;
        }
    }
}
