using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_4.Day_7.LastVersionOfDashBoard
{
     class EmployeeClass
    {
        public  void Emp_Label() 
        {
            Console.WriteLine("=================================");
            Console.WriteLine("   Employee Salary Information   ");
            Console.WriteLine("=================================");
        }
        public  object[] InputData()
        {
            Console.Write("Enter Employee name ");
            string Name = Console.ReadLine();

            Console.Write("Enter Employee monthly salary: ");
            double Salary = Convert.ToDouble(Console.ReadLine());

            return new object[] {Name, Salary};
        }
          double GetAnnualSalary(double monthlySalary)
        {
            return monthlySalary * 12;
        }
          string GetSalaryLevel(double monthlySalary)
        {

            if (monthlySalary >= 15000)
            {
                return "High Salary";
            }
            else if (monthlySalary >= 10000)
            {
                return "Normal Salary";
            }
            else if (monthlySalary >= 5000)
            {
                return "low Salary";
            }
            else
            {
                return "very low Salary";
            }

        }
        public  string[] GetEmployeeSummary(string Emp_name, double MonthelySalary)
        {
            double aSalary = GetAnnualSalary(MonthelySalary);
            string sLevel  = GetSalaryLevel(MonthelySalary);


            return new string[] { "Employee Name:  " +   Emp_name      ,
                                "Monthly Salary: " +   MonthelySalary ,
                                "Annual Salary : " +   aSalary       ,
                                "Salary Level :  " +   sLevel         };

        }
        public  void PrintEmployeeSummary(string[] summary)
        {
            foreach (string s in summary)
            {
                Console.WriteLine(s);
            }
        }

        }
    }
