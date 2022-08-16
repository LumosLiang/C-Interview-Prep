using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode;
using System.Collections;
using Interview.Type;
using Interview.Design_Type.Type_and_Member_Basics;
using Interview.Type.Basic;
using Interview.OOP.Sample;

namespace Interview
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Type
            // TypeTest();
            #endregion

            #region Statement 
            //StatementTest();
            #endregion

            #region TestReferenceType, ValueType  
            ValueRefTypeTest();
            #endregion

            // this is regarding type 
            #region is VS as
            // IsAsTest();
            #endregion

            //this is regarding object, instance
            #region Equals VS ==
            // EqualTest();

            #endregion

            // OOPSampleDemo();
            //Phone phone = new Phone();
            //BetterPhone BetterPhone = new BetterPhone();

            //phone.name = "Phone";
            //phone.Dial();

            //BetterPhone.name = "BetterPhone";
            //BetterPhone.Dial();

            //Phone phone = new BetterPhone();
            //// phone.name = "BetterPhone";
            //phone.Dial();
            //Console.ReadLine();

            //TypeFundamental.CastingTest();
            //Console.ReadLine();


        }

        static void OOPSampleDemo()
        {
            Demo d = new Demo();
            //d.CreateBankAccountTest();
            //d.ExceptionHandleTest();
            //d.GiftCardAccountTest();
            // d.InterestEarningAccountTest();
            d.LineOfCreditAccountTest();
        }

        static void TypeTest()
        {
            var ptt = new PrimitiveTypeTest();
            var ctt = new CollectionTypeTest();
            var ott = new OtherTypeTest();

            // ptt.StringInitialize();
            // ptt.StringBuilderInitialize();
            ctt.ArrayInitialize();
            //ctt.ListInitialize();
            //ctt.HashtableInitialize();
            //ctt.DictInitialize();
            //ctt.TupleInitialize();
            //ctt.HashSetInitialize();
            //ott.DefaultInitialize();
            //ott.NullableInitialize();
            StructTest();
            BoxUnboxTest();
            EnumTest();

        }

        static void StatementTest()
        {
            var st = new Statement();
            var o = new object();
            st.DoWhileTest();
            st.WhileTest();
            st.ForeachTest();
            st.ForTest();
            st.SelectTest();
        }

        static void ValueRefTypeTest()
        {
            var rvtest = new RefValTest();

            // rvtest.PassByValuesValTest();
            // rvtest.PassByValuesRefTest();

            // rvtest.CanPassByReferenceValTest();
            rvtest.CanPassByReferenceRefTest();
            // rvtest.TwoVarCanReferenceSameObject();
        }

        static void BoxUnboxTest()
        {
            var but = new BoxUnboxTest();
       
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
            Coord sttest = new Coord(2, 3);
            Console.WriteLine(sttest.X);

        }
    }
}