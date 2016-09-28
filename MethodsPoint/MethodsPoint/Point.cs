using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsPoint
{
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }


        public bool Equals(Point point)
        {
            return ((this.X == point.X) && (this.Y == point.Y));
        }

        public override string ToString()
        {
            return $"X: {this.X}; Y: {this.Y}";
        }
    }

    
}
