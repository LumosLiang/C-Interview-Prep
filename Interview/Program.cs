using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode;

namespace Interview
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Syntax
            Syntax();
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

            #region getter and setter
            SciFiBook book3 = new SciFiBook("Book3");
            Console.WriteLine(book3.name);
            book3.name = "Book4";
            Console.WriteLine(book3.name);

            book3.AddComments(3);
            Console.WriteLine();

            #endregion

            #region access/modifier

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

            EnumTest et1 = EnumTest.Autumn;
            EnumTest et2 = EnumTest.Summer;
            Console.WriteLine(et1);



        }

        static void Syntax()
        {
            

        }






    }
}