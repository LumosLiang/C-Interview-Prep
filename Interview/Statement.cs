using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    class Statement
    {
        public void ForTest()
        {
            int[] onetoten = new int[] {0,1,2,3,4,5,6,7,8,9};
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(onetoten[i]);
            }
        }

        public void ForeachTest()
        {

            int[] onetoten = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            foreach (int num in onetoten)
            {
                Console.WriteLine(num);
            }
        }

        public void DoWhileTest()
        {
            int[] onetoten = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int idx = 0;
            do
            {
                Console.WriteLine(onetoten[idx]);
            }
            while (idx < onetoten.Length);

        }


        public void WhileTest()
        {
            int[] onetoten = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int idx = 0;
            while (idx < onetoten.Length)
            {
                Console.WriteLine(onetoten[idx]);
            }

        }

        public void SelectTest()
        {
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



