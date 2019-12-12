using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template_payroll_console_
{
    class Assistant : Employer
    {
        public int Turns { get; set; }

        public Assistant(string name, string position, DateTime startDate, decimal rate, int turns) : base(name, position, startDate, rate)
        {
            Turns = turns;
        }

        protected override decimal Base()
        {
            return Rate * Turns;
        }

        protected override decimal Bonus()
        {
            if (Turns >= 12)
            {
                return 1000m;
            }
            return 0;
        }
    }
}
