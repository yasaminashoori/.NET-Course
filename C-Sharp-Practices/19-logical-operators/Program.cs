using System;

namespace logical_operators
{
    class Program
    {
        static void Main(string[] args)
        {
            string bookName;
            Console.WriteLine("Enter your favourite book");
            var availabe = Console.ReadLine();
            if (availabe == "1984" || availabe == "Sherlock" || availabe == "Harry Potter")
            {
                bookName = "we don't have your book : ";
            }
            else
            {
                bookName = "your book is available.";
            }
            Console.WriteLine(bookName);


            Console.WriteLine("Do you Want to pay ? ");
            var payment = Console.ReadLine();

            var status = payment == "yes" ? true : false;

            if (!status)
            {
                Console.WriteLine("Operation failed.");
            }
            else
            {
                Console.WriteLine("Operation was successful.");
            }
        }
    }
}
