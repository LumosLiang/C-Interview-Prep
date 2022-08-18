using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Design_Type.Type_and_Member_Basics
{
    class ConstantTest
    {
        public void RefFieldChangeTest()
        {
            AType.InvalidChars[0] = 'X';
            AType.InvalidChars[1] = 'Y';
            AType.InvalidChars[2] = 'Z';


            // incorrect, it is the reference that is immutable, not the object that the field refers to.
            // AType.InvalidChars = new char[] { 'X', 'Y', 'Z' };
        }

    }

    public sealed class AType
    {
        public static readonly Char[] InvalidChars = new char[] { 'A', 'B' , 'C' };
    }


}
