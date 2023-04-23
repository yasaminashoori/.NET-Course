// Make Objects with calling the constructor
using System;

namespace _40_Constructor
{


    public class Students
    {
        public string firstName; public string lastName; public int age; public int lessons;
        
        // Constructor class 
        public Students(int studentsAge, int studentsLessons, string studentsFirstName, string studentsLastName)
        {
            firstName = studentsFirstName;
            lastName = studentsLastName;
            age = studentsAge;
            lessons = studentsLessons;
        }
        public Students()
        {

        }

        public void SignUp()
        {
            Console.WriteLine("students should sign up in the school site at first! ");
        }
        public void GetPersonalInfo()
        {
            Console.WriteLine($"the student name is :  {firstName} ");
        }

        public void SemesterInfo()
        {
            Console.WriteLine($"the program for {firstName} student is : {lessons} lessons");
        }
    }
}
