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
                Console.Write("Enter length: ");
                int length = int.Parse(Console.ReadLine());
                Console.Write("Enter width: ");
                int width = int.Parse(Console.ReadLine());
                
                area(length, width);
                Console.WriteLine("Area of the rectangle is " + area(length, width));
                static int area(int length, int width)
                {
                    return length * width;
                }
            }
        }
}