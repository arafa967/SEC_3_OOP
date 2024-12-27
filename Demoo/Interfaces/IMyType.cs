using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demoo.Interfaces
{// First Devloper 
    internal interface IMyType
    {
        //Default Access Modifier inside the interface is "Public"
        // What you cann write inside the interface
        //1- Singnatuer For Property 
        public int Salary { get; set; }
        // 2- Singnatuer For Method
        public void Myfun(); // C#7
                             //Default Implemented Method ==>C #8 [Net Core 3.1 2019]
        public void print()
        {
            Console.WriteLine("Hallo Iam Default implemented method ");
        }

    }
}
