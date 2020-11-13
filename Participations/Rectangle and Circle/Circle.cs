using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_and_Circle
{
    class Circle
    {
        public double Radius { get; set; }
        public double Radius2 { get; set; }
        public double CalculateArea { get; set; }
        public double CalculateArea2 { get; set; }
        public double CalculatePerimeter { get; set; }
        public double CalculatePerimeter2 { get; set; }

        public Circle()
        {
            Radius = 11;
            CalculateArea = Math.PI * Math.Pow(Radius, 2);
            CalculatePerimeter = (2 * Math.PI) * Radius;
            Radius2 = 78;
            CalculateArea2 = Math.PI * Math.Pow(Radius2, 2);
            CalculatePerimeter2 = (2 * Math.PI) * Radius2;
        }
    }
}

    
