using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections1
{
    class hashtable
    {
        static void Main()
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "qual");
            ht.Add(2, "qua");
            ht.Add(3, "qu");
            ht.Add(4, "q");
            for(int i = 0; i <= ht.Count; i++)
            {
                Console.WriteLine(ht[i]);
            }
        }
    }
}
