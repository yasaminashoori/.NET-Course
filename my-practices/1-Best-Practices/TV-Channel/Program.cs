using System;

namespace TV_Channel
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstChannel = 1;
            var status = false;
            do
            {
                Console.WriteLine($"We are in channel {firstChannel} do you like it ? ");
                var userChannel = Console.ReadLine();
                status = userChannel == "yes" ? true : false;
                if (status)
                {
                    Console.WriteLine($"Channel {firstChannel} added to your favourites list.  ^-^ ");
                }
                else
                {
                    Console.WriteLine($" channel :  {++firstChannel}");
                }
            } while (status == false);
        }
    }
}
