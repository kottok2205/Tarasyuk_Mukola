using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    class Rectangle
    {
        public double side1, side2, area, perim;

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        public double AreaCalculator()
        {
            area = side1 * side2;
            return area;
        }

        public double PerimeterCalculator()
        {
            perim = 2 * (side1 + side2);
            return perim;
        }

        public double Area
        {
            get { return AreaCalculator(); }
        }

        public double Perimeter
        {
            get { return PerimeterCalculator(); }
        }
    }
}
