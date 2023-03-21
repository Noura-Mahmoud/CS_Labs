using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math
{
    internal class Math
    {
        public static double Add(int x, int y)
        {
            return x + y;
        }
        public static int Subtract(int x, int y)
        {
            return x - y;
        }
        public static double Multiply(int x, int y)
        {
            return x * y;
        }
        public static double? Divide(int x, int y)
        {
            if (y != 0)
                return x / y;
            else return null;
        }
    }
}

