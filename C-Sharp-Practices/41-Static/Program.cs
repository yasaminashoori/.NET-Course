using System;

namespace _41_Static
{
    class Program
    {
        static void Main(string[] args)
        {
            var myStudents1 = new Students(32, 10, "Sara", "valaei");
            myStudents1.GetPersonalInfo();
            myStudents1.SemesterInfo();

            var myStudents2 = new Students();
            var myStudents3 = new Students();
            var myStudents4 = new Students();
            var myStudents5 = new Students();
            Console.Write("Numbers of our objects from students class is == > ");
            Console.Write(Students.Count);
        }
    }
}
