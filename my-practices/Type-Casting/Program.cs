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
            // in the above exercise we can't convert 32.3 in string format to double
            
            string stringAge = "23";
            int age = Convert.ToInt32(stringAge);
            Console.WriteLine(age.GetType());
            // Get Type is a built-in method

            double number = 13.3;
            bool status = Convert.ToBoolean(number);
            Console.WriteLine(status);
            // // we can convert string to boolean

            // implicit type casting
            int first = 12;
            double second = 12.564;
            second = first;
            Console.WriteLine(second);

            // explicit type casting using convert method
            double h = Convert.ToDouble("200");
            Console.WriteLine(h);

            // explicit type casting without using convert.to method
            int x = 12;
            double y = 14.656;
            y = (int) x;

            double notBool = 2.234;
            bool boolValue = Convert.ToBoolean(notBool);
            Console.WriteLine(boolValue);

        }
    }
}
