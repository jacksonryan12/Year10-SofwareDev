using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //setup stuff

            int count = 0;
            Random rnd = new Random();
            int rand = rnd.Next(1, 101);
            Console.WriteLine("Please enter your guess");
            int guess = -1;

            //while

            while (guess != rand)
            {
                count++;
                Console.Write("Guess:");
                guess = int.Parse(Console.ReadLine());

                // If, else and else if

                if (guess < rand)
                {
                    Console.WriteLine("Too Low!");
                }
                else if (guess > rand)
                {
                    Console.WriteLine("Too High!");
                }
                else
                {
                    Console.WriteLine($"You got it! It took you {count} tries!");
                    Console.ReadLine();
                }
            }
            
        }
    }
}
