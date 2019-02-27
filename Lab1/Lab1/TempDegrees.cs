using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class TempDegrees
    {
        static void Main()
        {
            double f, c, c1;
            Console.WriteLine("Enter the value of temperature in Celcius: ");
            c = Convert.ToDouble(Console.ReadLine());
            f = (c * 9 / 5 + 32);
            Console.WriteLine(f);
            c1 = (( f - 32 ) * 5) / 9;
            Console.WriteLine(c1);
            Console.ReadLine();
        }
    }
}
