using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Type.Basic
{
    public struct Coord
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Coord(double x, double y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }

    }

    public class PersonClass
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public PersonClass(string name, int age)
        {
            Name = name;
            Age = age;
        }
        // Other properties, methods, events...
    }


    public struct PersonStruct
    {
        public string Name;
        public int Age;
        public PersonStruct(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    class SomeRef
    {
        public int x;
    }

    struct SomeVal
    {
        public int x;
    }

    class ValueRefTypeCompare
    {
        public static void ValueTypeDemo()
        {
            SomeRef r1 = new SomeRef();
            SomeVal v1 = new SomeVal();

            r1.x = 5;
            v1.x = 5;

            Console.Write(r1.x);
            Console.Write(v1.x);

            SomeRef r2 = r1;
            SomeVal v2 = v1;

            r2.x = 10;
            v2.x = 9;

            Console.Write(r1.x);
            Console.Write(v1.x);
            Console.Write(r2.x);
            Console.Write(v2.x);

        }

    }
}


