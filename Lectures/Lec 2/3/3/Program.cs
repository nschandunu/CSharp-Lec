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
                
                Console.WriteLine("What's your age? ");
                // int age = Console.ReadLine();
                
                // Pharsing
                int age = int.Parse(Console.ReadLine()); // changing/parsing string to int type
                Console.WriteLine($"My Name: {name} \n My Age: {age}");
                
                //Converting
                Console.WriteLine("How much you have in your pocket? ");
                double amount = Convert.ToDouble(Console.ReadLine());  // converting string into double
            }
        }
}