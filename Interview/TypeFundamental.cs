using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    class TypeFundamental: Object
    {

        public static void CastingTest()
        {
            Object o = new Employee();
            Employee e = (Employee) o;


            Object o1 = new Object();
            Employee e1 = (Employee)o;

            Manager m = new Manager();
            PromoteEmployee(m);

            //DateTime newYears = new DateTime(2020, 8, 2);
            //PromoteEmployee(newYears);

        }

        static void PromoteEmployee(Object o)
        {
            // At this point, the compiler doesn't know exactly what 
            // type of object o refers to. So the compiler allows the 
            // code to compile.
            //
            // However, at run time, the CLR does know 
            // what type o refers to (each time the cast is performed) and 
            // it checks whether the object's type is Employee or any type 
            // that is derived from Employee. 

            Employee e = (Employee)o;
        }


        // is VS as
        // as has better performance
        static void IsTest()

        {
            Object o = new Object();

            Boolean b1 = o is Boolean;
            Boolean b2 = o is Employee;
            Boolean b3 = o is Object;

        }
        static void AsTest()
        {
            Object o = new Object();
            if (o is Object)
            {
                Employee e = (Employee)o;
            }

            Employee e1 = o as Employee;

            if (e1 != null)
            {
            }

            Employee e2 = o as Employee;

        }
    }


    class Employee
    {

    }

    class Manager: Employee
    {

    }

}
