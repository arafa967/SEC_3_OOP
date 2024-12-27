using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demoo.Overriding
{
    internal class TypeC :TypeB
    {
        public int C {  get; set; }
        public TypeC(int _A, int _B, int _C):base(_A,_B)
        {
            C = _C;

        }public new void MyFun01()
        {
            Console.WriteLine("Iam Dervied [GrandChild]");
        }
        public virtual void MyFun02()
        {
            Console.WriteLine($"TypeB : A {A},B:{B},C ={C} ");
        }

    }
}
