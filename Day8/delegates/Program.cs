using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using static delegates.Delegate;

namespace delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // make object of book
            Book b = new Book("abcd", "Title", new string[] { "Ali", "Noha" }, new DateTime(DateTime.Now.Year), 12.35m);
            #region first case
            ////step 1,2 declare object and assign function
            //DelDT fPtr = new DelDT(bookData);
            ////change the function of delegate
            //fPtr = BookFunctions.GetTitle;
            //LibraryEngine.ProcessBooks(new List<Book> { b, b }, fPtr);
            #endregion
            #region second case
            ////Public delegate Tresult Func<out Tresult, t1>(t1);
            //Func<Book, string> bookProcess;
            //bookProcess = BookFunctions.GetAuthors;
            //LibraryEngine.ProcessBooks(new List<Book> { b, b }, bookProcess);  
            #endregion
            #region third case ##
            //DelDT fPtr02 = new DelDT(delegate (Book b)
            //{
            //    return b.ISBN;
            //});
            //Console.WriteLine(fPtr02(b)); 
            #endregion
            #region third case #1
            //DelDT fPtr = delegate (Book B) { return B.Title; };
            //Console.WriteLine(fPtr(b));
            #endregion
            #region third case #2
            //Func<Book, string> bookProcess= BookFunctions.GetAuthors;
            //Action<List<Book>, Func<Book, string>> fPtr01 = delegate ( List<Book> bList, Func< Book, string> fPtr) {
            //    foreach (Book B in bList)
            //    {
            //        Console.WriteLine(fPtr(B));
            //    }
            //};
            //fPtr01(new List<Book> { b, b }, bookProcess);
            #endregion
            #region fourth case
            DelDT fPtr02;
            fPtr02 = (Book b) => { return b.PublicationDate.ToString(); };
            Console.WriteLine(fPtr02(b)); 
            #endregion

        }
    }
}