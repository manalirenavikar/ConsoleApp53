using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptOverideOverload
{

    public class Person
    {
        private string name; // field
        public string Name   // property
        {
            get { return name; }
            set { name = value; }
        }

        public string checkName(string ckname)
        {
             if(name=="Manali")
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
            return name;
        }
    }

    class Program
    {
        
    static void Main(string[] args)
        {
            Person myObj = new Person();
            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();
            myObj.Name = name;
        //    Console.WriteLine(myObj.Name);
           // Console.ReadLine();
            myObj.checkName(name);
            Console.ReadLine();
        }
    }
}
