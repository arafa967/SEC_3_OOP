using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demoo.Overriding
{
    internal class TypeA
    {

        public int A {  get; set; }

        public TypeA(int _A)
        {
            A = _A;

        }
        public void MyFun01()
        {
            Console.WriteLine("Iam Base Parent ");
        }
        public virtual void MyFun02() 
        {
            Console.WriteLine();
        }

    }
}
