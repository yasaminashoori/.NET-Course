using System;

namespace _40_Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            var myStudents1 = new Students(32, 10, "zahra", "askari");
            myStudents1.GetPersonalInfo();
            myStudents1.SemesterInfo();

            var myStudents2 = new Students();
            myStudents2.SemesterInfo();

        }
    }
}   
