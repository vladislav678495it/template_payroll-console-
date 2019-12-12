using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template_payroll_console_
{
    class Manager : Employer
    {
        public int SalesCount { get; set; }
        public decimal SalesAmount { get; set; }

        public Manager(string name, string position, DateTime startDate, decimal rate, int salesCount, decimal salesAmount) : base(name,position, startDate, rate)
        {
            SalesCount = salesCount;
            SalesAmount = salesAmount;
        }

        protected override decimal Bonus()
        {
            if (SalesCount > 20 || SalesAmount > 200000m)
            {
                return 1000m + SalesAmount * 0.1m;
            }
            if (SalesCount > 10 || SalesAmount > 100000m)
            {
                return 500m + SalesAmount * 0.05m;
            }
            return 0;
        }
    }
}
