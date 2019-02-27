using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Tut3
    {
        static void Main()
        {
            Console.WriteLine("Enter the rate Dollars/Rs\n>");//69.8850
            string dollars = Console.ReadLine();
            Console.WriteLine("Enter the rate Euros/Rs\n>");//80.0929
            string euros = Console.ReadLine();
            Console.WriteLine("Enter the current price of Franc\n>");//71.1061
            string franc = Console.ReadLine();
            Console.WriteLine("Enter the current amount of Rupees that you have\n>");
            string rupees = Console.ReadLine();
            float res1, res2, resrs;
            if ((float.TryParse(dollars, out res1)) && (float.TryParse(rupees, out res2))){
                resrs = res2 / res1;
                Console.WriteLine("Dollars: {0}", resrs);
            }if ((float.TryParse(euros, out res1)) && (float.TryParse(rupees, out res2))){
                resrs = res2 / res1;
                Console.WriteLine("Euros: {0}", resrs);
            }if ((float.TryParse(franc, out res1)) && (float.TryParse(rupees, out res2))){
                resrs = res2 / res1;
                Console.WriteLine("Franc: {0}", resrs);
            }Console.ReadKey();
        }
    }
}
