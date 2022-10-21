using System;

namespace my_console_app
{
    // ***********************************This is a static type class that we don't make any object and it its general
    // public static class Students
    // {
    //     static public string firstName = "Yasamin";
    //     static public string lastName = "Ashoori";
    //     static public int age = 21;
    //     static public int lessons = 12;
    //     static public void PersonalInformations()
    //     {
    //         Console.WriteLine($"the student name is : {firstName} ");
    //     }

    //     static public void ClassInformations()
    //     {
    //         Console.WriteLine("the program for this student is : ");
    //     }
    // }


    // ********************************Now we try the non static type that we want to initialize it ourself and make object
    public class Students
    {

        // Constructor class 
        public Students(int studentsAge, int studentsLessons, string studentsFirstName, string studentsLastName)
        {
            age = studentsAge;
            lessons = studentsLessons;
            firstName = studentsFirstName;
            lastName = studentsLastName;
        }
        // public Students()
        // {
        //     // an empty constructor
        // }

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