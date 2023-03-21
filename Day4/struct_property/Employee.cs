// See https://aka.ms/new-console-template for more information
struct Employee
{
    decimal salary;
    Permission securityLevel;
    int id;
    string name;
    HiringDate hireDate;
    Gender gender;


    public decimal Salary
    {
        set
        { salary = value;}
        get
        { return salary; }
    }
    public Permission SecurityLevel
    {
        set
        { securityLevel = value; }
        get
        { return securityLevel; }
    }
    public int ID
    {
        set
        { id = value; }
        get
        { return id; }
    }
    public string Name
    {
        set
        { name = value; }
        get
        { return name; }
    }
    public HiringDate HireDate
    {
        set
        { hireDate = value; }
        get
        { return hireDate; }
    }

    public Gender Gender
    {
        set
        { gender = value; }
        get
        { return gender; }
    }

    public Employee( int _id,string _name, string _securityLevel, decimal _salary, string _gender, HiringDate _hireDate)
    {
        id = _id;
        name = _name;
        securityLevel = (Permission)Enum.Parse(typeof(Permission), _securityLevel);
        salary = _salary;
        gender = (Gender)Enum.Parse(typeof(Gender), _gender);
        hireDate = _hireDate;
    }

    public override string ToString()
    {
        return $"ID: {ID} \nsecurityLevel: {securityLevel} \nSalary: {string.Format("{0:C}", salary)}\nGender: {Gender} \nHire date: {hireDate}";
    }

}





