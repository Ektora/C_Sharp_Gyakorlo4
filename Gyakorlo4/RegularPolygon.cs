using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorlo4
{
    internal class RegularPolygon
    {
        private int n;
        private double side, x, y;

        public int N { get { return n; } set { n = value; } }
        public double Side { get { return side; } set { side = value; } }
        public double X { get { return x;  } set { x = value; } }
        public double Y { get { return y; } set { y = value; } }

        public RegularPolygon()
        {
            this.n = 3;
            this.x = 0;
            this.y = 0;
            this.side = 3;
        }

        public RegularPolygon(int n, double side)
        {
            this.n = n;
            this.side = side;
            this.x = 0;
            this.y = 0;
        }

        public RegularPolygon(int n, double side, double x, double y)
        {
            this.n = n;
            this.side = side;
            this.x = x;
            this.y = y;
        }

        public double getPerimeter()
        {
            return this.n * this.side;
        }

        public double getArea()
        {
            return (this.n * Math.Pow(this.side,2))/(4*Math.Tan(Math.PI/n));
        }
    }
}
