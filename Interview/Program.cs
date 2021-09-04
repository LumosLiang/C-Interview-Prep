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

        static void Syntax()
        {
            // Initialize a string

            string s = "test";
            s = s + "ABC";


            // initialize a string using string builder
            StringBuilder sb = new StringBuilder("ABC", 50);
            var sb2 = new StringBuilder("EDF");
            sb2.Append("ABC");

            var empt = String.Empty;
            var empt2 = new StringBuilder();

            // initialize a 1-d array

            int[] array = new int[5];
            int[] array_a = new int[5] { 1, 2, 3, 4, 5 };
            int[] array_inf = new int[] { };
            array_inf.Append(2);

            // multi-d array
            int[,] array_2d = new int[,] { { 1},{2 } };
            int[,] array_2da = new int[3, 2] { { 1,2},{3,4 },{5,6 } };
            int[,,] array_3d = new int[,,] { { { },{ } }, { { },{ } } };

            // Jagged array
            int[][] jagged_arr = new int[2][];
            int[][] jagged_arr2 = new int[][]
            {
                new int[]{ 1,2},
                new int[]{ 4,5,6},
                new int[]{7,8,9,10},

            };

            // initialize a list

            List<string> l = new List<string>(){ "This","is","shit"};
            List<string> l1 = new List<string>{ "This", "is", "shit" };
            List<string> l2 = new List<string>(new string[] { "This", "is", "shit" });
            List<string> l3 = new List<string>
            {
                "This",
                "is",
                "shit"
            };

            Console.WriteLine(l);
            Console.WriteLine(l1);
            Console.WriteLine(l2);
            Console.WriteLine(l3);

            List<Object> contain_all = new List<object> { "", 1, 'a', new int[] { 1,2,3}};
            Console.WriteLine(contain_all);

            // initialize a Dict
            Dictionary<string, string> Dict_test = new Dictionary<string, string> 
            {
                { "txt", "notepad.exe"},
                { "bmp", "paint.exe"},
                { "dib", "paint.exe"},
            };
            var member = Dict_test["text"];

            // Initialize a hashtable

            Hashtable hashtab_string = new Hashtable()
            {
                { "txt", "notepad.exe"},
                { "bmp", "paint.exe"},
                { "dib", "paint.exe"},
            };
            var member1 = hashtab_string[1];
            var member2 = hashtab_string["text"];
            Console.WriteLine(member2);


            Hashtable hashtab_int = new Hashtable()
            {
                { 1, 2},
                { 3, 4},
                { 5, 6},
            };

            // Initialize a set

            HashSet<int> evennum = new HashSet<int>();
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0) evennum.Add(i);
            }
            Console.WriteLine(evennum);

            // Initialize a tuple

            (double, int) t = (4.5, 3);
            Console.WriteLine(t.GetType());
            Console.WriteLine(t is Tuple);

            // nullable type

            int ? nulltype_test = null;
            Console.WriteLine(nulltype_test);

            

        }


        static void statement_test()
        {

            // for
            // while
            int i = 0;
            while(i < 10)
            {
                Console.WriteLine(i);
                i++;
            }

            // do while
            int j = 0;
            do
            {
                Console.WriteLine(j);
                j++;
            }
            while (j < 10);

            // if...else if...else if...else

            // switch case
            int k = 88;
            switch (k)
            {
                case var p when p > 90:
                    Console.WriteLine("This is A");
                    break;
                case var p when p > 80:
                    Console.WriteLine("This is B");
                    break;
                case var p when p > 70:
                    Console.WriteLine("This is C");
                    break;
            }

            int l = 1;
            int sum = 0;
            switch (l)
            {
                case 1:
                    sum += 25;
                    Console.WriteLine("sum");
                    break;
            }


        }



    }
}