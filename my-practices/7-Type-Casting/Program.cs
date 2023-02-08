using System;

namespace Type_Casting
{
    class Program
    {
        static void Main(string[] args)
        {

            string adadString = "32";
            double mohit = Convert.ToDouble(adadString);
            Console.WriteLine(mohit.GetType());
            
            string stringAge = "23";
            int age = Convert.ToInt32(stringAge);
            Console.WriteLine(age.GetType());
            // built-in method GetType

            double number = 13.3;
            bool status = Convert.ToBoolean(number);
            Console.WriteLine(status);

            // implicit type casting
            int first = 12;
            double second = 12.564;
            second = first;
            Console.WriteLine(second);

            // explicit type casting
            double h = Convert.ToDouble("200");
            Console.WriteLine(h);
            int x = 12;
            double y = 14.656;
            y = (int) x;

            double notBool = 2.234;
            bool boolValue = Convert.ToBoolean(notBool);
            Console.WriteLine(boolValue);

        }
    }
}
