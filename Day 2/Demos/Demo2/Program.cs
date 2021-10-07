using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int empid;
            string empname;
            GetDetails(out empid, out empname);
            Console.WriteLine($"Id ={empid}");
            Console.WriteLine($"Name = {empname}");

            Console.ReadKey();

        }
        static void GetDetails(out int id ,out  string name)
        {
             id = 101;
            name = "jojo";

            string num = "1234a";
           // int i = Convert.ToInt32(num);
            int i;
            bool isnumebr = int.TryParse(num, out i);
            if (isnumber)
                Console.WriteLine("Num is a number ={0}");
            Console.ReadKey();

        }
    }
}
