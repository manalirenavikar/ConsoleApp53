using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverload
{
    class Program
    {
        void display(int a)
        {
            Console.WriteLine("Arguments: " + a);
        }
        void display(int a, int b)
        {
            Console.WriteLine("Arguments: " + a + " and " + b);
        }
        static void Main(string[] args)
        {
           
            Program p1 = new Program();
            p1.display(100);
            p1.display(100, 200);
            Console.ReadLine();
        }
    }
}
