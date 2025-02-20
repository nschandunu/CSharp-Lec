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
                 Console.Write("Enter a Positive integer: ");
                 int num = int.Parse(Console.ReadLine());
                 
                 if(num < 0)
                 {
                     Console.WriteLine("Error: Please enter a positive integer");
                     return;
                 }
 
                 int result = sum(num);
                 Console.WriteLine(result);
                 
                 static int sum(int num)
                 {
                     int sum = 0;
                     for (int i = 1; i <= num; i++)
                     {
                         sum += i;
                     }
                     return sum;
                 }
             }
         }
 }