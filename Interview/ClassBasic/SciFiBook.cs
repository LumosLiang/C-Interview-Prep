using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    class SciFiBook 
    {

        //        Fields
        //        Constants
        //        Properties
        //        Methods
        //        Constructors
        //        Events

        private string name;
        
        internal string Name 
        {
            get { return name; }
            set { name = value; } 
        }

        //internal string Name{get;} this is readonly

        internal readonly string Writer;

        internal double Price { get; private set; }
        internal string TimeDimension { get; }
        internal const string Category = "Science Fiction";

      

        internal SciFiBook(string name): this(name, string.Empty)
        { 
        }

        internal SciFiBook(string name, string writer): this(name, writer, string.Empty, default)
        {
        }

        internal SciFiBook(string name, string writer, string timedimension, double price)
        {
            this.name = name;
            Writer = writer;
            TimeDimension = timedimension;
            Price = price;
        }

        internal void SetPrice(double price)
        {
            Price = price;
        }
    }
}
