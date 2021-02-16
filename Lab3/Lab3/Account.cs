using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Account
    {
        string accName;
        string acId;
        int balance;

        public string Name
        {
            set { accName = value; }
            get { return accName; }
        }
        public string Id
        {
            set { acId = value; }
            get { return acId; }
        }

        public int Balance
        {
            set { balance = value; }
            get { return balance; }
        }

        public void ShowInfo()
        {
            Console.WriteLine("Account Holder Name : " + Name);

            Console.WriteLine("Account ID : " + Id);

            Console.WriteLine("Account initial balance : " + Balance);

        }

        public void Deposit(int amount)
        {

            if (amount >= 0)
            {
                Console.WriteLine("Previous Amount : " + balance);
                Console.WriteLine("You deposit " + amount + " Tk");
                balance = balance + amount;
                Console.WriteLine("Now your total amount " + balance + " TK");
            }

            else
            {
                Console.WriteLine("Envalid Amount");
            }
        }

        public void Withdraw(int amount)
        {
            if (amount >= 0 && (balance - amount) >= 0)
            {
                Console.WriteLine("Previous Amount : " + balance);
                Console.WriteLine("You withdraw " + amount + " Tk");
                balance = balance - amount;
                Console.WriteLine("Now your total amount " + balance + " TK");
            }
            else
            {
                if (amount < 0)
                {
                    Console.WriteLine("Invalid amount");
                }
                else if ((balance - amount) < 0)
                {
                    Console.WriteLine("You can't withdraw more money");
                }
            }
        }
    }
}
