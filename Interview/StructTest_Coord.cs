using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    internal struct StructTest_Coord
    {

        public double X { get; set; }
        public double Y { get; set; }

        public StructTest_Coord(double x, double y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }

    }
}
