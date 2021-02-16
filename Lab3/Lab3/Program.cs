using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {

            //  Student Class
            Student s1 = new Student();
            s1.Name = "Insana Marium Methela";
            s1.Id = "19-39411-1";
            s1.Department = "CSE";
            s1.Cgpa = 3.41f;
            s1.ShowInfo();

            
            Console.WriteLine("-----------------------");

            // Triangle Class
            Triangle t1 = new Triangle();
            t1.X = 15;
            t1.Y = 10;
            t1.Z = 20;
            t1.ShowInfo();
            t1.TestTriangle();


           
            Console.WriteLine("-----------------------");

            // Account Class

            Account a1 = new Account();
            a1.Name = "Methela";
            a1.Id = "XX-XXXX-XX";
            a1.Balance = 30000;
            a1.ShowInfo();
            Console.WriteLine();
            a1.Deposit(500);
            Console.WriteLine();
            a1.Withdraw(-2);

            
            Console.WriteLine("-----------------------");
            //Course Class
            Course c1 = new Course();
            c1.Name = "Object oriented programmin 2";
            c1.Code = "CSE 3110";
            c1.Credit = 3;
            c1.CourseInfo();
        }
    }
}
