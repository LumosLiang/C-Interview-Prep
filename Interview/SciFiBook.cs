using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{

    class SciFiBook : BookBase, IBook
    {


        // defining property
        public float price { get;  private set; }

        public override string name 
        {
            get
            {
                return this.name;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    name = value;
                }
            }
        }

        readonly List<string> comments;

        public float GetPrice()
        {
            return this.price;
        }

        public void SetPirce(float newprice)
        {
            price = newprice;
        }

        // method overloading 

        public void AddComments(string comment)
        {
            this.comments.Add(comment);
        }

        public void AddComments(int comment)
        {
            switch (comment) 
            {
                case int i when i >= 90:
                    this.comments.Add("brilliant");
                    break;
                case int i when i >= 80 :
                    this.comments.Add("good");
                    break;
                case int i when i >= 70:
                    this.comments.Add("average");
                    break;
                default:
                    this.comments.Add("No comment");
                    break;
            }   
        }

        public override string GetWriter()
        {
            return this.writer;
        }

        // constructor
        public SciFiBook(string name, float price = 0)
        {
            this.name = name;
            this.price = price;
            this.comments = new List<string>();
        }

        public SciFiBook(string name, string writer)
        {
            this.name = name;
            this.writer = writer;
            this.comments = new List<string>();
        }




    }
}
