using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Product ProductObj; //object creation
            //ProductObj = new Product(); // instance creation

            // Product Productobj = new Product(); //object creation + istantiation
            var ProductObj = new Product();
            Console.WriteLine("Enter id");
            ProductObj.id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter name");
            ProductObj.name = Console.ReadLine();

            Console.WriteLine("Enter quantity");
            ProductObj.quantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the quatity to purchase ");
            ProductObj.id = Convert.ToInt32(Console.ReadLine());

            ProductObj.Purchase(quantity);
            Console.WirteLine("Product Details");
            Console.WriteLine($ id ={ ProductObj,i})

            





        }
    }
}
