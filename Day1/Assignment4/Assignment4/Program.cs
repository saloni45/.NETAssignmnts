using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, a, b;
            int[,] arr1 = new int[20, 20];
            int[,] arr2 = new int[20, 20];

            Console.Write("\n Enter the rows and coulmns :\n");
            Console.Write("Rows : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Columns : ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Enter elements in the matrix :\n");
            for (i = 0; i < a; i++)
            {
                for (j = 0; j < b; j++)
                {
                    Console.Write("element - [{0}],[{1}] : ", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.Write("\nThe matrix is :\n");
            for (i = 0; i < a; i++)
            {
                Console.Write("\n");
                for (j = 0; j < b; j++)
                    Console.Write("{0}\t", arr1[i, j]);
            }

            for (i = 0; i < a; i++)
            {
                for (j = 0; j < b; j++)
                {

                    arr2[j, i] = arr1[i, j];
                }
            }

            Console.Write("\n\nThe Transpose of a matrix is : ");
            for (i = 0; i < b; i++)
            {
                Console.Write("\n");
                for (j = 0; j < a; j++)
                {
                    Console.Write("{0}\t", arr2[i, j]);
                }
            }
            Console.Write("\n\n");
            Console.ReadKey();
        }
    }
}
    
