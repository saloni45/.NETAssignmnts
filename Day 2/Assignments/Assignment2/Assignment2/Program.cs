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
            var order = new Order();
            Console.WriteLine("enter Order Id:");
            order.OrderId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter Coustomer Name:");
            order.CustomerName =Console.ReadLine();

            Console.WriteLine("enter Order Date:");
            order.OrderDate = Console.ReadLine();

            Console.WriteLine("enter Product Name:");
            order.ProductName = Console.ReadLine();

            Console.WriteLine("enter Price:");
            order.Price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter quantity:");
            order.Quantity = Convert.ToInt32(Console.ReadLine());
            order.CalculatorOrderAmount();
            order.PrintOrderDetails();
            Console.ReadKey();

        }
    }
}


