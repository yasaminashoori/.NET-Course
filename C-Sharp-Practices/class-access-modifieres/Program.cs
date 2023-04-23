using System;

namespace class_access_modifieres
{
    class Program
    {
        static void Main(string[] args)
        {
            var mySchool = new School();
            mySchool.NumberStudents = 2000;
            mySchool.FirstName = "zahra";
            Console.WriteLine(mySchool.FirstName);
            Console.WriteLine(mySchool.NumberStudents);
        }

        class School
        {
            int numberStudents;
            string firstName;
            // public int numberStudents
            // {
            //     get {return numberStudents;}
            //     set {numberStudents = value;}
            // }

            public int NumberStudents { get; set; }
            public string FirstName { get; set; }

        }
    }
}
