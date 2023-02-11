using System;
using System.Collections.Generic;

namespace _53_ObjectsInLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var plantsLists = new List<Plants>();
            plantsLists.Add(new Plants("Rose", "flower"));
            plantsLists.Add(new Plants("sunflower", "flower"));
            plantsLists.Add(new Plants("tulip", "flower"));
            plantsLists.Add(new Plants("poppyflower", "flower"));

            foreach (var plant in plantsLists)
            {
                Console.WriteLine(plant);
            }
        }

        class Plants
        {
            public string Name { get; set; }
            public string Kind { get; set; }

            public Plants(string name, string kind)
            {
                Name = name;
                Kind = kind;
            }

            public override string ToString()
            {
                return $"The name of plant is : {Name}  and kind : {Kind}";
            }
        }
    }

}
