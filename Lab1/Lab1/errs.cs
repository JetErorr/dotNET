using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class errs
    {
        static void Main()
        {
            int a, b;
            Console.WriteLine("Enter the value of A");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of B");
            b = Convert.ToInt32(Console.ReadLine());
            try
            {
                int ans = a / b;
                Console.WriteLine("Answer = " + ans);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: "+e.Message);
            }
            finally
            {
                Console.WriteLine("Finally Method");
            }
        }
    }
}
