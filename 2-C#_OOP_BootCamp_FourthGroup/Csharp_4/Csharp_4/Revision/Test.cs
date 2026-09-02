using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_4.Revision
{
     class Test
    {/*
      
### 🔹 Employee (Abstract Base Class)
- *Fields (Encapsulated)*:
  - name
  - salary
- *Methods*:
  - AnnualSalary() → *Abstract method*, implemented by subclasses
- *Purpose*: Provides a base structure for all types of employees.

### 🔹 EmployeeBasic (Inherits Employee)
- *Additional Field*:
  - commission
- *Method Override*:
  - AnnualSalary() returns (salary * 12) + commission

### 🔹 EmployeeHourly (Inherits Employee)
- *Additional Field*:
  - overtime
- *Method Override*:
  - AnnualSalary() returns (salary * 12) + overtime

### 🔹 TestEmployee (Main Class)
- Creates instances of EmployeeBasic and EmployeeHourly
- Demonstrates *runtime polymorphism*
- Prints annual salaries

      */
        //static void Main(string[] args)
        //{

        //}

    }

    public abstract class Employee 
    {
        private string name;
        private double salary;

        public string Name { get => name; set => name = value; }
        public double Salary { get => salary; set => salary = value; }

        public Employee(string name, double salary)
        {
            this.Name   = name;
            this.Salary = salary;
        }

        public abstract double GetSalary();
        
    }


    public class EmployeeBasic : Employee
    {
        private double commission;
        public  double Commission { get => commission; set => commission = value; }

        public EmployeeBasic(string name, double salary, double commission) : base(name, salary)
        {
             this.Commission = commission;
        }

        public override double GetSalary() 
        { 
            return Commission + Salary ;
        }
    }
    public class EmployeeOvertime : Employee
    {
        double overtime;
        public double Overtime { get => overtime; set => overtime = value; }
        public EmployeeOvertime(string name, double salary, double overtime) : base(name, salary)
        {
            this.Overtime = overtime;
        }
         
        public override double GetSalary()
        {
            return Salary + Overtime;
        }
    }
}
