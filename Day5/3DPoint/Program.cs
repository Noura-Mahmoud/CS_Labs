

// See https://aka.ms/new-console-template for more information
using _3DPoint;

Point3D P = new Point3D(10, 10, 10);
Console.WriteLine(P.ToString());
//Console.WriteLine((string)P); //error can't convert

Point3D P1 = new();
Point3D P2 = new();

#region for of 2 points
//for (int i = 0; i < 2; i++)
//{
//    int x, y, z;
//    do
//    {
//        Console.WriteLine($"Enter X position of point {i + 1}");
//    }
//    while (int.TryParse(Console.ReadLine(), out x) == false);
//    P1.X = x;
//    do
//    {
//        Console.WriteLine($"Enter Y position of point {i + 1}");
//    }
//    while (int.TryParse(Console.ReadLine(), out y) == false);
//    P1.Y = y;
//    do
//    {
//        Console.WriteLine($"Enter Z position of point {i + 1}");
//    }
//    while (int.TryParse(Console.ReadLine(), out z) == false);
//    P1.Z = z;
//}
#endregion

#region point1
int x, y, z;
do
{
    Console.WriteLine($"Enter X position of point 1");
}
while (int.TryParse(Console.ReadLine(), out x) == false);
P1.X = x;
try
{
    Console.WriteLine($"Enter Y position of point 1");
    y = int.Parse(Console.ReadLine());
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine("you entered unvalid data");
    y = 0;
}
P1.Y = y;
try
{
    Console.WriteLine($"Enter Z position of point 1");
    z = Convert.ToInt32(Console.ReadLine());
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine("you entered unvalid data");
    z = 0;
}
P1.Z = z;
#endregion

#region point2
do
{
    Console.WriteLine($"Enter X position of point 2");
}
while (int.TryParse(Console.ReadLine(), out x) == false);
P2.X = x;
do
{
    Console.WriteLine($"Enter Y position of point 2");
}
while (int.TryParse(Console.ReadLine(), out y) == false);
P2.Y = y;
do
{
    Console.WriteLine($"Enter Z position of point 2");
}
while (int.TryParse(Console.ReadLine(), out z) == false);
P2.Z = z;
#endregion


Console.WriteLine($"P1 == P2 { P1 == P2}");
Console.WriteLine($"P1 != P2 { P1 != P2}");

