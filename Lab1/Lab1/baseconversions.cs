using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class baseconversions
    {
        static void Main()
        {
            Console.Write("Enter a Decimal number: \n>");
            int a = Convert.ToInt32(Console.ReadLine());
            String binary = Convert.ToString(a, 2);
            Console.WriteLine(binary);
            String octal = Convert.ToString(a, 8);
            Console.WriteLine(octal);
            String hex = Convert.ToString(a, 16);
            Console.WriteLine(hex);
            //int b = 0, o = 0;
            //int dec = Convert.ToInt32(Console.ReadLine());
            //int dec1 = dec;
            //int[] bin = new int[32];
            //int[] oct = new int[32];
            //do
            //{
            //    bin[b] = dec % 2;
            //    dec /= 2;
            //    b++;
            //} while (dec != 1);
            //bin[b] = 1;
            //do
            //{
            //    oct[o] = dec1 % 8;
            //    Console.WriteLine(oct[o]);
            //    dec1 /= 8;
            //    Console.WriteLine(dec1);
            //    o++;
            //} while (dec1 > 8);
            //oct[o] = 1;
            //for(int j = b; j >= 0; j--)
            //{
            //    Console.Write(bin[j]);
            //}
            //Console.WriteLine("\n");
            //for(int j = o; j >= 0; j--)
            //{
            //    Console.Write(bin[j]);
            //}
            Console.ReadKey();
        }
    }
}
