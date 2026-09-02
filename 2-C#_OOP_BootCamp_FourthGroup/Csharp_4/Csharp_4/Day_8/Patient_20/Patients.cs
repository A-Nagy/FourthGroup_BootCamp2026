using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_4.Day_8.Patient_20
{
     class Patients : Person,IPrintable
    {
        private double height;
        private double weight;

         public double Height { get => height; set => height = value; }
        public double Weight { get => weight; set => weight = value; }

        public Patients(string name , double height, double weight)
            : base(name)
        {
        
            Height = height;
            Weight = weight;
            
        }
        public double GEtBMI() 
        {
            return Weight / (  Height * Height );
        }
        public string GetBodyStatus() 
        {
            double Bmi = GEtBMI();
            return Bmi <= 18.5 ? "Under Weight"  :
                   Bmi <= 25   ? "Normal Weight" :
                   Bmi <= 30   ? "OverWieght"    : "Obasty";
 
        }

        public override string PrintAllData()
        {
            return $"Patient name is {Name} \n" +
                   $"Patient Height is {Height} \n" +
                   $"Patient Weight is {Weight} \n" +
                   $"Patient BMI is {GEtBMI()}";

        }

        public void PrintDetails()
        {
            Console.WriteLine( $"Patient name is {Name} \n" +
                               $"Patient Height is {Height} \n" +
                               $"Patient Weight is {Weight} \n" +
                               $"Patient BMI is {GEtBMI()}");
        }
    }
}
