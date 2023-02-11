using System;

namespace _40_Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            var myStudents1 = new Students(18, 24, "Yasamin", "Ashoori");
            myStudents1.GetPersonalInfo();
            myStudents1.SemesterInfo();

            Students myStudents2 = new Students();
            myStudents2.SemesterInfo();
        }
    }
}   
