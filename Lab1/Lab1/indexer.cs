using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab1
{
    class indexer
    {
        private String[] name = new String[3];
        public String this[int i]
        {
            set
            {
                name[i] = value;
            }
            get
            {
                return name[i];
            }
        }
    }
    class indxtest
    {
        static void Main()
        {
            indexer obj = new indexer();
            obj[0] = "Name0";
            obj[1] = "Name1";
            obj[2] = "Name2";
            Console.WriteLine(obj[0]);
            Console.WriteLine(obj[1]);
            Console.WriteLine(obj[2]);
        }
    }
}