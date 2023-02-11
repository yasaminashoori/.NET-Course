// This is the static type class that we don't make any object and it it's general.

using System;

namespace my_console_app
{

    public static class Students
    {
        static public string firstName = "Yasamin"; static public string lastName = "Ashoori"; static public int age = 21; static public int course = 18;
        static public void GetPersonalInfo()
        {
            Console.WriteLine($"the student's name is : {firstName} {lastName}");
            Console.WriteLine($"the student's age is : {age}");
        }

        static public void SemesterInfo()
        {
            Console.WriteLine($"the program for this student is : {course} lessons in this semester");
        }
    }
}