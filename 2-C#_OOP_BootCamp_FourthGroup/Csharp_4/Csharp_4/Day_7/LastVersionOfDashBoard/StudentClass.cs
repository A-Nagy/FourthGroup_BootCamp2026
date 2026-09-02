using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_4.Day_7.LastVersionOfDashBoard
{
     class StudentClass
    {
        public void Student_Label()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("   Student Percentage Calculator ");
            Console.WriteLine("=================================");
        }

        public object[] InputStudentData()
        {
            Console.Write("Enter your name: ");
            string studentName = Console.ReadLine();

            Console.Write("Enter your obtained mark: ");
            double obtainedMark = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the full mark: ");
            double fullMark = Convert.ToDouble(Console.ReadLine());

            return new object[] { studentName, obtainedMark, fullMark };
        }

         double GetPercentage(double mark, double fullMark)
        {
            return (mark / fullMark) * 100;
        }

         string GetGrade(double mark, double fullmark)
        {
            double percentage = GetPercentage(mark, fullmark);

            if (percentage >= 85)
            {
                return "Excellent";
            }
            else if (percentage >= 75)
            {
                return "Very Good";
            }
            else if (percentage >= 65)
            {
                return "Good";
            }
            else if (percentage >= 50)
            {
                return "Pass";
            }
            else
            {
                return "Failed";
            }
        }

        public string[] GetStudentSummary(string studentName, double obtainedMark, double fullMark)
        {  
            return new string[] {
                                    "Student Name: " + studentName,
                                    "Obtained Mark:" + obtainedMark,
                                    "Full Mark: "    + fullMark,
                                    "Percentage: "   + GetPercentage(obtainedMark, fullMark) + "%",
                                    "Grade: "        + GetGrade(obtainedMark, fullMark)
            };
        }

        public void PrintStudentSummary(string[] summary)
        {
            foreach (string s in summary)
            {
                Console.WriteLine(s);
            }
        }

    }
}
