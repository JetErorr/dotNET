using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Prop
    {
        private string name;
        private string address;
        private double salary;
        private int e_id;
        string[] role = new string[2];

        public object this[int i]
        {
            set
            {
                if (i == 0)
                { this.name = (string)value; }
                else if (i == 1)
                { this.address = (string)value; }
                else if (i == 2)
                { this.salary = (double)value; }
                else if (i == 3)
                { this.e_id = (int)value; }
            }
            get
            {
                if (i == 0)
                { return this.name; }
                else if (i == 1)
                { return this.address; }
                else if (i == 2)
                { return this.salary; }
                else if (i == 3)
                { return this.e_id; }
                else
                { return null; }
            }
        }
    }
    class Proper
    {
        static void Main()
        {
            Prop obj = new Prop();

            obj[0] = "Jeet";
            obj[1] = "Earth";
            obj[2] = 42000D;
            obj[3] = 420;

            for(int j = 0; j < 3; j++)
            {
                Console.WriteLine(obj[j]);
            }
            Console.ReadKey();
        }
    }
}
