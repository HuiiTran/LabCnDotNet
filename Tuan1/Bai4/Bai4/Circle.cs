using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    public class Circle : Shape
    {
        private double radius;

        public Circle(double x, double y, double radius) : base(x, y)
        {
            this.radius = radius;
        }

        public
     double Radius
        { get { return radius; } }

        public override double Area()
        {
            return Math.PI * radius * radius;
        }
    }
}
