internal class Point2D
{
    public int X { get; set; }
    public int Y { get; set; }
    public Point2D(int _X = 0, int _Y = 0)
    {
        X = _X;
        Y = _Y;
    }

    // copy ctor
    public Point2D(Point2D OldP)
    {
        X = OldP.X;
        Y = OldP.Y;
    }

    //#region Operator overloading
    /////C# operator overloading must be static method
    /////non overloadable operators : = , [] , ! , new , . , => , -> ,....
    /////compound operators (+= , -= ,... ) supported by default if original operator is implemented

    //public static Point operator +(Point Left, Point Right)
    //{
    //    return new Point()
    //    {
    //        X = (Left?.X ?? 0) + (Right?.X ?? 0),
    //        Y = (Left?.Y ?? 0) + (Right?.Y ?? 0)
    //    };
    //}

    //public static Point operator +(Point Left, int Right)
    //{
    //    return new Point()
    //    {
    //        X = (Left?.X ?? 0) + Right,
    //        Y = (Left?.Y ?? 0) + Right
    //    };
    //}
    //public static Point operator ++(Point P)
    //{
    //    return new()
    //    {
    //        X = P.X + 1,
    //        Y = P.Y + 1
    //    };
    //}

    //public static bool operator ==(Point Left, Point Right)
    //{
    //    if ((Left != null) && (Right != null))
    //        return (Left.X == Right.X) && (Left.Y == Right.Y);
    //    return false;
    //}

    //public static bool operator !=(Point Left, Point Right)
    //{
    //    throw new NotImplementedException();
    //}

    //public static explicit operator string(Point P)
    //{
    //    return P.ToString();
    //}

    //public static /*implicit*/ explicit operator int(Point P)
    //{
    //    return (int)(Math.Sqrt(P.X * P.X) + Math.Sqrt(P.Y * P.Y));
    //}

    //#endregion


    public override string ToString()
    {
        return $"({X},{Y})";
    }

}