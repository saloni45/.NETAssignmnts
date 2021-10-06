using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountAssignment_2
{
   abstract class Account
    {
        
        

            public int AccountNo { get; set; }
            public string CustomerName { get; set; }
            public int Balance { get; set; }
            public abstract void WithdrawAmount(int WithdrawRef);
            public void DepositAmount()
            {
            }

        }
        class SavingAccount : Account
        {
          
            public SavingAccount()
            {
                Balance = 2000;
            }
            public void Check(int Amount)
            {
                if (Balance - Amount < 500)
                {
                    Console.WriteLine("You cant withdraw");
                    Console.WriteLine("You balance is:" + Balance);
                }
                else
                {
                    WithdrawAmount(Amount);
                }
            }
            public override void WithdrawAmount(int WithdrawRef)
            {
                int Withdraw = WithdrawRef;
                Console.WriteLine("Amount before withdrawal is: " + Balance);
                Balance -= Withdraw;
                Console.WriteLine("Amount after withdrawal is: " + Balance);
            }
            public void DepositAmount(int DepositRef)
            {
                Console.WriteLine("Amount before deposit is: " + Balance);
                int add = DepositRef;
                Balance += DepositRef;
                Console.WriteLine("Amount after deposit is: " + Balance);

            }
        }
    }
