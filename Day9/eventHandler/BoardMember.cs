using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eventHandler
{
    internal class BoardMember : Employee
    {
        public void Resign()
        {
            OnEmployeeLayOff(new EmployeeLayOffEventArgs() { Cause = LayOffCause.resigned});
        }
        protected override void OnEmployeeLayOff(EmployeeLayOffEventArgs e)
        {
            if (e != null && e.Cause == LayOffCause.resigned)
            {
                //Console.WriteLine($"employee: {this.EmployeeID}, cause: {e.Cause}");
                base.OnEmployeeLayOff(e);
            }

        }
    }
}
