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
                Console.WriteLine("Enter your degree: ");
                string degree = Console.ReadLine();
                Console.WriteLine("Enter your ambition: ");
                string ambition = Console.ReadLine();

                Console.WriteLine($"You Can be {ambition} if you follow {degree}");

            }
        }
}