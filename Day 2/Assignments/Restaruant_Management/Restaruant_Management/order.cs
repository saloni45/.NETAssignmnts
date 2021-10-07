using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaruant_Management
{
    class Order : IOrder, ICancelable

    {
        int ID { get; set; }
        string Status { get; set; }

        private string customerName1;
        public string CustomerName1
        {
            set { customerName1 = value; }
            get { return customerName1; }
        }

        private int OrderAmount1;
        public int orderAmount1
        {
            set { OrderAmount1 = value; }
            get { return OrderAmount1; }

        }
        string CustomerName { get; set; }
        int OrderAmount { get; set; }
        public string OrderStatus;
        public void Confirm()
        {
            OrderStatus = "Confirmed";
            Console.WriteLine("Order Status: " + OrderStatus);
            
        }
        public void Cancel()
        {
            OrderStatus = "Canclled";
            Console.WriteLine("Order Status: " + OrderStatus);
            
        }

        string ICancelable.Cancel()
        {
            throw new NotImplementedException();
        }
    }
   
    }

   
