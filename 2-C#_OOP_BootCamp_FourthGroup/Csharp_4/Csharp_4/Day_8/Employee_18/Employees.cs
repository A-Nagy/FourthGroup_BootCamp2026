using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_4.Day_8.Employee_18
{
     class Employees :Person , IPrintable
    {
        
        //fields
        
         double _salary;
        
        public double Salary 
        {
            get { return _salary; }
            set { _salary = value<=2000?2500:value ; }
        }

        public Employees(string name , double salary ) : base(name)
        {
        
            Salary = salary ;

        }

        //functions
        // ✅ الطريقة الثانية: تعتمد على الخصائص الداخلية للكائن
        public double CalculateAnnualSalary()
        {
            return Salary * 12;
        }
        public string GetAnnualSalaryLevel()
        {
            double annualSalary = CalculateAnnualSalary();

            if (annualSalary < 50000)
            {
                return "Low";
            }
            else if (annualSalary >= 50000 && annualSalary < 100000)
            {
                return "Medium";
            }
            else
            {
                return "High";
            }
        }
       
        public virtual double GetNetSalary() 
        {
            return Salary; 
        }

        public override string PrintAllData()
        {

            return $"Employee name is {Name} \n" +
                   $"Employee Salary is {GetNetSalary()} \n" +
                   $"Employee Annual Salary is {CalculateAnnualSalary()} \n" +
                   $"Employee Annual Salary Level is {GetAnnualSalaryLevel()}";

        }

        public void PrintDetails()
        {
            Console.WriteLine($"Employee name is {Name} \n" +
                   $"Employee Salary is {GetNetSalary()} \n" +
                   $"Employee Annual Salary is {CalculateAnnualSalary()} \n" +
                   $"Employee Annual Salary Level is {GetAnnualSalaryLevel()}");
        }

        // ✅ الطريقة الاولي: تعتمد على قيمة تمرر لها (parameter)
        //public string GetAnnualSalaryLevel(double annualSalary)
        //{
        //    if (annualSalary < 50000)
        //    {
        //        return "Low";
        //    }
        //    else if (annualSalary >= 50000 && annualSalary < 100000)
        //    {
        //        return "Medium";
        //    }
        //    else
        //    {
        //        return "High";
        //    }
        //}

    }
}
 