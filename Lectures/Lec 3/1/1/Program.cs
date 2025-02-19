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
            while (true)
            {
                Console.WriteLine("MAIN MENU:\n 1. Register\n 2. Display\n 3. Exit \n\n Enter your choice: ");

                int choice = int.Parse(Console.ReadLine()); 

                if (choice == 1)
                {
                    Console.Write("Enter your first name: ");
                    string firstName = Console.ReadLine();

                    Console.Write("Enter your age: ");
                    int age;
                    while (!int.TryParse(Console.ReadLine(), out age))
                    {
                        Console.Write("Invalid input. Please enter a valid age: ");
                    }

                    Console.WriteLine($"Registration successful! Name: {firstName}, Age: {age}");
                }
                
                else if (choice == 2)
                {
                    Display();
                }
                else if (choice == 3)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please enter a valid choice.");
                }
            }
        }
    }
}
