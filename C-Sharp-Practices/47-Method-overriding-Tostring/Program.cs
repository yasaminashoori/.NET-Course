using System;

namespace _47_Method_overriding_Tostring
{
    class Program
    {
        static void Main(string[] args)
        {
            var asia = new Continent();
            asia.Move();

            var europe = new Continent();
            europe.Area = 10.53;
            Console.WriteLine(europe.ToString());
        }

        public class Earth
        {
            public virtual void Move()
            {
                Console.WriteLine("The Earth orbits around the sun every 365.25 days.");
            }
        }
        public class Continent : Earth
        {
            public double Area { get; set; }
            public override void Move()
            {
                Console.WriteLine("The Continents move just a few millimetres every year.");
            }

            public override string ToString()
            {
                return "The area of Europe is " + Area + " KM";
            }
        }

        public class WaterLand : Earth
        {
            public override void Move()
            {
                Console.WriteLine("Yes it moves at large scales");
            }
        }

        public abstract class Stars
        {
            public abstract void Die();
        }

        public class Sirius : Stars
        {
            public override void Die()
            {
                Console.WriteLine("It turns into a white dwarf.");
            }
        }
    }
}
