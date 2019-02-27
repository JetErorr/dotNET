using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// namespace Lab1
// {
    class Tut1
    {
        static void Main(string[] args)
        {
            for(int i = 0; i< 4;i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    Console.Write("*"+j);
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
// }
