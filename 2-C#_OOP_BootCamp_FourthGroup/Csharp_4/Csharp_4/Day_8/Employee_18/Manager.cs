using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_4.Day_8.Employee_18
{
     class Manager : Employees
    { 
       public double Bounas { get; set; }
  
        public Manager(string name, double salary, double bounas)
            :base (name , salary)      
        {
           
            Bounas = bounas;
        }

        public override double GetNetSalary()
        {
            return Salary + Bounas;
        }
    }
}
