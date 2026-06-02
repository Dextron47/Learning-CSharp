using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe2.OOP.Encapsulation
{
    internal class SimpleBank
    {
        private int Balance = 0;

        public void Deposit(int amount)
        {
            if(amount > 0)
            {
                Balance += amount;
                Console.WriteLine("Deposit successful : " + amount);
            }
            else
            {
                Console.WriteLine("Amount is invalid");
            }
        }

       public void Withdraw(int amount)
        {
            if(amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine("Withdrawal successful : " + amount);
            }
            else
            {
               Console.WriteLine("Insufficient balance or invalid amount");
            }
        }
        
        public int GetBalance()
        {
            return Balance;
        }
    }
}
