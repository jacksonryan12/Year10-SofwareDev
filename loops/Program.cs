using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press Enter to see loop");
           int number = int.Parse(Console.ReadLine());
           
            for (int x = 1; x <= number; x++)
            { 
                Console.WriteLine(x);
            }

            Console.ReadLine();


            }
        }
    }
}
