using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorlo4
{
    class Rectangle
    {
        public double width = 1.0, height = 1.0;

        public Rectangle()
        {

        }

        public Rectangle(double height, double width)
        {
            this.width = width;
            this.height = height;
        }

        public double getArea()
        {
            return this.width * this.height;
        }

        public double getPerimeter()
        {
            return 2 * (this.width + this.height);
        }
    }
}
