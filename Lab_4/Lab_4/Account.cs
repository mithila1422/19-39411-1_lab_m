using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
   abstract class Account
   {
       private string a;

        public string A
        {
            get { return a; }
            set { a = value; }
        }
        private string aName;

        public string AName
        {
            get { return aName; }
            set { aName = value; }
        }
        protected double balance;

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public Account()
        {

        }
        public Account(string a, string aName, double balance)
        {
            this.a = a;
            this.aName = aName;
            this.balance = balance;
        }
        abstract public void Deposit(double amount);

        abstract public void Withdraw(double amount);

        virtual public void ShowInfo()
        {
            Console.WriteLine("Account Name: " + aName);
            Console.WriteLine("Account No: " + a);
            Console.WriteLine("Balance: " + balance);
        }
       } 
}

