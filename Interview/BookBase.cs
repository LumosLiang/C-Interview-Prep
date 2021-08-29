namespace Interview
{
    internal abstract class BookBase
    {

        // defining a field
        public abstract string name { get; set; }

        internal string writer;

        public abstract string GetWriter();
    }
}