using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_4.Day_8.Employee_18
{
     class Developer : Employees
    {
        public double OvertimeHours { get; set; }
        public double HourlyRate { get; set; }

        public Developer(string name, double salary ,double overtimeHours, double hRate) 
            : base(name, salary)
        {
            OvertimeHours = overtimeHours;
            HourlyRate = hRate;
        }

        public override double GetNetSalary()
        {
            return base.Salary + (OvertimeHours* HourlyRate);
        }
         



    }
}
