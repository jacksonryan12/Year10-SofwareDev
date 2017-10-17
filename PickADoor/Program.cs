using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickADoor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a Door");
            string choice = Console.ReadLine();
            

            if (choice == "1")
            {
                Console.WriteLine("Behind Door 1 is ");
            }

           else if (choice == "2")
            {
                Console.WriteLine("Behind Door 2 is ");
            }

          else if (choice == "3")
            {
                Console.WriteLine("Behind Door 3 is ");
            }
            // wait at end
            Console.ReadKey();
        }
    }
}
