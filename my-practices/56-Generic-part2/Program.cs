using System;
using System.Collections.Generic;

namespace _56_Generic_part2
{
    class Program
    {
        static void Main(string[] args)
        {
            var Subject = new string[] { "Math", "Algorithm", "DataBase", "Operating System" };
            var grades = new double[] { 20, 19.25, 18, 19.5 };
            var passOrFail = new bool[] { true, true, true };
            DisplayArray<string, string>(Subject, "Yasamin");
            DisplayArray<double, string>(grades, "Zahra");
            DisplayArray<bool, string>(passOrFail, "Sahar");
            var nameOne = new People<string>("Yas");
            Console.WriteLine(nameOne);
            nameOne.NamePeople("Sara");
            // var myEnum = new MyEnum<string, bool>
            // {
            //     Key = "1984",
            //     Value = true
            // };
            // myEnumList.Add(myEnum);
            var myEnumList = new List<MyEnum<string, bool>>();
            myEnumList.Add(new MyEnum<string, bool>()
            {
                Key = "Harry Potter",
                Value = false
            });

            myEnumList.Add(new MyEnum<string, bool>
            {
                Key = "Humans",
                Value = true
            });

        }

        public class MyEnum<TKey, TValue>
        {
            public TKey Key { get; set; }
            public TValue Value { get; set; }
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

        public void NamePeople(T TFirstName)
        {
            Console.WriteLine($"names are :  {TFirstName}");
        }
        public People(T name)
        {
            Name = name;
        }
    }
}
