using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_4.Day_2
{
     class Controls_if_elseIf_5
    {
       // static void Main(string[] args)
       // {
            
       //     Console.WriteLine("What  ur age ");
       //     int a = Convert.ToInt32(Console.ReadLine());
       //     if (a >= 25)
       //     {
       //         Console.WriteLine("you can Employee");
       //     }
       //     else if (a >= 15)
       //     {
       //         Console.WriteLine("you are student");
       //     }
       //     else if (a >= 10)
       //     {
       //         Console.WriteLine("you are child");
       //     }
       //     else
       //     {
       //         Console.WriteLine("invalid value");
       //     }


       //     /*
       //## ✅ Task 1: Employee Salary Classification
       //**Objective:**
       //         - Ask the user to enter their name and monthly salary.
       //         - Display name, monthly salary, and annual salary.
       //         - Classify salary as:
       //           - 15,000 or more → "High Salary"
       //           - 10,000 or more → "Normal Salary"
       //           - 5,000 or more  → "Low Salary"
       //           - Less than 5,000 → "Very Low Salary"

       //      */

       //     //// declare variables
       //     //string employeeName;
       //     //double monthlySalary;
       //     //double annualSalary;

       //     ////input from the user
       //     //Console.Write("Enter your name: ");
       //     //employeeName = Console.ReadLine();
       //     //Console.Write("Enter your monthly salary: ");
       //     //monthlySalary = Convert.ToDouble(Console.ReadLine());

       //     ////calculate annual salary
       //     //annualSalary = monthlySalary * 12;

       //     ////Display the results
       //     //Console.WriteLine("=================================");
       //     //Console.WriteLine("   Employee Salary Information   ");
       //     //Console.WriteLine("=================================");
       //     //Console.WriteLine("Employee Name: "  + employeeName);
       //     //Console.WriteLine("Monthly Salary: " + monthlySalary);
       //     //Console.WriteLine("Annual Salary: "  + annualSalary);
       //     //if (monthlySalary >= 15000)
       //     //{
       //     //    Console.WriteLine("High Salary");
       //     //}
       //     //else if (monthlySalary >= 10000)
       //     //{
       //     //    Console.WriteLine("Normal Salary");
       //     //}
       //     //else if (monthlySalary >= 5000)
       //     //{
       //     //    Console.WriteLine("low Salary");
       //     //}
       //     //else 
       //     //{
       //     //    Console.WriteLine("very low Salary");
       //     //}

       //     /*

       //      ## ✅ Task 2: Student Percentage Calculator
       //     **Objective:**
       //     - Ask the student to enter their name, mark, and full mark.
       //     - Calculate percentage.
       //     - Classify grade based on percentage:
       //       - 85% or more → "Excellent"
       //       - 75% or more → "Very Good"
       //       - 65% or more → "Good"
       //       - 50% or more → "Pass"
       //       - Below 50% → "Failed"
             
       //     */

       //     ////declare variables
       //     //string studentName;
       //     //double obtainedMark;
       //     //double fullMark;
       //     //double percentage;

       //     ////input from the user
       //     //Console.Write("Enter your name: ");
       //     //studentName = Console.ReadLine();
       //     //Console.Write("Enter your obtained mark: ");
       //     //obtainedMark = Convert.ToDouble(Console.ReadLine());
       //     //Console.Write("Enter the full mark: ");
       //     //fullMark = Convert.ToDouble(Console.ReadLine());

       //     ////calculate percentage
       //     //percentage = (obtainedMark / fullMark) * 100;

       //     ////Display the results
       //     //Console.WriteLine("=================================");
       //     //Console.WriteLine("   Student Percentage Calculator ");
       //     //Console.WriteLine("=================================");
       //     //Console.WriteLine("Student Name: " + studentName);
       //     //Console.WriteLine("Obtained Mark: " + obtainedMark);
       //     //Console.WriteLine("Full Mark: " + fullMark);
       //     //Console.WriteLine("Percentage: " + percentage + "%");
       //     //if (percentage >= 85)
       //     //{
       //     //    Console.WriteLine("Excellent");
       //     //}
       //     //else if (percentage >= 75)
       //     //{
       //     //    Console.WriteLine("very good");
       //     //}
       //     //else if (percentage >= 65)
       //     //{
       //     //    Console.WriteLine("good");
       //     //}
       //     //else if (percentage >= 50)
       //     //{
       //     //    Console.WriteLine("pass");
       //     //}
       //     //else 
       //     //{
       //     //    Console.WriteLine("faild");
       //     //}


       //     ///*
       //     // ## ✅ Task 3: Patient BMI Calculator
       //     //**Objective:**
       //     //- Ask the patient to enter their name, height (in meters), and weight (in kg).
       //     //- Calculate BMI using the formula:
       //     //  BMI = weight / (height * height)
       //     //-Classify BMI as:
       //     //   -Less than 18.5 → "Underweight"
       //     //   - 18.5 to less than 25 → "Normal Weight"
       //     //   - 25 to less than 30 → "Overweight"
       //     //   - 30 or more → "Obese"
       //     // */

       //     //Declear Varaible 
       //     string PatientName;
       //     double height;
       //     double weight;
       //     double BMI;
       //     //inputs from user 
       //     Console.WriteLine("pls enter your name ");
       //     PatientName = Console.ReadLine();
       //     Console.WriteLine("pls enter your height");
       //     height = Convert.ToDouble(Console.ReadLine());
       //     Console.WriteLine("pls enter your weight ");
       //     weight = Convert.ToDouble(Console.ReadLine());
       //     //calcualte the Bmi  
       //     BMI = weight / (height * height);
       //     //Display Result 
       //     Console.WriteLine("your name is : " + PatientName);
       //     Console.WriteLine("your height is " + height + " M");
       //     Console.WriteLine("your weight is " + weight + " Kg");
       //     Console.WriteLine("Bmi Is : " + BMI);
        
       //     if (BMI < 18.5)
       //     {
       //         Console.WriteLine("Underweight");
       //     }
       //     else if (BMI >=18.5 && BMI < 25)
       //     {
       //         Console.WriteLine("Normal Weight");

       //     }
       //     else if (BMI<30)
       //     {
       //         Console.WriteLine("Overweight");

       //     }
       //     else if (BMI >=30)
       //     {
       //         Console.WriteLine("Obese");

       //     }



         
       // }

    }
}
