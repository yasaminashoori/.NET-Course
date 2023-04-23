using System;

namespace _39_Multi_dimension_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bookNames = { "1984", "Sherlock-Holmes", "Harry-Potter", "The-Lord-of-the-Rings" };
            string[] bookwriters = { "George-Orwell", "Arthur-Conan-Doyle", "J.K.Rowling", "Tolkien" };
            string[] booknumbers = { "20", "12", "5", "34" };

            string[,] bookInfo = {{ "1984", "Sherlock Holmes", "Harry Potter", "The Lord of the Rings" },
                                   {"George Orwell", "Arthur Conan Doyle", "J. K. Rowling", "Tolkien"},
                                   {"20", "12", "5", "34"}};

            for (int i = 0; i < bookInfo.GetLength(0); i++)
            {
                for (int j = 0; j < bookInfo.GetLength(1); j++)
                {
                    Console.Write(bookInfo[i, j] + "\t");
                }
                Console.WriteLine();
            }

            //object array

            string[] musicCompanies = { "Sony", "Warner", "Red-Hill" };
            string[] musicBands = { "The-Beatles", "Pink-Floyd", "The-Rolling-Stones" };
            int[] startYear = { 1960, 1964, 1962 };

            object[,] musicINfo = {{"Sony", "Warner", "Red-Hill"},
                                   {"The-Beatles", "Pink-Floyd", "The-Rolling-Stones"},
                                   {1960, 1964, 1962}};

            for (int i = 0; i < musicINfo.GetLength(0); i++)
            {
                for (int j = 0; j < musicINfo.GetLength(1); j++)
                {
                    Console.Write(musicINfo[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
