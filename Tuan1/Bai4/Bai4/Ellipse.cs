using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    public class Ellipse : Shape
    {
        private double a, b;

        public Ellipse(double x, double y, double a, double b) : base(x, y)
        {
            this.a = a;
            this.b = b;
        }

        public double A { get { return a; } }
        public double B { get { return b; } }

        public override double Area()
        {
            return Math.PI * a * b;
        }
    }
}
