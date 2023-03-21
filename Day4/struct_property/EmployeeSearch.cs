// See https://aka.ms/new-console-template for more information
//empS[1];  

struct EmployeeSearch
{
     public int size; public int[] NationalIDs; public Employee[] Employees;
    //Searching By NationalID , Hiring Dates , Name (return Employee(s) Object)
    public EmployeeSearch(int _Size)
    {
        size = _Size;
        NationalIDs = new int[size];
        Employees = new Employee[size];
    }
    public Employee this[int NationalID]
    {
        get
        {
            for (int i = 0; i < size; i++)
                if (Employees[i].ID == NationalID)
                    return Employees[i];
            return default;
        }
    }
    public Employee this[HiringDate hireDate]
    {
        get
        {
            for (int i = 0; i < size; i++)
                if (Employees[i].HireDate.Day == hireDate.Day && Employees[i].HireDate.Month == hireDate.Month && Employees[i].HireDate.Years == hireDate.Years)
                    return Employees[i];
            return default;
        }
    }

    public Employee this[string Name]
    {
        get
        {
            for (int i = 0; i < size; i++)
                if (Employees[i].Name == Name)
                    return Employees[i];
            return default;
        }
    }
}





