using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsultGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            //ask for name
            string name = GetName();
            //Generate Insult
            GenerateInsult(name, rnd);
        }

        //GetName
        private static string GetName()
        {
            Console.WriteLine(" Welcome to the insult Generator! What is your name?");
            return Console.ReadLine();
        }


        private static void GenerateInsult(string name, Random rnd)
        {
            Console.WriteLine(name = ", you are " + GetAdjective(rnd) + GetCompoundAdjective(rnd) + GetObject(rnd));
            Menu(name, rnd);
        }


        private static void Menu(string name, Random rnd)
        {

        }

        //Get Adjective
        private static string GetAdjective(Random rnd)
        {
            string[] Adjectives = { "a hairy", "an obnoxious ", "a smelly", "a crusty", "an arrogant", "a funky", "a lame", "a stinky" };
            return Adjectives[rnd.Next(8)];
        }

        //Get Compound
        private static string GetCompoundAdjective(Random rnd)
        {
            string[] CompoundAdjective = { "no-good", "self-loathing ", "strokey-nonce of a ", "big-headed", "foul-mouthed", "cold-hearted", "pimply-faced", "depression-inducing" };
            return CompoundAdjective[rnd.Next(8)];
        }

        //Get Object
        private static string GetObject(Random rnd)
        {
            string[] Object = { "turtle", "cum-sock ", "child", "sloth", "monkey", "stormtrooper", "ice-cream", "a stinky" };
            return Object[rnd.Next(8)];
        }
    }
}
