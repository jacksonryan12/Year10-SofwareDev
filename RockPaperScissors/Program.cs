using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            int userScore = 0;
            int ComputerScore = 0;
            bool repeat = true;

            while(repeat = true)
            {
                string result = "Draw";
                printScore(ref userScore, ref ComputerScore);                       //Print Scores
                string userChoice = userTurn();                                     //User's Turn
                string ComputerChoice = ComputerTurn();                             //Computer's turn
                result = DetermineWinner(userChoice, ComputerChoice);               //Decide who wins
                GiveFeedback(result, userChoice, ComputerChoice);                   //Show Scores again
                updateScores(result, ref userScore, ref ComputerScore);             //Update said Scores
                repeat = PlayAgain();                                               //If you Choose 'yes' then you play again, if not, the program closes.
            }
        }

        private static bool PlayAgain()
        {
            Console.WriteLine("do you want to keep playing? Y/N?")
                string choice = Console.ReadLine(), ToLower();
        }

        private static void updateScores(string result, ref int userScore, ref int computerScore)
        {
            if (result = "Win")
            {
                userScore++;
            }
            else if (result = "Lose")
            {
                computerScore++;
            }
        }

        private static void GiveFeedback(string result, string userChoice, string computerChoice)
        {
            
        }

        private static string DetermineWinner(string userChoice, string computerChoice)
        {
            if (userChoice == "Rock")
            {
                if (computerChoice == "Rock")
                {
                    return "Draw";
                }

               else if (computerChoice == "Paper")
                {
                    return "Lose";
                }

                if (computerChoice == "Scissors")
                {
                    return "Win";
                }
            }

            else if (userChoice == "Paper")
            {
                if (computerChoice == "Paper")
                {
                    return "Draw";
                }

                else if (computerChoice == "Scissors")
                {
                    return "Lose";
                }

                if (computerChoice == "Rock")
                {
                    return "Win";
                }
            }

            else if (userChoice == "Scissors")
            {
                if (computerChoice == "Scissors")
                {
                    return "Draw";
                }

                else if (computerChoice == "Rock")
                {
                    return "Lose";
                }

                if (computerChoice == "Paper")
                {
                    return "Win";
                }
            }

            
            
        }

        private static string ComputerTurn()
        {
            
        }

        private static string userTurn()
        {
            
        }

        private static void printScore(ref int userScore, ref int computerScore)
        {
            Console.WriteLine($"User Score: {userScore} /t/t Computer Score: {computerScore}");
        }
    }
}
