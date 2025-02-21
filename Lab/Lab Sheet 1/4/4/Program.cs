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
            Console.Write("Enter value of N: ");
            int n = int.Parse(Console.ReadLine());

            int result = Fibonacci(n);
            Console.WriteLine("Fibonacci of {0} is: {1}", n, result);
        }

        static int Fibonacci(int n)
        {
            if (n <= 0) return 0;
            if (n == 1) return 1;

            int a = 0, b = 1, sum = 0;
            for (int i = 2; i <= n; i++)
            {
                sum = a + b;
                a = b;
                b = sum;
            }
            return b;
        }
    }
}