using System;

namespace _55_Generic
{
    class Program
    {
        static void Main(string[] args)
        {
          var Subject = new string[] {"Math", "Algorithm", "DataBase", "Operating System"};  
          var grades = new double[] {20, 19.25, 18, 19.5};
          var passOrFail = new bool[] {true, true, true};
          DisplayArray<string, string>(Subject, "Yasamin");
          DisplayArray<double, string>(grades, "Zahra");
          DisplayArray<bool, string>(passOrFail, "Sahar");
          var nameOne = new People<string>("Yas");
          Console.WriteLine(nameOne);
        }
        public static void DisplayArray<T, TName>(T[] myArray, TName name)
        {
            foreach (var item in myArray)
            {
                Console.WriteLine($" MY subject information : {item}");
            }
        }
    }
    class People<T>
    {
        public T Name { get; set; }
        public People(T name)
        {
            Name = name;
        }
    }
}
