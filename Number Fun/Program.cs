using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Fun
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please enter a number for X: ");
            float Num1 = float.Parse(Console.ReadLine());
            

            Console.WriteLine("Please enter a number for Y: ");
            float Num2 = float.Parse(Console.ReadLine());

            //Addition
            Console.WriteLine("X plus Y = " + (Num1+Num2));

            //Multiplication
            Console.WriteLine("X times Y = " + (Num1)*(Num2));

            //Subtraction
            Console.WriteLine("X minus Y = " + (Num1-Num2));

            //Division
            Console.WriteLine("X divided by Y = " + (Num1)/(Num2));
            Console.ReadKey();
        }
    }
}
