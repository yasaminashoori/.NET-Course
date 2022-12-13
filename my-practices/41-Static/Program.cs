using System;

namespace _41_Static
{
    class Program
    {
        static void Main(string[] args)
        {
            var myStudents1 = new Students(32, 10, "zahra", "askari");
            myStudents1.GetPersonalInfo();
            myStudents1.SemesterInfo();

            var myStudents2 = new Students();
            myStudents2.GetPersonalInfo();


            var myStudents3 = new Students();
            var myStudents4 = new Students();
            var myStudents5 = new Students();


            Console.WriteLine(Students.Count);
        }
    }
}
