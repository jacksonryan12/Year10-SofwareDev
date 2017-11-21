using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeAPerson
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Uncle", "Phil", 55);
            p.male;
        }
    }
    class Person
    {
        private string firstname;
        private string lastname;
        private int age;
        private bool male;

        public Person(string firstname, string lastname, int age, bool male)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.age = age;
            male = true;
        }

        public void male()
        {
            if (male)
            {
                Console.WriteLine($"{firstname} {lastname} is female");
            }
            else
            {
                male = true;
            }
        }
    }
}

