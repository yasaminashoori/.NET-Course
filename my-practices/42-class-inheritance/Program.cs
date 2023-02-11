using System;

namespace class_inheritance
{
    class Program
    {

        static void Main(string[] args)
        {
            var MotorCyclejas = new MotorCycle();
            MotorCyclejas.nameModel = "Hitachi";
            MotorCyclejas.Status();
        }

        public class Vehicle
        {
            public int Price = 5000;

            public void Go()
            {
                Console.WriteLine("It is starting ...");
            }
        }

        class MotorCycle : Vehicle
        {
            public string nameModel;
            public void Status()
            {
                Console.WriteLine($"It is ready to use. the name is {nameModel} and the price is :  {Price}");
            }
        }
    }

}
