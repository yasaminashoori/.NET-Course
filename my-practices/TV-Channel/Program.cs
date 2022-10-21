using System;

namespace TV_Channel
{
    class Program
    {
        static void Main(string[] args)
        {
            bool favChannel = false;
            int numberChannel = 0;
            do
            {
                Console.WriteLine($"You are in channel {++numberChannel}.\nDo you like it ? (Yes or No) ");
                var userInputaAnswer = Console.ReadLine().ToUpper();
                if (userInputaAnswer == "YES" || userInputaAnswer == "Y")
                {
                    favChannel = true;
                    Console.WriteLine($"channel {numberChannel} is added to your favourite channel! \nEnjoy it  ^ --- ^ ");
                    Environment.Exit(0);
                }
                else
                {
                    favChannel = false;
                }
            } while (favChannel == false);
        }
    }
}
