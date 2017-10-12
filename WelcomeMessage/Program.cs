using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter name here: ");
            string name = Console.ReadLine();
            Console.WriteLine("Welcome Message for " + name);
            Console.WriteLine("Click 'Yes' to open Message");
            string Yes = Console.ReadLine();
            Console.WriteLine("Thots are near. Be wary, " + name);

            //wait at end
            Console.ReadKey();
        }
    }
}
