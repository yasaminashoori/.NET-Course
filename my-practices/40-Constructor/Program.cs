using System;

namespace _40_Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            var myStudents1 = new Students(32, 10, "zahra", "askari");
            myStudents1.PersonalInformations();
            myStudents1.ClassInformations();

            var myStudents2 = new Students();
            myStudents2.ClassInformations();

        }
    }
}   
