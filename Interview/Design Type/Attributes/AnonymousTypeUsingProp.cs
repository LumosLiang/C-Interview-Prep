using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Design_Type.Attributes
{
    class AnonymousTypeUsingProp
    {
        public AnonymousTypeUsingProp() {
            var o = new { Name = "Liang", Age = "30"};
        }
    }
}
