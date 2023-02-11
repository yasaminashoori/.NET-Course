using System;

namespace _46_parameters_array_objects
{
    class Program
    {
        static void Main(string[] args)
        {
           var myAnimal = new Animal("Snake");
           ConfirmName(myAnimal, 0);
           Console.WriteLine($"Legs for {myAnimal.Name} is just {myAnimal.Legs}");
        }

        public static void ConfirmName(Animal animal1, int legAnimal)
        {
            animal1.Legs = legAnimal;
        }
    }

    public class Animal
    {
        public string Name { get; set; }
        public int Legs { get; set; }

        public Animal(string nameAnimal)
        {
            Name = nameAnimal;
        }
    }
}
