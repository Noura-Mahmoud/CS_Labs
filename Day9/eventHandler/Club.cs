using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eventHandler
{
    public class Club
    {
        public int ClubID { get; set; }
        public String ClubName { get; set; }
        List<Employee> Members = new List<Employee>();
        public void AddMember(Employee E)
        {
            if (E!= null)
            {
                if (!Members.Contains(E))
                {
                    Members.Add(E);
                }
                ///Try Register for EmployeeLayOff Event Here
                E.EmployeeLayOff += RemoveMember;
            }
        }
        ///CallBackMethod
        //2) define call back method matching the event delegate signature
        public void RemoveMember (object sender, EmployeeLayOffEventArgs e)
        {
            //if (Members == null) Members = new List<Employee>();
            if (sender is Employee emp && emp!= null && (e.Cause == LayOffCause.stock|| e.Cause == LayOffCause.target))
            {
                if (Members.Contains(emp)) 
                {
                    Members.Remove(emp);
                    Console.WriteLine($"{emp.EmployeeID} got removed from club {ClubName}");
                }
            }
            ///Employee Will not be removed from the Club if Age>60
            ///Employee will be removed from Club if Vacation Stock < 0
        }
    }
}
