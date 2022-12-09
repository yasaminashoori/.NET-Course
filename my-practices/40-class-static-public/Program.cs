using System;

namespace my_console_app
{
    class Program
    {
        static void Main(string[] args)
        {

            // DRY => Don't repeat yourself means make object and just call them

            Console.WriteLine(Students.firstName);

            Students.ClassInformations();

            Students.PersonalInformations();

        }
    }
}

