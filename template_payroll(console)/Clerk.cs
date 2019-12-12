using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template_payroll_console_
{
    class Clerk : Employer
    {
        public Clerk(string name, string position, DateTime startDate, decimal rate) : base(name,position,startDate, rate)
        {

        }

        protected override decimal Base()
        {
            return base.Base() + 1500m;
        }
    }
}
