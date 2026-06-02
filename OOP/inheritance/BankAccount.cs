using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe2.OOP.inheritance
{
    internal class BankAccount
    {
        public double Balance { get; private set; }

        public void Deposit(double amount)
        {
            if(amount > 0)
            {
                Balance += amount;
            }
        }
    }
}
