using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaruant_Management
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Customer name");
            string CustomerName1 = Console.ReadLine();

            Console.WriteLine("Enter Amount");
            int OrderAmount1 = Convert.ToInt32(Console.ReadLine());

            DateTime OrderDate = DateTime.Today;

            Console.WriteLine("Enter your choice what you want to do");
            Console.WriteLine("1.Confirm");
            Console.WriteLine("2.Cancle");
            int Choice = Convert.ToInt32(Console.ReadLine());
            Order Obj = new Order();
            Obj.CustomerName1 = CustomerName1;
            Obj.orderAmount1 = OrderAmount1;
            Console.WriteLine("Your order details......");
            Console.WriteLine("Your Name: " + Obj.CustomerName1);
            Console.WriteLine("Your order amount:" + Obj.orderAmount1);
            Console.WriteLine("Your order Date: " + OrderDate);
            switch (Choice)
            {
                case 1:
                    Obj.Confirm();
                    break;

                case 2:
                    Obj.Cancle();
                    break;

                default:
                    Console.WriteLine("Enter Valid Choice");
                    break;
            }
            Console.ReadKey();

        }

    }
    }

