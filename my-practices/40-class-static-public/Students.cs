using System;

namespace my_console_app
{
    // *********This is the static type class that we don't make any object and it it's general*********

    public static class Students
    {
        static public string firstName = "Yasamin";
        static public string lastName = "Ashoori";
        static public int age = 21;
        static public int lessons = 18;
        static public void PersonalInformations()
        {
            Console.WriteLine($"the student's name is : {firstName} {lastName}");

            Console.WriteLine($"the student's age is : {age}");
        }

        static public void ClassInformations()
        {
            Console.WriteLine($"the program for this student is : {lessons} in this semester");
        }
    }
}