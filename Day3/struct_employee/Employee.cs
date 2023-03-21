// See https://aka.ms/new-console-template for more information
struct Employee
{
    int ID;
    Permission securityLevel;
    decimal salary;
    HiringDate hireDate;
    Gender Gender;

    public Employee( int _id, string _securityLevel, decimal _salary, string _gender, HiringDate _hireDate)
    {
        ID = _id;
        securityLevel = (Permission)Enum.Parse(typeof(Permission), _securityLevel);
        salary = _salary;
        Gender = (Gender)Enum.Parse(typeof(Gender), _gender);
        hireDate = _hireDate;
    }

    public override string ToString()
    {
        return $"ID: {ID} \nsecurityLevel: {securityLevel} \nSalary: {string.Format("{0:C}", salary)}\nGender: {Gender} \nHire date: {hireDate}";
    }

    public int getID()
    {
        return ID;
    }

    public void setID(int _ID)
    {
        ID = _ID;
    }

    public void setSalary(int _Salary)
    {
        salary = _Salary;
    }

    public decimal getSalary()
    {
        return salary;
    }

    public void setSecurityLevel(Permission _securityLevel)
    {
        securityLevel = _securityLevel;
    }

    public Permission getSecurityLevel()
    {
        return securityLevel;
    }

    public void setSecurityLevel(HiringDate _hireDate)
    {
        hireDate = _hireDate;
    }

    public HiringDate getHireDate()
    {
        return hireDate;
    }

    public void setGender(Gender _Gender)
    {
        Gender = _Gender;
    }

    public Gender getGender()
    {
        return Gender;
    }

}





