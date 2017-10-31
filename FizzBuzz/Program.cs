using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            //100 loop
            for (int i = 1; i <= 100; i++)
            {
                //FizzBuzz
                if (i % 3 == 0 && i%5 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Fizz Buzz");
                    Console.Beep(13000, 100);
                }

                //Fizz
                else if (i % 3 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Fizz");
                    Console.Beep(5000, 100);
                }
                    
                //Buzz
                else if (i % 5 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Buzz");
                    Console.Beep(8000, 100);
                }

                //Print (i) if not divisible by 3, 5, or 3 and 5
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(i);
                }
            }
            //wait
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press Any Button to Exit");
            Console.ReadKey();
        }
    }
}
