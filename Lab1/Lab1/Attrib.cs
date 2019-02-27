using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class attdemo
    {
        [Obsolete("Method Depricated.!", false)]
        public static int add(int n1, int n2)
        {
            return (n1 + n2);
        }
        //[Obsolete("Method Depricated.!", false)]
        public static int add(int n1, int n2, int n3)
        {
            return (n1 + n2 + n3);
        }
    }
    class Attrib
    {
        static void Main(string[] args)
        {
        attdemo.add(1,2);
        attdemo.add(3,4,5);
        }
    }
}
