using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHALLENGE_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the numbers you want to average. (4 numbers only)");

            Console.WriteLine("Please enter a number for A: ");
            float Num1 = float.Parse(Console.ReadLine());


            Console.WriteLine("Please enter a number for B: ");
            float Num2 = float.Parse(Console.ReadLine());


            Console.WriteLine("Please enter a number for C: ");
            float Num3 = float.Parse(Console.ReadLine());


            Console.WriteLine("Please enter a number for D: ");
            float Num4 = float.Parse(Console.ReadLine());

            Console.WriteLine("Average =  " + (Num1+Num2+ Num3+Num4)/4);
            Console.ReadLine();

            
        }
    }
}
