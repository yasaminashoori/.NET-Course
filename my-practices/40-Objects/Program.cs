using System;

namespace _40_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            var myStudents1 = new Students();
            myStudents1.age = 17;
            myStudents1.PersonalInformations();
            myStudents1.ClassInformations();

            
            var myStudents2 = new Students();
            myStudents2.lessons = 17;
            myStudents1.firstName = "FATHEMEH";
            myStudents2.ClassInformations();
        }
    }
}

