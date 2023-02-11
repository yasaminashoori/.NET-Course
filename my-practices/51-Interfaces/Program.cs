using System;

namespace _51_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var eagle = new Eagle();
            var rabbit = new Rabbit();

            rabbit.Run();
            eagle.Hunt();

            var fish = new Fish();
            fish.Hunt();
            fish.Run();
        }

        interface Iprey
        {
            public int foodChain  { get; set; }
            void Run();
        }

        interface Ipredator
        {
            void Hunt();
        }

        public class Eagle : Ipredator
        {
            public void Hunt()
            {
                Console.WriteLine("Eagle is hunting");
            }
        }

        public class Rabbit : Iprey
        {
            public int foodChain {get; set;}

            public void Run()
            {
                Console.WriteLine("Rabbit is running");
            }
        }

        public class Fish : Ipredator, Iprey
        {
            public int foodChain {get; set;}

            public void Hunt()
            {
                Console.WriteLine("Fish is hunting");
            }

            public void Run()
            {
                Console.WriteLine("Fish is running");
            }
        }
    }
}
