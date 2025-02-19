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
                int age;
                string name;
                float bill;
                
                Console.WriteLine("Enter your pet's name: ");
                name = Console.ReadLine();
                Console.WriteLine("Enter pet's age: ");
                age = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter pet's last medical bill: ");
                bill = float.Parse(Console.ReadLine());

                string username = "Cat";
                Console.WriteLine($"Username: {username}");
                
                Console.WriteLine("My Pet's name is " + name + " He is " + age + " years old and his last medical bill was " + bill + " rupees.");
                Console.WriteLine("My Pet's name is {0}. He is {1} years old and his last medical bill was {2} rupees.", name, age, bill);
                Console.WriteLine($"My Pet's name is {name}. He is {age} years old and his last medical bill was {bill} rupees.");
                
            }
        }
}
