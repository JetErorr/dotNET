using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    interface A
    {
        void Add();
    }
    interface B
    {
        void Sub();
    }
    class Interfac : A, B
    {
        public void Add()
        {
            Console.WriteLine("Addition Logic.!");
        }
        public void Sub()
        {
            Console.WriteLine("Subtraction Logic.!");
        }
    }
    class InterfacesDemo
    {
        static void Main()
        {
            Interfac cc = new Interfac();
            cc.Add();
            cc.Sub();
        }
    }
}
