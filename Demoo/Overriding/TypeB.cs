using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demoo.Overriding
{
    internal class TypeB:TypeA
    {
        public int B {  get; set; }

        public TypeB(int _A,int _B):base(_A)
        {
            B = _B;
        }
        // static Binding 
        // compiler Will Bind function Call Based on Reference  Not Object 
        //At Compilation time 


        public new void MyFun01() //==> new version from Myfun01
        {
            Console.WriteLine("Iam Drevied [chiled] ");
        }
        //Aplly over riding Using override (by using public - Virtiul)
        // Dynamic Binding [late Binding ]
        // Clr Will Bind Function Call Base on object Not Reference 

        // At Run Time
        public virtual void MyFun02() 
        {
            Console.WriteLine($"TypeB : A {A}\n B:{B}");
        }


            
    }
}
