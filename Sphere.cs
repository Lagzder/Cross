using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cross
{
    class Sphere : IObject
    {
        public double x { get; set; }
        public double y { get; set; }
        public double z { get; set; }
        public double r { get; set; }

        public Sphere(double x, double y, double z, double r) // sphere
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.r = r;
        }

        public Vector GetIntersection(Ray ray)
        {
            return null;
        }
    }
}
