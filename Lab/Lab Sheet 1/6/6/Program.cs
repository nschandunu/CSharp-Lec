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
                Console.WriteLine("Enter Your Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Exam Mark: ");
                int mark = int.Parse(Console.ReadLine());
                string grade = "";
                if (mark >= 75)
                {
                    grade = "A";
                }
                else if (mark >= 60)
                {
                    grade = "B";
                }
                else if (mark >= 50)
                {
                    grade = "C";
                }
                else if (mark >= 40)
                {
                    grade = "D";
                }
                else
                {
                    grade = "Failed";
                }
                Console.WriteLine($"Hey, {name}, Your Grade is {grade}.");
            }
        }
}