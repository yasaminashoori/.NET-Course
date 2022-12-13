// Now we try the non static type that we want to initialize it and make object.

using System;

namespace _40_Objects
{
    public class Students
    {

        public string firstName; public string lastName; public int age; public int lessons;
        
        public void SignUp()
        {
            Console.WriteLine("students should sign up in the school site at first!");
        }


        public void GetPersonalInfo()
        {
            Console.WriteLine($"the student name is : {firstName}");
        }


        public void SemesterInfo()
        {
            Console.WriteLine($"the program for this student is : {age} years old and {lessons} lessons");
        }
    }
}

