// Now we try the non static type that we want to initialize it and make object.

using System;

namespace _40_Objects
{
    public class Students
    {

        public void SignUp()
        {
            Console.WriteLine("students should sign up in the school site ");
        }

        public string firstName;
        public string lastName;
        public int age;
        public int lessons;

        public void PersonalInformations()
        {
            Console.WriteLine($"the student name is :  {firstName}: ");
        }


        public void ClassInformations()
        {
            Console.WriteLine($"the program for this student is : {age} years old and {lessons} lessons");
        }
    }
}

