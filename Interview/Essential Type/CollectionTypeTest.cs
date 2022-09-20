using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Interview.Type
{
   
    class CollectionTypeTest
    {


        internal void ArrayInitialize()
        {

            // initialize a 1-d array

            int[] array = new int[5];
            int[] array_a = new int[5] { 1, 2, 3, 4, 5 };
            int[] array_dyn = new int[] { };
            

            int[] array_b = new int[3] { 1,2,3};
            array_b.Append(3);

            Console.WriteLine(array_b);

            // multi-d array
            int[,] array_twod_one = new int[,] { { 1 }, { 2 } };
            int[,] array_twod_two = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            int[,,] array_threed = new int[,,] { { { 1, 1 }, { 1, 1 } }, { { 1, 1 }, { 1, 1 } } };

            Console.WriteLine(array_twod_two);
            Console.WriteLine(array_threed);

            // Jagged array
            int[][] jagged_arr = new int[2][];
            int[][] jagged_arr2 = new int[][]
            {
                new int[]{ 1,2},
                new int[]{ 4,5,6},
                new int[]{7,8,9,10},
            };
            Console.WriteLine(jagged_arr2);

            // multi-array + jagged

            int[][,] c = new int[5][,];
            c[0] = new int[2,2] { { 1,2},{3,4 } };
            Console.ReadLine();

            string[,] arrayString = new string[2, 3] { { "1","2","3"}, { "1", "2", "3" } };
            string[][] arrayStringJagged = new string[2][];
            for (int i = 0; i < arrayStringJagged.Length; i++) 
            {
                arrayStringJagged[i] = new string[] { "1","2","3"};
            }

            // Array slice

   
            
        }

        internal void ListInitialize()
        {
            
            // initialize a list
            List<string> l = new List<string>();
            List<string> l1 = new List<string>() { "This", "is", "shit" };
            List<string> l2 = new List<string> { "This", "is", "shit" };
            List<string> l3 = new List<string>(new string[] { "This", "is", "shit" });
            List<string> l4 = new List<string>(3) { "this","is","shit","?"};
            List<string> l5 = new List<string>(l3);

            string[] input = { "Brachiosaurus",
                           "Amargasaurus",
                           "Mamenchisaurus" };

            List<string> dinosaurs = new List<string>(input);

            dinosaurs.Add("12");

            Console.WriteLine(l);
            Console.WriteLine(l1);
            Console.WriteLine(l2);
            Console.WriteLine(l3);
            Console.WriteLine(l4);
            Console.WriteLine(l5);

            List<Object> contain_all = new List<object> { "", 1, 'a', new int[] { 1, 2, 3 } };
            Console.WriteLine(contain_all);

            // LIST SLICE
        }

        internal void HashtableInitialize()
        {

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
        }

        internal void DictInitialize()
        {
            // initialize a Dict
            Dictionary<string, string> dict_test = new Dictionary<string, string>
            {
                { "txt", "notepad.exe"},
                { "bmp", "paint.exe"},
                { "dib", "paint.exe"},
            };

            Dictionary<int, List<int>> dict_test1 = new Dictionary<int, List<int>>();
            var member = dict_test["txt"];
        }

        internal void TupleInitialize()
        {

            (double, int) t = (4.5, 3);
            Console.WriteLine(t.GetType());
        }

        internal void HashSetInitialize()
        {
            HashSet<int> evennum = new HashSet<int>();
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0) evennum.Add(i);
            }
            Console.WriteLine(evennum);

        }

        internal void QueueInitialize()
        {
            Queue<int> q = new Queue<int>();

            Console.WriteLine(q);

        }

        internal void DequeueInitialize()
        {
            LinkedList<int> dq = new LinkedList<int>();

            Console.WriteLine(dq);

        }

    }
}



