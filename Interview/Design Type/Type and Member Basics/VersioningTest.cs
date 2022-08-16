using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Design_Type.Type_and_Member_Basics
{
    public class Phone
    {
        public string name { get; set; }
        public void Dial()
        {
            Console.WriteLine(name);
            EstablishConnection();
        }

        public virtual void EstablishConnection()
        {
            Console.WriteLine("Phone.EstablishConnection");
        }
    }


    public class BetterPhone: Phone
    {
        //public void Dial()
        //{
        //    Console.WriteLine(name);
        //    EstablishConnection();
        //}

        //public void EstablishConnection()
        //{
        //    Console.WriteLine("Phone.EstablishConnection");
        //}

        public new void Dial()
        {
            Console.WriteLine("BetterPhone.Dial");
            EstablishConnection();
        }
        public override void EstablishConnection()
        {
            Console.WriteLine("BetterPhone.EstablishConnection");
        }
    }
}  
