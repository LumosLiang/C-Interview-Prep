using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Interview.Essential_Type.ArrayDemo
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

            // list slice
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

        // Generics
        internal void DictInitialize()
        {
            // initialize a Dict
            Dictionary<string, string> dict_test = new Dictionary<string, string>
            {
                { "txt", "notepad.exe"},
                { "bmp", "paint.exe"},
                { "dib", "paint.exe"},
            };

            //Dictionary<int, List<int>> dict_test1 = new Dictionary<int, List<int>>();
            
            // access
            var member = dict_test["txt"];

            // add
            dict_test.Add("csv", "Excel.exe");

            // remove key
            dict_test.Remove("txt");

            foreach (var item in dict_test)
            {
                Console.WriteLine((item.Key, item.Value));
            }
        }

        // Tuple & ValueTuple
        internal void TupleInitialize()
        {
            // Tuple
            Tuple<int, int> t1 = new Tuple<int, int>(1,2);
            var t2 = Tuple.Create(1,2,4);
            var t3 = Tuple.Create("1", 2, true);

            // ValueTuple
            var vt = ValueTuple.Create("ters","123");
            (double, int) t = (4.5, 3);
            Console.WriteLine(t.GetType());

            // Access
            Console.WriteLine(vt.Item1);
            Console.WriteLine(vt.Item2);
            
        }

        internal void HashSetInitialize()
        {
            HashSet<int> set = new HashSet<int>();
            SortedSet<int> setSorted = new SortedSet<int>();

            for (int i = 0; i < 10; i++)
            {
                set.Add(1);
            }
            Console.WriteLine(set);
            Console.WriteLine(set.Count);

            // Typical
            set.Add(2);
            var b = set.Remove(3);
            Console.Write(set.Contains(3));
            set.UnionWith(new int[] { 2,3,45,3});

            setSorted.UnionWith(set);

            foreach (var item in setSorted)
                Console.WriteLine(item);
        }

        internal void StackInitialize()
        {
            Stack<int> s = new Stack<int>();

            // Typical methods
            Console.WriteLine(s.Count);
            s.Push(1);
            s.Pop();
            s.Push(2);
            s.Peek();

            // LOOP
            foreach (var item in s)
                Console.WriteLine(item);
            // no indexing
            //for (int i = 0; i < s.Count; i++)
            //    Console.WriteLine(s[i]);
        }


        internal void QueueInitialize()
        {
            Queue<int> q = new Queue<int>();

            // Typical methods
            Console.WriteLine(q.Count);
            q.Enqueue(1);
            q.Dequeue();
            q.Enqueue(2);
            q.Peek();

            foreach (var item in q)
                Console.WriteLine(item);
        }

        internal void DequeueInitialize()
        {
            LinkedList<int> dq = new LinkedList<int>();
            
            Console.WriteLine(dq.Count);

            // add first, add last
            dq.AddFirst(1);
            dq.AddLast(2);

            // pop first, pop last
            dq.RemoveFirst();
            dq.RemoveLast();

            // Get the first and last one
            Console.WriteLine(dq.First);
            Console.WriteLine(dq.Last);

            // Others
            dq.AddAfter(dq.First, 11);
            dq.AddBefore(dq.Last, 22);
        }

    }
}



