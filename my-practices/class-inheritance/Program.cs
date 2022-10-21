using System;

namespace class_inheritance
{
    class Program
    {
}
        static void Main(string[] args)
        {
            var myCar = new Vehicle();
            myCar.level();
        }

        public class Vehicle()
        {
            public int generallines = 3;

        public void Stop()
        {
            Console.WriteLine("this vehicle is stopping ...");
        }
    }

    class Vehicle : Bicycle
    {
        public string color = "red";
    }
}
