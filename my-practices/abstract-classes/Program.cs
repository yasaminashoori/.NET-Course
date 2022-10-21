using System;

namespace abstract_classes
{
    class Program
    {
        static void Main(string[] args)
        {
           var myCat = new Cat();
           myCat.Sleep();
        //    var myAnimal = new Animal();
        }

        abstract class Animal
        {
            public void Sleep()
            {
                Console.WriteLine("it its sleeping ....");
            }
        }

        sealed class Cat : Animal
        {

        }

        // class SmallCat : Cat
        // {

        // }

    }
}
