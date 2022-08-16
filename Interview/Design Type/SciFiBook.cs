using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.OOP.Basic
{
    class SciFiBook 
    {

        //Fields
        //Constants
        //Properties
        //Methods
        //Constructors
        //Events
        //Finalizers
        //Indexers
        //Operators
        //Nested Types

        // private string name;
        
        internal string Name 
        {
            get; set; 
        }

        //internal string Name{get;} this is readonly

        internal readonly string Writer;

        internal double Price { get; private set; }
        internal string TimeDimension { get; }
        internal const string Category = "Science Fiction";

        internal SciFiBook()
        {

        }

        internal SciFiBook(string name): this()
        {
            Name = name;
        }

        internal SciFiBook(string name, string writer): this(name)
        {
            Writer = writer;
        }

        internal SciFiBook(string name, string writer, string timedimension, double price) : this(name, writer)
        {
            TimeDimension = timedimension;
            Price = price;
        }

        internal void SetPrice(double price)
        {
            Price = price;
        }
    }
}
