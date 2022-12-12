using System;

namespace class_inheritance
{
    class Program
    {

        static void Main(string[] args)
        {
            var MotorCyclejas = new MotorCycle();
            MotorCyclejas.Price = 70;
            MotorCyclejas.Name = "Hitachi";
            MotorCyclejas.Status();
        }

        public class Vehicle
        {
            public int Price;

            public void Go()
            {
                Console.WriteLine("It is starting ...");
            }
        }

        public class MotorCycle : Vehicle
        {
            public string Name;

            public void Status()
            {
                Console.WriteLine($"It is ready to use : the name is {Name} and the price is :  {Price}");
            }
        }
    }

}
