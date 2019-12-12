using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template_payroll_console_
{
    class Employer
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public DateTime StartDate { get; set; }
        public decimal Rate { get; set; }

        protected Employer(string name, string position, DateTime startDate, decimal rate)
        {
            Name = name;
            Position = position;
            StartDate = startDate;
            Rate = rate;
        }

        public virtual decimal Sallary()
        {
            return Math.Round(Base() + Bonus() + Expirience(),2);
        }
        protected virtual decimal Base()
        {
            return Rate * 30;
        }
        protected virtual decimal Bonus()
        {
            return 0;
        }
        protected virtual decimal Expirience()
        {
            return Rate * (DateTime.Today - StartDate).Days / 30;
        }

        public override string ToString()
        {
            return $"Name: {Name}\n" +
                $"StartDate: {StartDate.ToShortDateString()}\n" +
                $"Position:{Position}\n"+
                $"Rate: {Rate}\n" +
                $"Sallary: {Sallary()}\n\n";
        }
    }
}