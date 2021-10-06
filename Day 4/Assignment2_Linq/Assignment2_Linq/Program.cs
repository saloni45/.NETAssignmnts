using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_Linq
{
    class Program
    { static List<Product> GetProducts()
        {
            var Products = new List<Product>()
            {
                new Product (101,"Pendrive", 1100,"Electronics",new DateTime(2021-01-01) ),
                new Product (102,"Wireless Keyboard", 3000,"Electronics",new DateTime(2021-12-12) ),
                new Product (101,"Wireless Mouse", 1500,"Electronics",new DateTime(2021-02-12) ),
                new Product (101,"Formal Shoes", 3000,"Footwear",new DateTime(2021-01-10) ),
                new Product (101,"Formal Shirt", 2200,"Clothing",new DateTime(2021-12-01) ),
            };
       
            return Products;

        }
        static void Main(string[] args)
        {
            var Data = GetProducts();
            Console.WriteLine("Data by Ascending order");
            var QueryName= from obj in Data
                          orderby obj.Name
                          select obj;
            foreach (var Pro in QueryName)
            {
                Console.WriteLine(Pro);
            }
            Console.WriteLine("\nData by Order Range 1000 to 2000");
            var QueryPrice = from obj in Data
                         
                          
                             orderby obj.Price
                             where obj.Price > 1000 && obj.Price < 2000
                             
                             select obj;
            foreach (var Pro in QueryPrice)
            {
                Console.WriteLine(Pro);
            }
            Console.WriteLine("\n Data of 2021");

            var QueryDateTime = from obj in Data
                             orderby obj.CreatedOn
                           where obj.CreatedOn.Year == 2021
                             select obj;
            foreach (var Pro in QueryDateTime)
            {
                Console.WriteLine(Pro);
            }
            Console.ReadKey();

        }

    }
}
