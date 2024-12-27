using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demoo.Binding
{
    internal class FulltimeEmployee:Employee
    {
        public Decimal Salary { get; set; }
        public new void MyFun01()
        {
            Console.WriteLine("Iam Full Time Employee");
        }
        public override void MyFun02()
        {
            Console.WriteLine($"Employee :Id {Id} , Name: {Name}, Age: {Age} , Salary :{Salary}");

        }
    }
}
