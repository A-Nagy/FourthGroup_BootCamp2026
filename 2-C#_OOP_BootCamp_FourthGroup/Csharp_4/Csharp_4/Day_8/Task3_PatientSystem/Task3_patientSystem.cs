using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_4.Day_8.Task3_PatientSystem
{
     class Task3_patientSystem
    {
//### 3. Patient System
//- Create an **abstract class** `PatientBase` with:
//  - Properties: `Name`, `Height`, `Weight`
//  - Abstract Method: `GetBMI()`
//- Create an **interface** `IBodyStatus` with:
//  - Method: `GetStatus(double bmi)`
//- Implement a class `Patient` that inherits from `PatientBase` and implements `IBodyStatus`.
 

        //static void Main(string[] args)
        //{

        //}
    }

    public abstract class PatientBase
    {
        public string Name { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }

        public PatientBase(string name, double height, double weight)
        {
            Name = name;
            Height = height;
            Weight = weight;
        }

        public abstract double GetBMI();
    }
    interface IBodyStatus
    {
        string GetStatus(double bmi);
    }
    class Patient : PatientBase, IBodyStatus
    {

        public Patient(string name, double height, double weight)
        : base(name, height, weight)
        {
        }

        public override double GetBMI()
        {
            return Weight / (Height * Height);
        }
        public string GetStatus(double bmi)
        {
            return bmi < 18.5 ? "Underweight" :
                   bmi < 25 ? "Normal" :
                   bmi < 30 ? "Overweight" :
                   "Obesity";

        }

    }
}
 
