// See https://aka.ms/new-console-template for more information

using System.Drawing;
using System.Numerics;
using System.Runtime.CompilerServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

Duration d1 = new Duration(1, 2, 3);
Console.WriteLine( d1.Equals(null));
Console.WriteLine( d1.Equals(new Duration(1,2,3)));

Duration d2 = new Duration(7800);
Console.WriteLine( d1);
Console.WriteLine( d2); 
Duration d3 = d1 + d2;
Console.WriteLine($"d1+d2 -> {d3} ");
d3 = d1 + 200;
Console.WriteLine($"d1+ 200 -> {d3}");
d3 = 200 + d1;
Console.WriteLine($"200+d1 -> {d3}");
Console.WriteLine($"d2 -> {d2}");
d3 = --d2;
Console.WriteLine($"--d2 -> {d3}");
d3 = d2++;
Console.WriteLine($"d2++ -> {d3}");
Console.WriteLine($"d2 -> {d2}");
d2 -= d1;
Console.WriteLine($"d2-= d1 -> {d1}");
bool m = d1 > d2;
Console.WriteLine($"d1>d2 -> {m} ");
m = d1 <= d2;
Console.WriteLine($"d1<= d2 -> {m}");
DateTime Obj = (DateTime)d1;
Console.WriteLine($"DateTime {Obj.ToString()}");

if (d1)
    Console.WriteLine( "true");
else 
    Console.WriteLine("false");



class Duration
{
    int hours;
    int minutes;
    int seconds;
    public int Hours { get { return hours; } set { hours = value; } }
    public int Minutes { get { return minutes; } set { minutes = value; } }
    public int Seconds { get { return seconds; } set { seconds = value; } }

    public Duration(int hours, int minutes, int seconds)
    {
        this.hours = hours;
        this.minutes = minutes;
        this.seconds = seconds;
    }

    public Duration(Duration OldD)
    {
        hours = OldD.Hours;
        minutes = OldD.Minutes;
        seconds = OldD.Seconds;
    }

    //public Duration(int time) { this.hours = time / 3600; this.minutes = (time - hours * 3600) / 60; this.seconds = (time - hours * 3600 - minutes * 60); }
    public Duration(int time) { this.hours = time / 3600; this.minutes = (time/60) % 60; this.seconds = (time % 60); }
    public override string ToString()
    {

        return $"Hours: {hours}, Minutes :{minutes}, Seconds :{seconds}";
    }

    public override bool Equals(object obj)
    {
        if (obj == null)
            return false;
        else
        {
            Duration obj1 = obj as Duration;
            return ((obj1.Hours == this.hours) && (obj1.Minutes == this.minutes) && (obj1.Seconds == this.Seconds));
        }
    }

    public static Duration operator +(Duration d1, Duration d2)
    {
        return new Duration(d1.Hours + d2.Hours, d1.Minutes + d2.Minutes, d1.Seconds + d2.Seconds);
    }
    public static Duration operator -(Duration d1, Duration d2)
    {
        return new Duration(d1.Hours - d2.Hours, d1.Minutes - d2.Minutes, d1.Seconds - d2.Seconds);
    }
    public static Duration operator +(Duration d1, int d2)
    {
        int t = d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds + d2;
        return new Duration(t/3600, (t/60) %60 , t%60);
    }

    public static Duration operator +(int d1, Duration d2)
    {
        int t = d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds + d1;
        return new Duration(t / 3600, (t / 60) % 60, t % 60);
    }

    //public static Duration operator ++(Duration d)
    //{
    //    return new Duration(d.Hours, d.Minutes+1, d.Seconds);    
    //}
    public static Duration operator ++(Duration d)
    {
        return new(d.Hours, (d.Minutes + 1) , d.Seconds);
    }

    //public static Duration operator --(Duration d)
    //{
    //    return new Duration(d.Hours, d.Minutes- 1, d.Seconds);
    //}

    public static Duration operator --(Duration d)
    {
        return new(d.Hours, (d.Minutes - 1), d.Seconds);
    }

    public static bool operator > (Duration d1, Duration d2)
    {
        return ((d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds) > (d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds));
    }
    public static bool operator <(Duration d1, Duration d2)
    {
        return ((d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds) < (d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds));
    }
    public static bool operator >= (Duration d1, Duration d2)
    {
        int t1 = d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds;
        int t2 = d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds;
        return ((t1 > t2)|| (t1 == t2));
    }
    public static bool operator <= (Duration d1, Duration d2)
    {
        int t1 = d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds;
        int t2 = d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds;
        return ((t1 < t2) || (t1 == t2));
    }

    public static bool operator true(Duration d)
    {
        //if (d is not null)
        //    return true;
        //else
        //    return false;
        if ((d.Hours == 0) && (d.Minutes == 0) && (d.Seconds == 0))
            return false;
        else
            return true;
    }

    public static bool operator false(Duration d)
    {
        //if (d is null)
        //    return true;
        //else
        //    return false;
       
        if ((d.Hours == 0) && (d.Minutes== 0) && (d.Seconds == 0))
            return true;
        else
            return false;
    }

    public static explicit operator DateTime(Duration d)  // explicit byte to digit conversion operator
    {
        DateTime moment = new System.DateTime();
        return new DateTime(moment.Year, moment.Month, moment.Day, d.Hours, d.Minutes, d.Seconds);
    }
}