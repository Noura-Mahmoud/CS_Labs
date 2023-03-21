// See https://aka.ms/new-console-template for more information


using System.Reflection;
using System.Security.Cryptography;

NIC n1;
NIC n2;
n1 = NIC.SingleTonObj;
n2 = NIC.SingleTonObj;

Console.WriteLine(n1.GetHashCode());
Console.WriteLine(n2.GetHashCode());

class NIC
{
    string Manufacture;
    string MAC_Address;
    Type NICType;

    NIC(string manufacture, string mac_address, string nICType)
    {
        Console.WriteLine("Ctor");
        Manufacture = manufacture;
        MAC_Address = mac_address;
        NICType = (Type)Enum.Parse(typeof(Type), nICType);
    }

    public static NIC SingleTonObj { get; } = new("manu", "123.456.789", "Ethernet");

    enum Type { Ethernet , token_ring }

}

