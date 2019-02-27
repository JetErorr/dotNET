using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class temp
    {
        public virtual void meth()
        {
            Console.WriteLine("Inside Base Method.!");
        }
    }
    class temp2 : temp
    {
        public override void meth()
        {
            Console.WriteLine("Inside OverWritten Method");
        }
    }
    class Overriden
    {
        static void Main()
        {
            temp obj = new temp();
            obj.meth();
            temp2 obj2 = new temp2();
            obj2.meth();
            temp obj3 = new temp2();
            obj3.meth();
            //temp2 obj4 = new temp();
        }
    }
}
