using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_4.Day_8.Student_19
{
     class Students : Person , IPrintable
    {
         private double mark;
         private double fullmark; 
        public double Mark 
        {
            get => mark;
            set => mark = value; 
        }
        public double Fullmark 
        { 
            get => fullmark;
            set => fullmark = value;
        }

        public Students(string name , double mark , double fullmark )
            : base( name )
        {
           
            Mark = mark;
            Fullmark = fullmark;
            
        }
        public double GetPrecentage() 
        {
            return (Mark /Fullmark)*100;
        }
        public string GetGrade() 
        {double precentage = GetPrecentage();

            return precentage >= 90 ? "A" :
                   precentage >= 80 ? "B" :
                   precentage >= 70 ? "C" :
                   precentage >= 60 ? "D" : "F";
        }

        public override string PrintAllData()
        {
            return $"Student name is {Name} \n" +
                   $"Student Mark is {Mark} \n" +
                   $"Student Precentage is {GetPrecentage()} \n" +
                   $"Student Grade is {GetGrade()}";

        }

        public void PrintDetails()
        {
            Console.WriteLine($"Student name is {Name} \n" +
                   $"Student Mark is {Mark} \n" +
                   $"Student Precentage is {GetPrecentage()} \n" +
                   $"Student Grade is {GetGrade()}");
        }
    }
}
