using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cross
{
    class Pixel
    {
        public double x { get; set; }
        public double y { get; set; }
        public double intersectSize { get; set; }

        public Pixel(double x, double y, double intersectSize)
        {
            this.x = x;
            this.y = y;
            this.intersectSize = intersectSize;
        }
    }
}
