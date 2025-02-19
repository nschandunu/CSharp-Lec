using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNamespace
{
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("What's your name? ");
                string name = Console.ReadLine();
                
                //string concatenation
                Console.WriteLine("Hello, my name is " + name + ".");
                //string interpolation
                Console.WriteLine($"Hello, my name is {name}.");
            }
        }
}