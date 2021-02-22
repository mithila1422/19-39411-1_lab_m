using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class OverDraft : Account
    {
        private double withdrawLimit;

        public double WithdrawLimit
        {
            get { return withdrawLimit; }
            set { withdrawLimit = value; }
        }

        public OverDraft() { }
        public OverDraft(string accNo, string accName, double balance, double withdrawLimit)
            : base(accNo, accName, balance)
        {
            this.withdrawLimit = withdrawLimit;
        }

        public override void Withdraw(double amount)
        {
            if (amount < withdrawLimit)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
            }
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
