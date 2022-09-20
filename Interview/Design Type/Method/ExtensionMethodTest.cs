using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Design_Type.Method
{

    public static class StringBuilderExtension
    {
        public static Int32 IndexOf(this StringBuilder sb, char target)
        {
            for (int i = 0; i < sb.Length; i++)
            {
                if (sb[i] == target) return i;
            }
            return -1;
        }
    }

    class ExtensionMethodTest
    {
        public static void TestExtensionMethod()
        {
            var item = new StringBuilder("abcdefg");
            item.Replace('a', '!').IndexOf('!');
        }
        
    }
}
