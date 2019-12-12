using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template_payroll_console_
{
    class Director : Employer
    {
        public int Sal_dir { get; set; }
        public Director(string name, string position , DateTime startDate, decimal rate, int sal_dir) : base(name,  position, startDate, rate)
        {
            Sal_dir = sal_dir;
        }

        public override decimal Sallary()
        {
            return 1500000m; 
        }
    }
}
