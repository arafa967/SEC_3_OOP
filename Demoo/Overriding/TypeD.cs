using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demoo.Overriding
{
    internal class TypeD:TypeC
    {
        public int D { get; set; }
        public TypeD(int _A, int _B, int _C,int _D) : base(_A, _B,_C)
        {
            D = _D;

        }
        public new void MyFun01()
        {
            Console.WriteLine("Iam Dervied [GrandChild02]");
        }
        public new virtual void MyFun02()
        {
            Console.WriteLine($"TypeB : A {A},B:{B},C ={C} ,D={D}");
        }
    }
}
