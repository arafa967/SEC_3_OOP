using System.Xml.Linq;
using Demoo.Binding;
using Demoo.Interfaces;
using Demoo.Overriding;

namespace Demoo
{
    internal class Program
    {
        #region Overriding 
        //public static void processEmployee( Employee employee)//employee = new Fulltime  Employee
        //{ 
        //    if (employee is not null)
        //    {
        //        employee.MyFun01();
        //        employee.MyFun02();
        //    }
        //}
        //public static void processEmployee(PartTimeEmployee employee)//employee = new PartTime Employee
        //{
        //    if (employee is not null)
        //    {
        //        employee.MyFun01();
        //        employee.MyFun02();
        //    }
        //}

        #endregion
        #region Interfece 
        public static void print10NumbersFromSerises(ISeries series)
        {
            if (series == null)
            {
                return;
                for (int i = 0; i < 10; i++) 
                {
                    Console.WriteLine($"{series.Current}\t");
                    series.GetNext();
                }
                series.Reset();
                Console.WriteLine();
            }

        }
        public static void print10NumbersFromSerises(SeriesByThree series)
        {
            if (series == null)
            {
                return;
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"{series.Current}\t");
                    series.GetNext();
                }
                series.Reset();
                Console.WriteLine();
            }

        }
        #endregion
        static void Main(string[] args)
        {
            #region what is binding ?
            // Binding is a behaviour 
            // Referance from parent = object from Chiled
            //TypeA RefBase = new TypeB(1, 2);
            //RefBase.A = 11;
            ////RefBase.B = 12; invalid
            //RefBase.Myfun01();//Iam Base [parent]
            //RefBase.Myfun02();
            //------------------------------------
            //TypeA typeA;
            //typeA = new TypeA(1);
            //typeA = new TypeB(1,2);
            //typeA = new TypeC(1,2,3);
            //TypeB typeB = (TypeB)typeA; // Explicit Casting 
            //Console.WriteLine(typeB.A);
            //Console.WriteLine(typeB.B);
            #endregion
            #region Binding is Behavior 
            //FulltimeEmployee fulltimeEmployee = new FulltimeEmployee()
            //{
            //    Id = 10,
            //    Name = "Rana",
            //    Age = 22,
            //    Salary = 10000
            //};
            //PartTimeEmployee parttimeEmployee = new PartTimeEmployee()
            //{
            //    Id = 10,
            //    Name = "Rana",
            //    Age = 22,
            //    HourRate = 120
            //};
            ////processEmployee(fulltimeEmployee);
            //processEmployee(parttimeEmployee);
            #endregion
            #region Example 02 Binding
            //TypeA typeA = new TypeC(1,2,3);
            //typeA.A = 10;
            //typeA.B = 22; // invalid
            //typeA.C= 10;// invalid 
            // typeA.MyFun01();// static Binding ==> // Iam base [Parent]
            // typeA.MyFun02();

            //TypeB typeB = new TypeC(1,2,3);
            // typeB.A = 11;
            // typeB.B = 12;
            // typeB.MyFun01();// Iam Drivied [Static Binding]
            // typeB.MyFun02();
            #endregion
            #region InterFace
            #region Example01
            IMyType myType;
            // Declare For Reference of Type "ImyType " Refering to Null
            // this Reference "mytype"  Can Refer to An Object From Class Or Struct Implement
            // Clr Will Allocate Byte At Stack For The Reference


            // myType = new IMyType(); // invalid u Cannot Create Object From Interface
            //MyType myType1 = new MyType();
            //myType1.Salary = 10000;
            //myType1.Myfun();
            // invalid  myType1.Print();
            //IMyType refernceFromInterface = new MyType();
            //refernceFromInterface.Salary = 1000;
            //refernceFromInterface.Myfun();
            //refernceFromInterface.print();
            #endregion
            #region Example 02
            ISeriesTwo seriesTwo = new ISeriesTwo();
            print10NumbersFromSerises(seriesTwo);

            SeriesByThree seriesByThree=new SeriesByThree();
            print10NumbersFromSerises(seriesByThree);

            SeriesByFour seriesByFour=new SeriesByFour();
            print10NumbersFromSerises(seriesByFour);

            #endregion
            #endregion

        }
    }
}
