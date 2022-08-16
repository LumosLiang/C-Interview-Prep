using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.OOP.Sample
{
    class CannotBeNegativeException : Exception
    {
        public CannotBeNegativeException(string mesage) : base(mesage) { }

    }



}
