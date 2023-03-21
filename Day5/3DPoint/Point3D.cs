using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DPoint
{
    internal class Point3D : Point2D
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public Point3D(int _X = 0, int _Y = 0, int _Z = 0) : base(_X, _Y)
        {
            Z = _Z;
        }

        public override string ToString()
        {
            return $" Point Coordinates:   ({X},{Y},{Z})";
        }

        public static bool operator == (Point3D p1, Point3D p2)
        {
            if ((p1.X == p2.X) && (p1.Y == p2.Y)&&(p1.Z == p2.Z))
            return true;
            else return false;
        }

        public static bool operator != (Point3D p1, Point3D p2)
        {
             return !(p1==p2);
        }




        //// copy ctor
        //public Point3D(Point3D OldP)
        //{
        //    X = OldP.X;
        //    Y = OldP.Y;
        //    Z = OldP.Z;
        //}

    }
}
