using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rock_seccery_pepper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int computerScore = 0;
            int playerScore = 0;

            var random = new Random();
            int computerNumber = random.Next(1, 4);
            string computerMove = computerNumber.ToString();

            while (computerScore != 3 && playerScore != 3)
            {
                Console.WriteLine("Enter  rock , scissor or pepper ");
                string playerMove = Console.ReadLine();

                if (playerMove != "rock" && playerMove != "scissor" && playerMove != "pepper")
                {
                    Console.WriteLine("Wrong input ");
                }

                if (playerMove == "rock" && computerNumber == 2 || playerMove == "scissor" && computerNumber == 3 || playerMove == "pepper" && computerNumber == 1)
                {
                    Console.WriteLine("Player wins");
                    playerScore++;
                }
                else if (playerMove == computerMove)
                {
                    Console.WriteLine("This is draw , Try again");
                }
                else
                {
                    Console.WriteLine("Computer win");
                    computerScore++;
                }
                Console.WriteLine($"computer's score: {computerScore}");
                Console.WriteLine($"player's score: {playerScore}");
            }
            Console.WriteLine(playerScore == 3 ? "player wins!" : "Computer wins!");
        }
    }
}
