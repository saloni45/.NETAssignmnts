using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[10];
            Console.WriteLine("Enter the All 10 Names:");
            for (int n = 0; n < 10; n++)
            {
                names[n] = Console.ReadLine();
            }
            Console.WriteLine("Enter names to be searched for:");

            string NameList = Console.ReadLine();

            int find = 0;
            foreach (string name in names)
            {
                if (name == NameList)
                {
                    find = 1;
                    break;
                }
            }
            if (find == 1)
            {
                Console.WriteLine("Name" + " " + NameList + " " + "Found");
            }
            else
            {
                Console.WriteLine(" Name Not Found");
            }
            Console.ReadKey();






        }
    }
}
