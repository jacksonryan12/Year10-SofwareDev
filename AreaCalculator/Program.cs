using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = "";
            while (choice != "4") 
            {
                Console.Clear();
                Console.WriteLine("Choose an Option");
                Console.WriteLine("1. Area of a Rectangle");
                Console.WriteLine("2. Area of a Triangle");
                Console.WriteLine("3. Area of a Circle");
                Console.WriteLine("4. Exit");
                choice = Console.ReadLine();

                if(choice == "1")
                {
                    //rectangle
                    Console.WriteLine();
                    Console.Write("Width: ");
                    float width = float.Parse(Console.ReadLine());
                    Console.Write("Length: ");
                    float length = float.Parse(Console.ReadLine());
                    Console.WriteLine("Area: " + (width * length));


                }

                if (choice == "2")
                {
                    //Triangle
                    Console.WriteLine();
                    Console.Write("Base: ");
                    float width = float.Parse(Console.ReadLine());
                    Console.Write("Height: ");
                    float height = float.Parse(Console.ReadLine());
                    Console.WriteLine("Area: " + ( 0.5 * width * height));
                }

                if (choice == "3")
                {
                    //circle
                    Console.WriteLine();
                    Console.Write("Radius: ");
                    float radius = float.Parse(Console.ReadLine());
                    Console.WriteLine("Area " + Math.PI * radius * radius);
                }

                //wait
                Console.WriteLine();
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();



            }







        }
    }
}
