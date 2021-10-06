using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            int MathsMarks, PhysicsMarks, ChemistryMarks;
            Double TotalMarks, Average;

            Console.WriteLine("Enter Maths Mark: ");
            MathsMarks = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Physics Mark: ");
            PhysicsMarks = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Chemistry Mark: ");
            ChemistryMarks = Convert.ToInt32(Console.ReadLine());

            TotalMarks = MathsMarks + PhysicsMarks + ChemistryMarks;
            Console.WriteLine($"Total Marks: : { TotalMarks}");

            Average = TotalMarks / 3.0;
            Console.WriteLine($"Avearge Mark: : {Average}");

            if(Average>90)
            {
                Console.WriteLine("Grade A");
            }
            else if (Average >80)
            {
                Console.WriteLine("Grade B");
            }
            else 
                    {
                Console.WriteLine("Grade C");
            }

            Console.ReadKey();


        }
    }
}
