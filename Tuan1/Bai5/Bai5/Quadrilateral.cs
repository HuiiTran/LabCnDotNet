using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    public class Quadrilateral : Shape
    {
        public Quadrilateral(List<Point> points) : base(points)
        {
            if (points.Count != 4)
            {
                throw new ArgumentException("A quadrilateral must have 4 points.");
            }
        }
    }
}
