using System;

namespace Days_of_week
{
    class Program
    {
        static void Main(string[] args)
        { 
            string dayName;
            Console.WriteLine("Please enter a number from 1 to  7 : ");
            int day = Convert.ToInt32(Console.ReadLine());

            switch (day)
            {
                case 1:
                    dayName = "Saturday";
                    Console.WriteLine("Today is Saturday");
                    break;
                case 2:
                    dayName = "Sunday";
                    Console.WriteLine("Today is Sunday");
                    break;
                case 3:
                    dayName = "Monday";
                    Console.WriteLine("Today is Munday");
                    break;
                case 4:
                    dayName = "Tuesday";
                    Console.WriteLine("Today is Tuesday");
                    break;
                case 5:
                    dayName = "Wednesday";
                    Console.WriteLine("Today is Wednesday");
                    break;
                case 6:
                    dayName = "Thursday";
                    Console.WriteLine("Today is Thursday");
                    break;
                case 7:
                    dayName = "Friday";
                    Console.WriteLine("Today is Friday");
                    break;
                default:
                    Console.WriteLine("This is invalid name !");
                    break;
            }
        }
    }
}
