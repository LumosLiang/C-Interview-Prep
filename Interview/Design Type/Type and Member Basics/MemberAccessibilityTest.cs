using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Design_Type.Type_and_Member_Basics
{
    class MemberAccessibilityTest { 
        class Employee
        {
            protected virtual void GetEmployee()
            {
                Console.WriteLine("This is a Employee");
            }

            protected virtual void GetMoney()
            {
                Console.WriteLine(1000);
            }
        }

        class Manager: Employee
        {
            // C# override method must have the same accessbility
            protected override void GetEmployee()
            {
                Console.WriteLine("This is a Manager");
            }

            private new void GetMoney()
            {
                Console.WriteLine(100000);
            }
        }
    }
}
