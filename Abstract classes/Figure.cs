using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_classes
{
    abstract class Figure
    {
        public abstract double Calculatearea();
        public abstract double Calculateperimeter();
    }

    class Rectangle : Figure
    {
        private double Lenthg;
        private double Width;

        public Rectangle(double length, double width)
        {
            this.Lenthg = length;
            this.Width = width;
        }

       
        public override double Calculatearea()
        {
            return Lenthg * Width;
        }
        public override double Calculateperimeter ()
        {
            return 2 * (Lenthg + Width);
        }
    }
}

