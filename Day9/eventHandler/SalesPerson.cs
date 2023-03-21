using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eventHandler
{
    internal class SalesPerson : Employee

    {
        public SalesPerson() { VacationStock = 0; }
        public int AchievedTarget { get; set; }
        public bool CheckTarget(int Quota)
        {
            if (AchievedTarget >= Quota)
                return true;
            else
            {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs() { Cause = LayOffCause.target });
                return false;
            }
        }
        //public override int VacationStock
        //{
        //    get { return this.VacationStock; }
        //    set { this.VacationStock = value; }
        //}
        protected override void OnEmployeeLayOff(EmployeeLayOffEventArgs e)
        {
            if (e != null && e.Cause == LayOffCause.target)
            {
                //Console.WriteLine($"employee: {this.EmployeeID}, cause: {e.Cause}");
                base.OnEmployeeLayOff(e);
            }

        }

    }
}
