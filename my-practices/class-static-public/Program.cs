using System;

namespace my_console_app
{
    class Program
    {
        // DRY => Don't repeat yourself means make object and just call them
        static void Main(string[] args)
        {
            // Console.WriteLine(Students.firstName);
            // Students.ClassInformations();
            // Students.PersonalInformations();

            //***********************************************************
            // var myStudents1 = new Students();
            // myStudents1.age = 17;
            // myStudents1.firstName = "FATHEMEH";
            // myStudents1.PersonalInformations();
            // myStudents1.ClassInformations();

            // ***********************************************************
            var myStudents1 = new Students(32, 10, "zahra", "aseri");
            myStudents1.PersonalInformations();
            myStudents1.ClassInformations();

            // count : static concept
            var myStudents2 = new Students();
            var myStudents3 = new Students();
            var myStudents4 = new Students();
            var myStudents5 = new Students();
            // Console.WriteLine(myStudents2.Count);
            // Console.WriteLine(myStudents3.Count);
            // Console.WriteLine(myStudents4.Count);
            // Console.WriteLine(myStudents5.Count);

            // and the correct way after adding static type 

            Console.WriteLine(Students.Count);
            Students.SignUp();
        }
    }

    // static class Students
    // {
    //     static public string firstName = "Yasamin";
    //     static public string lastName = "Ashoori";
    //     static public int age = 21;
    //     static public int lessons = 12;
    //     static public void PersonalInformations()
    //     {
    //         Console.WriteLine($"the user name is : {firstName}: ");
    //     }

    //     static public void ClassInformations()
    //     {
    //         Console.WriteLine($"the program for this student is : {age} years old and {lessons} lessons ");
    //     }
    // }


}

