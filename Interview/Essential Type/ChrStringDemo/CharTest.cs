using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Essential_Type.ChrStringDemo
{
    public class CharTest
    {
        public void CharBasic()
        {
            Console.WriteLine(char.MinValue); // '\u0'
            Console.WriteLine(char.MaxValue); // '\uffff'
            char charMax = '\uffff';
            Console.WriteLine(charMax);

            char c = 'a';

            Console.WriteLine((char.GetNumericValue(c), Char.IsNumber(c), Char.IsDigit(c), Char.IsLetter(c)));

            Console.WriteLine(Char.GetNumericValue(charMax));
        }

        public static void CharConvert()
        {
            Char c;
            Int32 n;

            // Convert number <-> character using C# casting
            c = (Char)65;
            Console.WriteLine(c);                  // Displays "A"

            n = (Int32)c;
            Console.WriteLine(n);                  // Displays "65"

            c = unchecked((Char)(65536 + 65));
            Console.WriteLine(c);                  // Displays "A"



            // Convert number <-> character using Convert
            c = Convert.ToChar(65);
            
            Console.WriteLine(c);                  // Displays "A"

            n = Convert.ToInt32(c);
            Console.WriteLine(n);                  // Displays "65" 


            // This demonstrates Convert's range checking
            try
            {
                c = Convert.ToChar(70000);          // Too big for 16-bits
                Console.WriteLine(c);               // Doesn't execute
            }
            catch (OverflowException)
            {
                Console.WriteLine("Can't convert 70000 to a Char.");
            }


            // Convert number <-> character using IConvertible
            c = ((IConvertible)65).ToChar(null);
            Console.WriteLine(c);                  // Displays "A"

            n = ((IConvertible)c).ToInt32(null);
            Console.WriteLine(n);                  // Displays "65"
        }

    }
}
