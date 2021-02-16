using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Even Number
            int n = 30;
            int i;
            Console.WriteLine("Even Numbers are : ");
            for (i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            //Sum even and odd number
            int k = 0;
            int c = 0;
            for (i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    k = k + i;

                }
                else
                {
                    c = c + i;

                }
            }
            Console.WriteLine("Sum of all even number is : " + k);
            Console.WriteLine("Sum of all odd number is : " + c);

            //Factorial
            int fact = 1;
            for (i = 1; i <= 5; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("Factorial result : " + fact);

            //xoxo
            int j;
            Console.WriteLine();

            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 6; j++)
                {
                    if (i % 2 == 0)
                    {
                        if (j % 2 == 0)
                        {
                            Console.Write("X");

                        }
                        else
                        {
                            Console.Write("0");
                        }
                    }
                    else
                    {
                        if (j % 2 == 0)
                        {
                            Console.Write("0");

                        }
                        else
                        {
                            Console.Write("X");
                        }
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //1-9
            int row, col;
           for (row = 1; row <= 5; row++)
            {
                for (col = row; col <= (row + 4); col++)
                {
                    Console.Write(col);
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            //12345
            for (row = 1; row <= 5; row++)
            {
                for (col = 1; col <= (row - 1); col++)
                {
                    Console.Write(" ");
                }
                for (col = row; col <= row; col++)
                {
                    Console.Write(col);
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            //patten 
            for (row = 1; row <= 5; row++)
            {
                for (col = 1; col <= row; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (row = 4; row >= 1; row--)
            {
                for (col = 1; col <= row; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

           
        }
    }
}
       