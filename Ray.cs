using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cross
{
    class Ray
    {

        public Vector point = new Vector();
        public Vector vector = new Vector();
        

        public Ray(double x0, double y0, double z0, double xd, double yd, double zd)
        {
           point = new Vector(x0, y0, z0);
           vector = new Vector(xd, yd, zd);
        }

    }
}
