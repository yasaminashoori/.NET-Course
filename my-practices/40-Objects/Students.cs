using System;

namespace _40_Objects
{
    // ***********Now we try the non static type that we want to initialize it and make object**************
    public class Students
    {

        public Students()
        {
            Count++;
        }

        public static void SignUp()
        {
            Console.WriteLine("students should sign up in the school site ");
        }

        public static int Count;
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

