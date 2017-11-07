using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic8Ball
{
    class Program
    {
        static void Main(string[] args)
        {
            playGame();
        }

        private static void playGame()
        {
            string[] answer = { "Yes", "No", "Maybe", "I don't Know", "Possibly", "It is uncertain", "Not sure but it'd make a good meme" };
            Console.WriteLine("Ask me a Question or select type 'Exit' to quit");
            string choice = Console.ReadLine();
            Random rnd = new Random();
            Console.WriteLine(answer[rnd.Next(0, 7)]);
            if (choice != "exit")
            {
                playGame();
            }
            Console.ReadKey();

        }
    }
}
