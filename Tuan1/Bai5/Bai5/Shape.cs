using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    public class Shape
    {
        protected List<Point> points;

        public Shape(List<Point> points)
        {
            this.points = points;
        }
    }

    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
    }

}
