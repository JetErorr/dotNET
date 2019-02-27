using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Reflection
    {
        static void Main(string[] args)
        {
            var assembly = Assembly.LoadFrom(@"");
            Console.WriteLine("Assembly Name: " + assembly.FullName);
            var types = assembly.GetTypes();
            foreach (var type in types)
            {
                Console.WriteLine("Class Name: " + type.Name);
                Console.WriteLine("Class Full Name: "+ type.FullName);
                var flds = type.GetFields();
                foreach (var f in flds)
                {
                    Console.WriteLine("\nField Name: "+f.Name);
                    Console.WriteLine("Field is public: "+f.IsPublic);
                }
            }
        }
    }
}
