using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Design_Type.Attributes
{
    class InitializersWithProp
    {
        public void Main()
        {
            // Object Initializers with and without parenthsis

            Student2 student1 = new Student2 (){ Name = "Yuan", Age = 30};
            Student2 student2 = new Student2 { Name = "Yuan", Age = 30 };

            // Expression
            String s = new Student2 { Name = "Yuan", Age = 30 }.ToString();

            // If a property's type implements the IEnumerable or IEnumerable<T> interface
            // Collection initializers
            Classroom cr = new Classroom { Students = { "Yuan", "Liang"} };

        }
    }


    public sealed class Classroom
    {
     
        public List<String> Students { get; set; }
        public Classroom() { }
    }

}
