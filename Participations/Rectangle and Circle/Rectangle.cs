using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_and_Circle
{
    class Rectangle
    {
        public double Length { get; set; }
        public double Length2 { get; set; }
        public double Width { get; set; }
        public double Width2 { get; set; }
        public double CalculateArea { get; set; }
        public double CalculateArea2 { get; set; }
        public double CalculatePerimeter { get; set; }
        public double CalculatePerimeter2 { get; set; }

        public Rectangle()
        {
            Length = 11;
            Width = 23;
            CalculateArea = Length * Width;
            CalculatePerimeter = 2 * (Length * Width);
            Length2 = 78;
            Width2 = 123;
            CalculateArea2 = Length2 * Width2;
            CalculatePerimeter2 = 2 * (Length2 * Width2);
        }
    }
}
