using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
namespace Lab1
{
    class reflection2b
    {
        static void Main(string[] args)
        {
            var mbly = Assembly.GetExecutingAssembly();
                //LoadFile(@"C:\Users\Jarde\Documents\visual studio 2015\Projects\Lab1\Lab1\Properties\AssemblyInfo.cs");
            Console.WriteLine("The name of the assembly is: "+mbly.FullName);

            var cls = mbly.GetTypes();
            foreach(var abc in cls)
            {
                Console.WriteLine("Name of class is: "+abc.Name+" \t\t\t base: "+abc.BaseType);
                var prop = abc.GetProperties();
                foreach(var p in prop)
                {
                    Console.WriteLine("Name of property: "+p.Name);
                }
            }
        }
    }
}
