using Csharp_4.Day_8.Task1_EmployeeSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_4.Day_8.Task2_StudentSystem
{ 
// ### 2. Student System
 
//- Create an ** interface** `IGrading` with:
//  - Method: `GetGrade(double percentage)`
//- Implement a class `Student` that inherits from `StudentBase` and implements `IGrading`.

     class Task2_Student
    {
        ////static void Main(string[] args)
        ////{ 

        ////}
    }

    # region StudentSystemClasses
    public abstract class StudentBase
    {
        private string _name    ;
        private double _mark    ;
        private double _fullmark;
        public string Name { get => _name; set => _name = value; }
        public double Mark { get => _mark; set => _mark = value; }
        public double Fullmark { get => _fullmark; set => _fullmark = value; }

        public StudentBase(string name, double mark, double fullmark)
        {
            Name     = name;
            Mark     = mark;
            Fullmark = fullmark;
        }
        public abstract double GetPercentage();

    }

    public interface IGrading 
    {
        string GetGrade(double percentage);
    }

    public class Student : StudentBase, IGrading
    {
        public Student(string name, double mark, double fullmark) : base(name, mark, fullmark) {}

        public string GetGrade(double percentage)
        {
            if      (percentage >= 85) return "Excellent";
            else if (percentage >= 75) return "Very Good";
            else if (percentage >= 65) return "Good";
            else if (percentage >= 50) return "Pass";
            else return "Failed";
        }

        public override double GetPercentage()
        {
          return (Mark / Fullmark)*100;
        }
    }
    #endregion


}
