using Delegate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Delegate
{
    public delegate string DelDT(Book B);
    internal class Delegate
    {
        public static string bookData(Book B)
        {
            return B.ToString();
        }
    }
}

