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
                    Console.WriteLine("Fizz Buzz");
                }

                //Fizz
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                    
                //Buzz
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                
                }

                //Print (i) if not divisible by 3, 5, or 3 and 5
                else
                {
                    Console.WriteLine(i);
                }
            }
            //wait
            Console.WriteLine("Press Any Button to Exit");
            Console.ReadKey();
        }
    }
}
