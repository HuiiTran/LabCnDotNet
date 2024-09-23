using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    public class Shape
    {
        protected double x, y;

        public Shape(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double X { get { return x; } }
        public double Y { get { return y; } }

        public virtual void Move(double dx, double dy)
        {
            x += dx;
            y += dy;
        }

        public virtual double Area()
        {
            throw new NotImplementedException();
        }
    }
}
