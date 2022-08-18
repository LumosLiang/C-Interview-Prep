using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Design_Type.Attributes
{
    class Student
    {
        public string Name;
        public int Age;
    }

    class Student1
    {
        private string Name;
        private int Age;

        public string GetName()
        {
            return this.Name;
        }
        public void SetName(string name)
        {
            Name = name;
        }
        public int GetAge()
        {
            return Age;
        }
        public void SetAge(int age)
        {
            if (age < 0) throw new ArgumentOutOfRangeException();
            Age = age;
        }

    }

    class Student2
    {
        private string name;
        private int age;
        
        public string Name {
            get { return name; }
            set { name = Name; }
        }

        public int Age {
            get { return age; }
            set 
            {
                if (Age < 0) throw new ArgumentOutOfRangeException();
                age = Age;
            } 
        }

    }

    class Student3
    {
        // AIP, CLR will create a backing field silently?
        public string Name { get; set; }
        // but this is not good
        public int Age { get; set; }
    }

}
