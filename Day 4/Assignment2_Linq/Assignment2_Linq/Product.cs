using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_Linq
{
   public  class Product
    {
        public int id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
        public DateTime CreatedOn{ get; set;}

        public Product (int id, string name, double price, string category, DateTime createdon)
        {
            this.id = id;
            this.Name = name;
            this.Price = price;
            this.Category = category;
            this.CreatedOn = createdon;

        }
        public override string ToString()
        {
            return $"Id={this.id}, Name={this.Name}, Price={this.Price}, Category={this.Category}, CreatedOn={this.CreatedOn.ToShortDateString()}";

        }
        


    }
}
