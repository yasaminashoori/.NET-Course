using System;

namespace rock_paper_scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = "";
            string user = "";
            string computer = "";
            while (answer != "NO")
            {
                string[] states = new string[3] { "ROCK", "PAPER", "SCISSOR" };
                Random rnd = new Random();
                int n = rnd.Next(0, 3);
                user = UserChoice(states, user);
                Console.WriteLine($"Computer Round : {ComputerChoice(rnd, computer)}");
                GameRules(user, states, n, answer);
                PlayAgain(answer);
                // string user = Console.ReadLine().ToUpper();
                // Console.WriteLine($"Computer: {states[n]}");
                // ,........................................
                Console.WriteLine("Start the game !");
            }

            Console.WriteLine("Thanks ! I hope you enjoyed ^--^ ");
        }

        static string ComputerChoice(Random rnd, string computer)
        {
            switch (rnd.Next(0, 3))
            {
                case 0:
                    computer = "ROCK";
                    return computer;
                case 1:
                    computer = "PAPER";
                    return computer;
                case 2:
                    computer = "SCISSOR";
                    return computer;
                default:
                    return computer = "NOT VALID";
                    // break;
            }
        }
        static string UserChoice(string[] states, string user)
        {
            // string user = "";
            while (user != states[0] && user != states[1] && user != states[2])
            {
                Console.WriteLine("In this game you should Select one of these states : ROCK - PAPER - SCISSOR \n select one of them:");
                user = Console.ReadLine().ToUpper();
            }
            return user;
        }
        static void GameRules(string user, string[] states, int n, string answer)
        {
            switch (user)
            {
                case "ROCK" when states[n] == "SCISSOR":
                    Console.WriteLine("User wins");
                    break;
                case "ROCK" when states[n] == "PAPER":
                    Console.WriteLine("Computer wins");
                    break;
                case "PAPER" when states[n] == "ROCK":
                    Console.WriteLine("User wins");
                    break;
                case "PAPER" when states[n] == "SCISSOR":
                    Console.WriteLine("Computer Wins");
                    break;
                case "SCISSOR" when states[n] == "ROCK":
                    Console.WriteLine("Computer Wins");
                    break;
                case "SCISSOR" when states[n] == "PAPER":
                    Console.WriteLine("User wins");
                    break;
                default:
                    Console.WriteLine("It's a draw !");
                    break;
            }
        }
        static string PlayAgain(string answer)
        {
            Console.WriteLine("Do u want to continue(YES/NO):");
            return answer = Console.ReadLine().ToUpper();
        }
    }
}
