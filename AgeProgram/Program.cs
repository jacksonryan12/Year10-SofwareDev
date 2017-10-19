using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeProgram
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Please enter your age:");
            int age = int.Parse(Console.ReadLine());

            //Unborn
            if (age < 0)
            {
                Console.WriteLine("You are not even alive, how are you entering your age, you lying bastard?");
            }
            //Child
            if (age < 13)
            {
                Console.WriteLine("you are a child");
            }

            //Teenager
            else if (age < 20)
            {
                Console.WriteLine("You are a teenager");
            }

            //Adult
            else
            {
                Console.WriteLine("You are an adult");
            }
            //wait at end
            Console.ReadLine();
        }
    }
}
