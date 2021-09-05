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
            int val = 2;
            Console.WriteLine(val);
            SciFiBook book1 = new SciFiBook("Book1", 20);

            var rvtest = new RefValTest();
            rvtest.TwoVarCanReferenceSameObject();
            rvtest.PassByValuesTest();
            rvtest.CanPassByReferenceTest();
            #endregion

            #region struct
            StructTest_Coord test = new StructTest_Coord(2,3);
            Console.WriteLine(test.X);

            int test2 = 3;

            #endregion

            #region boxing and unboxing

            int anum = 123;
            Object obj = anum;
            Console.WriteLine(anum);
            Console.WriteLine(obj);


            Object obj2 = 123;
            int anum2 = (int)obj2;
            Console.WriteLine(anum2);
            Console.WriteLine(obj2);

            #endregion

            #region Enum
            EnumTest et1 = EnumTest.Autumn;
            EnumTest et2 = EnumTest.Summer;
            Console.WriteLine(et1);
            #endregion

            #region is VS as

            #endregion

            #region Equals VS ==

            #endregion

            #region access/modifier

            #endregion

           

            #region getter and setter
            SciFiBook book3 = new SciFiBook("Book3");
            Console.WriteLine(book3.name);
            book3.name = "Book4";
            Console.WriteLine(book3.name);

            book3.AddComments(3);
            Console.WriteLine();

            #endregion

            #region abstract Vs virtual

            #endregion

            #region constant VS readonly

            #endregion

            #region sealed

            #endregion

            #region static

            #endregion

            #region basic inheritance

            #endregion

            #region Polymorphism

            #endregion


            #region inteface

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



    }
}