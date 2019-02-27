
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collection
{
    class Class1
    {
        public void impstack()
        {
            Stack st = new Stack();
            st.Push('A');
            st.Push('B');
            st.Push('C');
            st.Push(1);
            st.Push("abc");
            st.Push('d');
            Console.WriteLine("Elements in stack are");
            foreach (var s in st)
            {
                Console.WriteLine(s);

            }
            char c = (char)st.Pop();
            Console.WriteLine("Poped element" + c);
            Console.WriteLine("top most element" + st.Peek());
            Console.WriteLine("Does stack contains 'A'" + st.Contains('A'));
        }
        public void implementqueue()
        {
            Queue qu = new Queue();
            qu.Enqueue('A');
            qu.Enqueue('B');
            qu.Enqueue('C');
            qu.Enqueue(1);
            Console.WriteLine("Queue elements are");
            foreach (var q in qu)
            {
                Console.WriteLine(q);
            }
        }
        public void implementarraylist()
        {
            ArrayList al = new ArrayList();
            al.Add('A');
            al.Add('B');
            al.Add('C');
            Console.WriteLine("Elements inserted using Add()");
            for (int i = 0; i < al.Count; i++)
            {
                Console.WriteLine(al[i]);
            }
            al.Insert(3, 'F');
            ArrayList a = new ArrayList();
            a.Add("Monday");
            a.Add("Tuesday");
            a.Add("Wednesday");
            Console.WriteLine(" Arraylist inserted using Add()");
            for (int i = 0; i < a.Count; i++)
            {
                Console.WriteLine(a[i]);
            }

        }

        static void Main(string[] args)
        {
            Class1 obj = new Class1();
            obj.impstack();
            obj.implementqueue();
            obj.implementarraylist();
            Console.ReadKey();

        }
    }

}

