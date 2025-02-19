using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec1Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name? ");
            string name = Console.ReadLine();
            Console.WriteLine("What's your college? ");
            string college = Console.ReadLine();
            Console.WriteLine("What's your Mother’s name? ");
            string mom = Console.ReadLine();
            Console.WriteLine("What's your Best Friend’s name? ");
            string friend = Console.ReadLine();
            
            Console.WriteLine($"Hello, my name is {name} and I am studying at {college}. My mother’s name is {mom} and my best friend’s name is {friend}.");
        }
    }
}