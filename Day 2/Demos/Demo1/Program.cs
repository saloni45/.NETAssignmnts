using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 10, n2 = 20;
            Console.WriteLine($" In before invoking swap n1 ={n1}, n2 ={n2}");
            Console.ReadKey();
        }
        static void Swap ( ref int num1, ref int num2)
        {
            Console.WriteLine($"Insie swap before swapping num1 ={num1}, num2 ={num2}");
            int temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine($"Insie swap before swapping num1 ={num1}, num2 ={num2}");

        }

    }
}
