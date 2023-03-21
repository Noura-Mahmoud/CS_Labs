using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace eventHandler
{
    public class Employee
    {
        //1) define the event (delegate object)
        public event EventHandler<EmployeeLayOffEventArgs> EmployeeLayOff;
        protected virtual void OnEmployeeLayOff (EmployeeLayOffEventArgs e)
        {
            Console.WriteLine($"employee: {EmployeeID}, cause: {e.Cause}");
            EmployeeLayOff?.Invoke(this, e);
        }
        public int EmployeeID { get; set; }

        public DateTime BirthDate { get; init; }
        //DateTime birthDate;
        //public DateTime BirthDate
        //{
        //    get { return birthDate; }
        //    set
        //    {
        //        if (DateTime.Now.Year - value.Year > 60)
        //        {
        //            OnEmployeeLayOff(new EmployeeLayOffEventArgs() { Cause = LayOffCause.age });
        //        }
        //        else
        //            birthDate = value;
        //    }
        //}
        public int VacationStock { get; set; }
        //int vacationStock;
        //public virtual int VacationStock
        //{
        //    get { return vacationStock; }
        //    set
        //    {
        //        if (vacationStock != value) 
        //        {
        //            vacationStock = value;
        //            //4)notify subscriber
        //            //invoke callback subscribers' methods 
        //            OnEmployeeLayOff(new EmployeeLayOffEventArgs());
        //        }
        //    }
        //}
        public bool RequestVacation(DateTime From, DateTime To)
        {
            //if (vacationStock == 0) { Console.WriteLine("You are out of vacation stock"); return false; }
            //else return true;
            if (VacationStock - (To - From).Days  >= 0)
            {
                VacationStock -= (To - From).Days;
                return true;
            }
            else
            {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs() { Cause = LayOffCause.stock });
                return false;
            }
        }
        public void EndOfYearOperation()
        {
            if ( DateTime.Now.Year - BirthDate.Year >60)
            {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs() { Cause = LayOffCause.age});
            }
            else if (VacationStock < 0)
            {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs() { Cause = LayOffCause.stock });
            }
        }
    }

    public enum LayOffCause
    { 
        ///Implement it YourSelf 
        stock, age, target, resigned
    }
}
