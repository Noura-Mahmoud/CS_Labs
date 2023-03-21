using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates
{
    // step zero delegate declaration
    internal class Delegate
    {
        public delegate string DelDT(Book B);
        public static string bookData(Book B)
        {
            return B.ToString();
        }
    }


}
