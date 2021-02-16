using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Triangle
    {
        int x, y, z;
        public int X
        {
            set { x = value; }
            get { return x; }
        }
        public int Y
        {
            set { y = value; }
            get { return y; }
        }

        public int Z
        {
            set { z = value; }
            get { return z; }
        }

        public void ShowInfo()
        {
            Console.WriteLine("X : " + X);
            Console.WriteLine("Y : " + Y);
            Console.WriteLine("Z : " + Z);

        }

        public void TestTriangle()
        {
            if (X == Y && Y == Z && X == Z)
            {
                Console.WriteLine("3 equal side");
            }
            else if (X == Y || Y == Z || X == Z)
            {
                Console.WriteLine("2 equal side");
            }
            else
            {
                Console.WriteLine("No equal side");
            }
        }
    }
}
