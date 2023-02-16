using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace Breakfast_AsynchronousProgram
{
    class Program
    {
        static async Task Main(string[] args)
        {
            
            var timeLong = new Stopwatch();
            timeLong.Start();

            await PourCoffee();
            await FryEggs();
            await FryBacon();
           
            Task.WaitAll(ToastBread(),
                        JamOnBread());

            await PourJuice();

            timeLong.Stop();

            Console.WriteLine("Breakfast is ready");
            Console.WriteLine("Your delicious breakfast has ready in : " + timeLong.ElapsedMilliseconds + " MS ");
        }

        public static async Task PourCoffee()
        {
            Console.WriteLine("Pouring coffee .");
            await Task.Run(() =>
            {
                Thread.Sleep(3000);
                Console.WriteLine("Coffee is ready now .");
            });
        }
        public static async Task FryEggs()
        {
            Console.WriteLine("Warming up the pan...");
            Console.WriteLine("Frying the eggs ...");
            await Task.Run(() =>
           {
               Thread.Sleep(5000);
               Console.WriteLine("the Eggs are ready .");
           });
        }
        public static async Task FryBacon()
        {
            Console.WriteLine("Frying some bacons ...");
            await Task.Run(() =>
           {
               Thread.Sleep(4000);
               Console.WriteLine("Bacon is ready now .");
           });
        }
        public static async Task ToastBread()
        {
            Console.WriteLine("Toasting the breads ...");
            await Task.Run(() =>
           {
               Thread.Sleep(700);
               Console.WriteLine("Your breads toasted.");
           });
        }
        public static async Task JamOnBread()
        {
            Console.WriteLine("Put jam on the breads");
            await Task.Run(() =>
           {
               Thread.Sleep(700);
               Console.WriteLine("Your Toast-jam is ready .");
           });
        }
        public static async Task PourJuice()
        {
            Console.WriteLine("Pouring orange juice");
            await Task.Run(() =>
           {
               Thread.Sleep(4000);
               Console.WriteLine("Your juice is ready.");
           });
        }
    }
}
