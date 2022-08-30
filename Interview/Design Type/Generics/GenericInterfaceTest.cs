using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interview.Type.Basic;

namespace Interview.Design_Type.Generics
{

    interface IGenericInterfaceTest<T> : IEnumerator
    {
        T MemberTest { get; }
    }

    internal sealed class StringEnumerator : IGenericInterfaceTest<string>
    {
        public string MemberTest => throw new NotImplementedException();

        public object Current => throw new NotImplementedException();

        public bool MoveNext() => throw new NotImplementedException();
  
        public void Reset()
        {
            throw new NotImplementedException();
        }
    }

}
