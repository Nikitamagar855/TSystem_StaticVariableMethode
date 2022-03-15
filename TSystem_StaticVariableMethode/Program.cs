using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSystem_StaticVariableMethode
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee( "nikita","nashik");
            Console.WriteLine( (emp.GetData()));
            Console.WriteLine(emp.Get);
            Console.ReadLine();
        }
    }
}
