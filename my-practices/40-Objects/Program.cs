using System;

namespace _40_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            var myStudents1 = new Students();
            myStudents1.firstName = "Zahra";
            myStudents1.lessons = 17;
            myStudents1.age = 25;
            myStudents1.GetPersonalInfo();
            myStudents1.SemesterInfo();
    
            var myStudents2 = new Students();
            myStudents2.firstName = "Fathemeh";
            myStudents2.lastName = "Babaei";
            myStudents2.SignUp();
        }
    }
}

