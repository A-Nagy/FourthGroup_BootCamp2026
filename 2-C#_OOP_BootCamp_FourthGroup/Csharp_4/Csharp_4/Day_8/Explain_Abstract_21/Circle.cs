using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_4.Day_8.Explain_Abstract_21
{
     class Circle :Shape
    {
        public double Radius { get; set; }

        public Circle(double raise)
        {
            Radius = raise;
        }

        public override double GetArea() 
        {
            return Math.PI * Radius * Radius;
        }

    }
}
