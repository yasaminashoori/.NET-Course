using System;

namespace roman_number
{
    class Program
    {
        static void Main(string[] args)
        {
            var I = 1;
            var V = 5;
            var X = 10;
            var L = 50;
            var C = 100;
            var D = 500;
            var M = 1000;


            string[] romanInput = { Console.ReadLine() };


            if (romanInput[I] == "1")
            {
                string res1 = romanInput[I] = "1";
            }

            if (romanInput[V] == "5")
            {
                string res2 = romanInput[V] = "5";
            }

            if (romanInput[X] == "10")
            {
                // string res3;
                string res3 = romanInput[X] = "10";
            }

            if (romanInput[L] == "50")
            {
                // string res4;
                string res4 = romanInput[L] = "50";
            }

            if (romanInput[C] == "100")
            {
                // string res5;
                string res5 = romanInput[C] = "100";
            }

            if (romanInput[D] == "500")
            {
                // string res5;
                string res5 = romanInput[D] = "500";
            }

            if (romanInput[M] == "1000")
            {
                // string res7;
                string res7 = romanInput[M] = "1000";
            }

            for (int romanCounter = 0; romanCounter < romanInput.Length; romanCounter++)
            {
                //  int s1 = (romanInput[romanCounter]);
            }

            // string[] romanInput = { Console.ReadLine() };
            // var result1 = romanInput.rep
        }
    }
}
