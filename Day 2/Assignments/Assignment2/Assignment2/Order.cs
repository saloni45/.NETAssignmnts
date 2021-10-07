using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Order
    {

        public int OrderId { get; set; }
        public string CustomerName { get; set; }

        public string OrderDate { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        protected double orderAmount;
        public double OrderAmount
        {
            get { return orderAmount; }

        }
        public double CalculatorOrderAmount()
        {
            orderAmount = Price * Quantity;
            return orderAmount;
        }
        public void PrintOrderDetails()
        {
            Console.WriteLine($"OrderId : {OrderId} \n Customer Name : {CustomerName} \n Order Date : { OrderDate} \n Product Name : {ProductName} \n Price : {Price } \n Quantity: {Quantity} \n  OrderAmount : {OrderAmount}");

        }
    }
}

