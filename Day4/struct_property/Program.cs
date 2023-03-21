// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Tracing;
using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;


HiringDate d = new HiringDate(1, 2, 2022);
Employee emp = new Employee(1,"hamada", "secretary", 2000, "M", d);
//Console.WriteLine(emp);
EmployeeSearch empS = new(3);
empS.Employees[0] = emp;
Employee emp1 = new();
emp1 = empS[d];
Console.WriteLine(emp1);



Employee[] EmpArr = new Employee[1];
int id;
HiringDate hiring = new HiringDate();
decimal salary;
string level, gender, name;
byte genderFlag = 1;
byte levelFlag = 1;
byte day, month;
int year;
for (int i = 0; i < EmpArr.Length; i++)
{
    Console.WriteLine($"\nEnter data of employee {i + 1}");
    do
    {
        Console.WriteLine("Please enter the ID");
    }
    while (int.TryParse(Console.ReadLine(), out id) == false);
    do
    {
        Console.WriteLine("Please enter the name");
        name = Console.ReadLine();
    }
    while (!IsAllAlphabetic(name));
    do
    {
        Console.WriteLine("Please enter the day of hiring date");
    }
    while ((byte.TryParse(Console.ReadLine(), out day) == false)&& day <32 && day>1);
    do
    {
        Console.WriteLine("Please enter the month of hiring date");
        hiring.Day = day;
    }
    while ((byte.TryParse(Console.ReadLine(), out month) == false) && month>0 && month<13);
    do
    {
        Console.WriteLine("Please enter the year of hiring date");
        hiring.Month = month;
    }
    while (int.TryParse(Console.ReadLine(), out year) == false);
    do
    {
        Console.WriteLine("Please enter the salary");
        hiring.Years = year;
    }
    while (decimal.TryParse(Console.ReadLine(), out salary) == false);
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

    EmpArr[i] = new Employee(id,name, level, salary, gender, hiring);
    Console.WriteLine(EmpArr[i]);
}

bool IsAllAlphabetic(string value)
{
    foreach (char c in value)
    {
        if (!char.IsLetter(c))
            return false;
    }

    return true;
}

public enum Gender { M, F }

[Flags]
enum Permission : byte
{
    guest = 0x01, Developer = 0x02, secretary = 0x03, DBA = 0x04, all = 0x0F
}





