using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_and_Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle myCircle = new Circle();
            myCircle.Radius = 11;

            Console.WriteLine($"The area of a circle with a radius of {myCircle.Radius} is {myCircle.CalculateArea:N2} and a perimeter of {myCircle.CalculatePerimeter:N2}.");

            Circle circle2 = new Circle();
            circle2.Radius2 = 78;
            Console.WriteLine($"The area of a circle with a radius of {circle2.Radius2} is {circle2.CalculateArea2:N2} and a perimeter of {circle2.CalculatePerimeter2:N2}.");

            Rectangle myRectangle = new Rectangle();
            myRectangle.Length = 11;
            myRectangle.Width = 23;

            Console.WriteLine($"The area of a rectangle with a length of {myRectangle.Length} and a width of {myRectangle.Width} is {myRectangle.CalculateArea:N2} and a perimeter of {myRectangle.CalculatePerimeter:N2}.");

            Rectangle rectangle2 = new Rectangle();
            rectangle2.Length2 = 78;
            rectangle2.Width2 = 123;

            Console.WriteLine($"The area of a rectangle with a length of {rectangle2.Length2} and a width of {rectangle2.Width2} is {rectangle2.CalculateArea2:N2} and a perimeter of {rectangle2.CalculatePerimeter2:N2}.");

            Console.ReadKey();
        }
    }
}
