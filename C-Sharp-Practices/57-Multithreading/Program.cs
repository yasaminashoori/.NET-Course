using System;
using System.Threading;

namespace _57_Multithreading
{
    class Program
    {
        static void Main(string[] args)
        {
            var mainThread = Thread.CurrentThread;
            mainThread.Name = "Main Thread";
            var thread1 = new Thread(CountUp);
            var thread2 = new Thread(CountDown);

            thread1.Start();
            thread2.Start();
            // CountUp();   
            // CountDown();   
            Console.WriteLine(mainThread.Name + " Is complete");
        }

        static public void CountUp()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(" Timer #1: " + i);
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer #1 complete!");
        }

        static public void CountDown()
        {
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(" Timer #2: " + i);
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer #2 complete!");
        }
    }
}
