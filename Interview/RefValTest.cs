using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{

    // Ref tells the compiler that the object is initialized before entering the function,
    // while out tells the compiler that the object will be initialized inside the function.

    // ref: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/out-parameter-modifier


    class RefValTest
    {
        public void CanPassByReferenceTest()
        {
            var book1 = new SciFiBook("book1");
            SetName_ref(ref book1, "book2");

            SciFiBook book2;
            SetName_out(out book2, "book3");
            Console.WriteLine(book2.name);

        }

        private static void SetName_out(out SciFiBook book, string new_name)
        {
            book = new SciFiBook(new_name);
        }

        private static void SetName_ref(ref SciFiBook book, string new_name)
        {
            book = new SciFiBook(new_name);
        }


        // Always, Always, Always pass by values
        public void PassByValuesTest()
        {
            var book1 = new SciFiBook("book1");
            SetName_1(book1, "new book1");
            Console.WriteLine(book1.name);
            SetName_2(book1, "new book2");
            Console.WriteLine(book1.name);
        }

        private static void SetName_2(SciFiBook book, string new_name)
        {
            book = new SciFiBook(new_name);
        }

        private static void SetName_1(SciFiBook book, string new_name)
        {
            book.name = new_name;
        }

        public void TwoVarCanReferenceSameObject()
        {
            var book1 = new SciFiBook("book1");
            var book2 = book1;

            Console.WriteLine(book2.name);
            Console.WriteLine(ReferenceEquals(book1, book2));

            book2.name = "book2";
            Console.WriteLine(book1.name);
            Console.WriteLine(ReferenceEquals(book1, book2));
            Console.WriteLine();
        }
    }
}
