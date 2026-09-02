using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_4.Day_8.Task1_EmployeeSystem
{
    public class TestTask1
    {
        //static void Main(string[] args ) 
        //{
        //    Employee employee = new Employee("Mashael", 20000);
        //   Console.WriteLine(employee.CalculateAnnualSalary() );
        //   Console.WriteLine(employee.GetSalaryLevel(employee.CalculateAnnualSalary()));


        //}
    }
    public abstract class EmployeeBase 
    {
        string _name;
        double monthlysalary;

        public string Name { get => _name; set => _name = value; }
        public double Monthlysalary { get => monthlysalary; set => monthlysalary = value; }
        public EmployeeBase(string Name,double monthlysalary)
        {
           this.Name = Name;
           this.Monthlysalary = monthlysalary;
        }
        public abstract double CalculateAnnualSalary();


    }
    public interface ISalaryLevel 
    {
        string GetSalaryLevel(double annualSalary);
    }
    public class Employee : EmployeeBase, ISalaryLevel
    {
        public Employee(string Name, double monthlysalary) : base(Name, monthlysalary) { }
     

        public override double CalculateAnnualSalary()
        {
            return Monthlysalary * 12;
        }

        public string GetSalaryLevel(double annualSalary)
        {
            return annualSalary >= 18000  ? "High Salary"   :
                   annualSalary >= 120000 ? "Normal Salary" :
                   annualSalary >= 60000  ? "Low Salary"    : "Very Low Salary "; 
        }
    }

}
/*
 ### 2. Student System
- Create an **abstract class** `StudentBase` with:
  - Properties: `Name`, `Mark`, `FullMark`
  - Abstract Method: `GetPercentage()`
- Create an **interface** `IGrading` with:
  - Method: `GetGrade(double percentage)`
- Implement a class `Student` that inherits from `StudentBase` and implements `IGrading`.

---

### 3. Patient System
- Create an **abstract class** `PatientBase` with:
  - Properties: `Name`, `Height`, `Weight`
  - Abstract Method: `GetBMI()`
- Create an **interface** `IBodyStatus` with:
  - Method: `GetStatus(double bmi)`
- Implement a class `Patient` that inherits from `PatientBase` and implements `IBodyStatus`.
 
 */