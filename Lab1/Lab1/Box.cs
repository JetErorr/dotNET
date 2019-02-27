using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Box
    {
        private int l, b, h;
        public Box()
        {
        }
        public Box(int x, int y, int z)
        {
            l = x;
            h = y;
            b = z;
        }
        public static Box operator + (Box x, Box y)
        {
            Box c = new Box();
            c.l = x.l + y.l;
            c.h = x.h + y.h;
            c.b = x.b + y.b;
            return c;
        }
        static void Main()
        {
            Box a = new Box(1, 2, 3);
            Box b = new Box(3, 4, 5);
            Box c = new Box();
            c = a + b;
            Console.WriteLine("The total of values is: "+c.l+","+c.h+","+c.b+".!");
        }
    }
}