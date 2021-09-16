using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode;
using System.Collections;

namespace Interview
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Type
            TypeTest();
            #endregion

            #region Statement 
            StatementTest();
            #endregion

            #region TestReferenceType, ValueType  
            ValueRefTypeTest();
            #endregion

            #region struct
            StructTest();

            #endregion

            #region boxing and unboxing

            BoxUnboxTest();

            #endregion

            #region Enum
            EnumTest();
            #endregion

            // this is regarding type 
            #region is VS as
            IsAsTest();
            #endregion

            //this is regarding object, instance
            #region Equals VS ==
            EqualTest();

            #endregion


            #region Class Basic


            #region access/modifier

            #endregion

            #region getter and setter
            SciFiBook book3 = new SciFiBook("Book3");
            Console.WriteLine(book3.Name);
            book3.Name = "Book4";
            Console.WriteLine(book3.Name);

            #endregion

            #region constant VS readonly

            #endregion

            #region static

            #endregion

            #endregion

            #region Class Advanced


            #region basic inheritance

            #endregion
            #region abstract Vs virtual

            #endregion

            #region Polymorphism

            #endregion
            #region sealed

            #endregion


            #region inteface

            #endregion
            #endregion

        }

        static void TypeTest()
        {
            var typetest = new Type();

            typetest.StringInitialize();
            typetest.StringBuilderInitialize();
            typetest.ArrayInitialize();
            typetest.ListInitialize();
            typetest.HashtableInitialize();
            typetest.DictInitialize();
            typetest.TupleInitialize();
            typetest.HashSetInitialize();
            typetest.DefaultInitialize();
            typetest.NullableInitialize();

        }

        static void StatementTest()
        {
            var st = new Statement();
            st.DoWhileTest();
            st.WhileTest();
            st.ForeachTest();
            st.ForTest();
            st.SelectTest();
        }

        static void ValueRefTypeTest()
        {
            int val = 2;
            Console.WriteLine(val);
            SciFiBook book1 = new SciFiBook("Book1");

            var rvtest = new RefValTest();
            rvtest.TwoVarCanReferenceSameObject();
            rvtest.PassByValuesTest();
            rvtest.CanPassByReferenceTest();
        }

        static void BoxUnboxTest()
        {
            // boxing
            int num = 123;
            Console.WriteLine(num);
            Console.WriteLine(num.GetType());

            object numobj = num;
            Console.WriteLine(numobj);
            Console.WriteLine(numobj.GetType());

            // unboxing
            object obj2 = "stringtest";
            int num2 = (int)obj2;
            string str = (string)obj2;

            Console.WriteLine("unboxing to int {0} and to string {1}", num2, str);

            //A boxing conversion makes a copy of the value being boxed 
            StructTestCoord st = new StructTestCoord(1,1);
            object sto = st;
            st.X = 2;
            Console.WriteLine(st.X);
            Console.WriteLine(((StructTestCoord)sto).X);

        }

        static void EnumTest()
        {
            Season et1 = Season.Autumn;
            Season et2 = Season.Summer;
            Console.WriteLine(et2);

            foreach (Month mon in Enum.GetValues(typeof(Month)))
            {
                Console.WriteLine(mon);
            }
        }

        static void StructTest()
        {
            StructTestCoord sttest = new StructTestCoord(2, 3);
            Console.WriteLine(sttest.X);

        }

        static void IsAsTest()
        {
            
             

        }

        static void EqualTest()
        {

            double e = 2.718281828459045;
            double d = e;
            object o1 = e;
            object o2 = d;

            // check reference
            Console.WriteLine(o1 == o2);

            // check content
            Console.WriteLine(o1.Equals(o2));

            // check reference
            Console.WriteLine(object.ReferenceEquals(o1,o2));
        }
    }
}