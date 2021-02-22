using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class Saving : Account
    {
        public Saving() { }
        public Saving(string accNo, string accName, double balance)
            : base(accNo, accName, balance)
        {

        }
        public override void Withdraw(double amount)
        {
            if (balance - amount >= 500)
            {
                balance -= amount;
            }
            else
                Console.WriteLine("Insufficient Balance");
        }
        public override void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
            }
        }
        public override void ShowInfo()
        {
            base.ShowInfo();

        }
    }
}
