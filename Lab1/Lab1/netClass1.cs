using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public abstract class shape
    {
        public abstract void calarea();
        public virtual void getval() { }
    }
    public class circle : shape
    {
        public static double r = 0;
        public sealed override void calarea()
        {
            Console.WriteLine("Value = "+3.14*(r*r));
        }
        public sealed override void getval()
        {
            Console.WriteLine("Enter the value of R (radius):");
            r = Convert.ToDouble(Console.Read());
        }
    }
    public class sphere : circle
    {
        public double calvolume()
        {
            return (4/3)*(3.14*r*r*r);
        }
    }
    class netClass1
    {
        static void Main()
        {
            circle obj1 = new circle();
            obj1.getval();
            obj1.calarea();

            sphere obj2 = new sphere();
            double n = obj2.calvolume();
            Console.WriteLine(n);

        }
    }
}
