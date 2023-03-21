// See https://aka.ms/new-console-template for more information
using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;


//HiringDate d = new HiringDate(1,2,2022);
//Employee emp = new Employee(1, "secretary", 2000, "M", d);
//Console.WriteLine(emp);
 
Employee[] EmpArr = new Employee[3];
int id;
HiringDate hiring = new HiringDate();
decimal salary;
string level, gender;
byte genderFlag = 1;
byte levelFlag = 1;
for (int i = 0;i < 3; i++)
{
    Console.WriteLine($"\nEnter data of employee {i + 1}");
    Console.WriteLine("please enter the ID");
    id = int.Parse(Console.ReadLine());
    Console.WriteLine("please enter the day of hiring date");
    hiring.setDay(byte.Parse(Console.ReadLine()));
    Console.WriteLine("please enter the month of hiring date");
    hiring.setMonth(byte.Parse(Console.ReadLine()));
    Console.WriteLine("please enter the year of hiring date");
    hiring.setYear(int.Parse(Console.ReadLine()));
    Console.WriteLine("please enter the salary");
    salary = decimal.Parse(Console.ReadLine());

    do
    {
        Console.WriteLine("please enter the security level: guest, Developer, secretary, DBA or all");
        level = Console.ReadLine();
        if (level == "guest" || level == "Developer" || level == "secretary" || level == "DBA" || level == "all")
            levelFlag = 0;
    }
    while (levelFlag == 1);

    do
    {
        Console.WriteLine("please enter the gender");
        gender = Console.ReadLine();
        if (gender == "M" || gender == "F")
            genderFlag = 0;
    }
    while (genderFlag == 1);

    EmpArr[i] = new Employee(id, level, salary, gender, hiring);
    Console.WriteLine(EmpArr[i]);
}



public enum Gender { M, F }

[Flags]
enum Permission : byte
{
    guest = 0x01, Developer = 0x02, secretary = 0x03, DBA = 0x04, all = 0x0F
}





