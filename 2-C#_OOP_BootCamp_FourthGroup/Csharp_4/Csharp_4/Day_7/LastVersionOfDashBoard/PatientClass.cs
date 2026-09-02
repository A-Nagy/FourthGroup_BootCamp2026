using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_4.Day_7.LastVersionOfDashBoard
{
     class PatientClass
    {
        public void Patient_Label()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("   Patient BMI Calculator ");
            Console.WriteLine("=================================");
        }

        public object[] InputPatientData()
        {
            Console.Write("Enter Patient name ");
            string pname = Console.ReadLine();

            Console.Write("Enter Patient Height ");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Patient Weight ");
            double weight = Convert.ToDouble(Console.ReadLine());

            return new object[] { pname, height , weight };
        }

         double GetBMI(double Height, double Weight)
        {
            return (Weight / (Height*Height));
        }

         string GetBodyStatus(double Height, double Weight)
        {
            double BMI = GetBMI(Height, Weight);

            return BMI < 18.5 ? "Underweight"   :
                   BMI < 25   ? "Normal weight" :
                   BMI < 30   ? "Overweight"    : "Obesity";
        }

        public string[] GetPatientSummary(string PatientName, double Height, double Weight)
        {
            return new string[] {
                                    "Patient Name  : "    + PatientName,
                                    "Patient Height: "    + Height,
                                    "Patient Weight: "    + Weight,
                                    "Patient BMI   : "    + GetBMI(Height,Weight)  ,
                                    "Patient Body Status : " + GetBodyStatus(Height,Weight)
            };
        }

        public void PrintPatientSummary(string[] summary)
        {
            foreach (string s in summary)
            {
                Console.WriteLine(s);
            }
        }

    }
}
