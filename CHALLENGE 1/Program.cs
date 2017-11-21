using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHALLENGE_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //input name
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();

            //inpute age
            Console.WriteLine("Please enter your age:");
            string age = Console.ReadLine();

            //use name and age
            Console.WriteLine($"Welcome {name}, you look good for {age}!");
            Console.ReadLine();
        }
    }
}
