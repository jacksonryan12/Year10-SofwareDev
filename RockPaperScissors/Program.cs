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

            while(repeat == true)
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
            Console.WriteLine("do you want to keep playing? Y/N?");
                string choice = Console.ReadLine().ToLower();
            if (choice == "y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static void updateScores(string result, ref int userScore, ref int computerScore)
        {
            if (result == "Win")
            {
                userScore++;
            }
            else 
            {
                computerScore++;
            }
        }

        private static void GiveFeedback(string result, string userChoice, string computerChoice)
        {
            Console.WriteLine($"{result} You chose {userChoice} and the Computer Chose {computerChoice}!");
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

                else 
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

                else
                {
                    return "Win";
                }
            }

            else
            {
                if (computerChoice == "Scissors")
                {
                    return "Draw";
                }

                else if (computerChoice == "Rock")
                {
                    return "Lose";
                }

               else
                {
                    return "Win";
                }
            }

            
            
        }

        private static string ComputerTurn()
        {
            Random rnd = new Random();
            int choice = rnd.Next(1, 4);
            if (choice == 1)
            {
                return "Rock";
            }
            else if (choice == 2)
            {
                return "Scissors";
            }
            else 
            {
                return "Paper";
            }
           
        }

        private static string userTurn()
        {
            Console.WriteLine("1. Rock");
            Console.WriteLine("2. Scissors");
            Console.WriteLine("1. Paper");
            Random rnd = new Random();
            int choice = rnd.Next(1, 4);
            if (choice == 1)
            {
                return "Rock";
            }
            else if (choice == 2)
            {
                return "Scissors";
            }
            else
            {
                return "Paper";
            }
           
        }

        private static void printScore(ref int userScore, ref int computerScore)
        {
            Console.WriteLine($"User Score: {userScore} /t/t Computer Score: {computerScore}");
        }
    }
}
