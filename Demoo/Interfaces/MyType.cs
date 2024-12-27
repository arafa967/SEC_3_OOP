using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demoo.Interfaces
{
    internal class MyType:IMyType/* Implement*/
    {
        public int Salary {  get; set; }
        public void Myfun()
        {
            Console.WriteLine("Hello World");
        }
    }
}
