using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Type.Basic
{
    public class BoxUnboxTest
    {
        public void Boxing()
        {

            int num = 123;
            Console.WriteLine(num);
            Console.WriteLine(num.GetType());

            // boxing
            object numobj = num;
            Console.WriteLine(numobj);
            Console.WriteLine(numobj.GetType());
        }

        public void Unboxing()
        {
            // boxing
            Int32 num = 32;
            object o = num;

            // unboxing
            Int16 UnboxNum = (Int16)o;
            Int32 UnboxNum2 = (Int32)o;

        }

        public void BoxUnboxPerformaceOptimize()
        {
            Int32 v = 5;            // Create an unboxed value type variable.
            Object o = v;            // o refers to a boxed Int32 containing 5.
            v = 123;                 // Changes the unboxed value to 123

            // boxing 3 times
            Console.WriteLine(v + ", " + (Int32)o); 

            // boxing 2 times
            Console.WriteLine(v + ", " + o); 

            // boxing 1 time
            Console.WriteLine(v.ToString() + ", " + o);

        }
        
        public void BoxUnboxOnToString()
        {
            //A boxing conversion makes a copy of the value being boxed 
            Coord p = new Coord(1, 1);
            Console.WriteLine(p);

            p.Change(2, 2);
            Console.WriteLine(p);

            Object o = p;
            Console.WriteLine(o);

            ((Coord)o).Change(3, 3);

            Console.WriteLine(o);
            Console.ReadKey();
        }


        public void PutIntoArray()
        {
            ArrayList arr = new ArrayList();

            Coord p = new Coord();
            for (int i = 0; i < 10; i++)
            {
                p.X = p.Y = i;
                arr.Add(p);
            }
        }

        // another boxing discussion where value type

        public void BoxUnboxOnValTypeChange()
        {

        }
    }
}
