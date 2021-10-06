using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine(" Calculator");

            //Fist Number
            Console.WriteLine(" Enter the First Number:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Press Enter");

            //Second Number
            Console.WriteLine(" Enter the  Second Number:");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Press Enter");

            //Choose an Option
            Console.WriteLine("Choose option from the below mentioned list:");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Substract");
            Console.WriteLine("\tm - Multiplication");
            Console.WriteLine("\td - Division");
            Console.WriteLine("your option");

            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Your  result : {num1} + {num2} = " + (num1 + num2));
                    break;
                case "s":
                    Console.WriteLine($"Your  result : {num1} - {num2} = " + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"Your  result : {num1} * {num2} = " + (num1 * num2));
                    break;
                case "d":
                    Console.WriteLine($"Your  result : {num1} / {num2} = " + (num1 / num2));
                    break;

            }
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
