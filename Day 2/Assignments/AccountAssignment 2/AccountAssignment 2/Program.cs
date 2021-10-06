using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountAssignment_2
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Account Number");
            int AccountNo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Customer name");
            string CustomerName = Console.ReadLine();

            Console.WriteLine("Enter amount to Deposit or Withdraw");
            int Amount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your choice what you want to do");
            Console.WriteLine("1.Withdraw");
            Console.WriteLine("2.Deposit");
            int Choice = Convert.ToInt32(Console.ReadLine());
            SavingAccount Obj = new SavingAccount();
            switch (Choice)
            {
                case 1:
                    Obj.Check(Amount);
                    break;

                case 2:
                    Obj.DepositAmount(Amount);
                    break;

                default:
                    Console.WriteLine("Enter Valid Choice");
                    break;
            }
            Console.ReadKey();
        }

    }
}

