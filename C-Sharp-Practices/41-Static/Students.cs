// Make Objects with calling the constructor.

using System;

namespace _41_Static
{
    public class Students
    {
        public static int Count; public string firstName; public string lastName; public int age; public int lessons;
        public Students(int studentsAge, int studentsLessons, string studentsFirstName, string studentsLastName)
        {
            age = studentsAge;
            lessons = studentsLessons;
            firstName = studentsFirstName;
            lastName = studentsLastName;
        }

        public Students()
        {
            Count++;
        }

        public void SignUp()
        {
            Console.WriteLine($"student {firstName} {lastName} should sign up in the school site at first! ");
        }

        public void GetPersonalInfo()
        {
            Console.WriteLine($"the student name is :  {firstName} {lastName} and {age} years old.");
        }

        public void SemesterInfo()
        {
            Console.WriteLine($"the program for this student is : {lessons} lessons");
        }
    }
}
