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
            // unboxing
            object obj2 = "stringtest";
            int num2 = (int)obj2;
            string str = (string)obj2;

            Console.WriteLine("unboxing to int {0} and to string {1}", num2, str);
        }

        public void BoxUnboxOnToString()
        {
            //A boxing conversion makes a copy of the value being boxed 
            Coord st = new Coord(1, 1);
            object sto = st;
            st.X = 2;
            Console.WriteLine(st.X);
            Console.WriteLine(((Coord)sto).X);
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
