using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Saving("34111", "Saving Account", 10000.00);
            a1.Withdraw(4500);
            Console.WriteLine();
            a1.ShowInfo();
            Console.WriteLine();
            a1.Withdraw(2000);
            Console.WriteLine();
            a1.ShowInfo();
            Console.WriteLine();
            Account a2 = new Fixed("34111", "Fixed Account", 10000.00, 2018, 2021);
            a2.Withdraw(1000);
            Console.WriteLine();
            a2.ShowInfo();
            Console.WriteLine();
            Account a3 = new Fixed("34111", "Fixed Account", 10000.00, 2018, 2021);
            a3.Withdraw(1000);
            Console.WriteLine();
            a3.ShowInfo();
            Console.WriteLine();
            Account a4 = new SpecialCurrent("34111", "Special Account", 10000.00);
            a4.Withdraw(1500);
            Console.WriteLine();
            a4.ShowInfo();
            Console.WriteLine();
            a4.Withdraw(500);
            Console.WriteLine();
            a4.ShowInfo();
            Console.WriteLine();
            Account a5 = new OverDraft("34111", "Overdraft", 10000.00, 500.00);
            a5.Withdraw(600);
            Console.WriteLine();
            a5.ShowInfo();
            Console.WriteLine();
            a5.Withdraw(400);
            Console.WriteLine();
            a5.ShowInfo();
            Console.WriteLine();
        }
    }
}
