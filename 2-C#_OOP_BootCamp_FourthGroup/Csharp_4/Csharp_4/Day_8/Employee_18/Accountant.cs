using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_4.Day_8.Employee_18
{
     class Accountant :Employees
    {
        public double Tax { get; set; }
        public Accountant(string name, double salary,double tax ) 
            : base(name, salary)
        {
            Tax = tax;
        }
        public override double GetNetSalary()
        {
             return base.Salary - Tax;
         }
       

 


        /*
       * **Accountant**
   - Inherits from `Employee`
   - Adds: `TaxDeduction`
   - Overrides `GetNetSalary()` → Salary - Tax
       */

    }
}
