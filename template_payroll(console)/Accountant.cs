using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template_payroll_console_
{
    class Accountant : Employer
    {
        public int Hours { get; set; }

        public Accountant(string name, string position, DateTime startDate, decimal rate, int hours) : base(name, position, startDate, rate)
        {
            Hours = hours;
        }

        protected override decimal Base()
        {
            return Rate * Hours;
        }
    }
}
