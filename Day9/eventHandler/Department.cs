using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eventHandler
{
    internal class Department
    {
        public int DeptID { get; set; }
        public string DeptName { get; set; }

        List<Employee> Staff = new List<Employee>();
        public void AddStaff(Employee E)
        {
            if (E != null)
            {
                if (!Staff.Contains(E))
                {
                    Staff.Add(E);
                }
                E.EmployeeLayOff += RemoveStaff;
                ///Try Register for EmployeeLayOff Event Here
            }
        }
        ///CallBackMethod
        //2) define call back method matching the event delegate signature
        public void RemoveStaff(object sender, EmployeeLayOffEventArgs e)
        {
            //if (Staff == null) { Staff = new List<Employee>(); }
            //if ((sender is SalesPerson sp && !sp.CheckTarget(30)) || (sender is BoardMember) || (sender is Employee emp && emp != null && (e.Cause == LayOffCause.stock || e.Cause == LayOffCause.age)))
            if (sender is Employee emp && emp != null && (e.Cause == LayOffCause.stock || e.Cause == LayOffCause.age || e.Cause == LayOffCause.target || e.Cause == LayOffCause.resigned))
            {
                if (Staff.Contains(emp))
                {
                    Staff.Remove(emp);
                    Console.WriteLine($"{(emp).EmployeeID} got removed from department {DeptID}");
                }
            }

            #region thoughts
            //if (sender is SalesPerson sp && !sp.CheckTarget(30))
            //{
            //    if (Staff.Contains(sp))
            //    {
            //        Staff.Remove(sp);
            //    }
            //    Console.WriteLine($"{sp.EmployeeID} got removed from department");
            //}

            //else if (sender is BoardMember bm)
            //{
            //    if (Staff.Contains(bm))
            //    {
            //        Staff.Remove(bm);
            //    }
            //    Console.WriteLine($"{bm.EmployeeID} got removed from department");
            //}

            //else if (sender is Employee emp && emp != null && (e.Cause == (LayOffCause.stock & LayOffCause.age)) && emp.VacationStock<0 && ( DateTime.Now.Year - emp.BirthDate.Year) >60)
            //{
            //    if(Staff.Contains(emp))
            //    {
            //        Staff.Remove(emp);
            //    }
            //    Console.WriteLine($"{emp.EmployeeID} got removed from department");
            //} 
            #endregion
        }

    }
}
