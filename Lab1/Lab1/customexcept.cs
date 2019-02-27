//Custom Exception / User Defined Exception
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class customexcept : Exception
    {
        public customexcept(string s)
        {
            Console.WriteLine("Xyz, custom message / logic");
            Console.WriteLine("Checking wether the entered age is negative or not");
            Console.WriteLine(s);
        }
    }
    class xyz
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter age");
            int age = Convert.ToInt32(Console.ReadLine());
            try
            {
                if (age < 0)
                {
                    throw (new customexcept("This is a thrown exception.!"));
                }
                else
                {
                    Console.WriteLine("You are good to go.!");
                }
            }
            catch(customexcept e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
