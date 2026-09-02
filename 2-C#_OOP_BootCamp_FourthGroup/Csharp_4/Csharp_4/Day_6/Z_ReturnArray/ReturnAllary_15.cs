using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_4.Day_6.Z_ReturnArray
{
     class ReturnAllary_15
    {
        public static string[] GetEmployeeSummary(string name, double salary) 
        {
            double annaualSalary = salary * 12;
            string level =  salary >= 15000 ? "High"   :
                            salary >= 10000 ? "Normal" :
                            salary >= 5000  ? "Low"    : "VeryLow";

            return new string[]
            {
                "Name : "           + name         ,
                "Monthly Salary : " + salary       ,
                "Annual  Salary : " + annaualSalary,
                "Level : "          + level         

            };
        }
        /*
                   * -  GetStudentSummary(name, mark, fullMark)` → returns name, mark,
                        percentage, and grade.
                   */


    }
}
