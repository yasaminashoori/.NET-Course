using System;

namespace _45_arrays_objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] zoo = {new Animal("bee"), new Animal("butterfly")};

            foreach (var animal in zoo)
            {
                Console.WriteLine(animal.Insects);
            }
        }

        public class Animal 
        {
            public string Insects { get; set; }

            public Animal(string kindsInsects)
            {
                Insects = kindsInsects;
            }
        }
    }
}
