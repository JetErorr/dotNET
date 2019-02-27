using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Tut2
    {
        static void Main()
        {
            Console.WriteLine("Enter you name and your country's name:\n>");
            string name = Console.ReadLine();
            string country = Console.ReadLine();
            Console.WriteLine("Your name is "+name+" and your country's name is: "+country);
            Console.ReadKey();
        }
    }
}
