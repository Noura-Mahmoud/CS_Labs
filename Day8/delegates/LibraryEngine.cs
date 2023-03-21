using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static delegates.Delegate;

namespace delegates
{
    internal class LibraryEngine
    {
        #region case 1
        //public static void ProcessBooks(List<Book> bList, DelDT fPtr)
        //{
        //    foreach (Book B in bList)
        //    {
        //        Console.WriteLine(fPtr(B));
        //    }
        //} 
        #endregion
        #region case 2,3,4
        public static void ProcessBooks(List<Book> bList, Func<Book, string> fPtr)
        {
            foreach (Book B in bList)
            {
                Console.WriteLine(fPtr(B));
            }
        } 
        #endregion
    }
}
