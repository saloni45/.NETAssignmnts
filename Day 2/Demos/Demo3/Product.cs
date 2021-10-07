using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3
{
    class Product
    {
        public int id;
       public  string name;
       public  int  quantity;

            public void Purhchase (int qty)
        {
            quantity -= qty;

        }


    }
}
