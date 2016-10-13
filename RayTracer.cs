using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cross
{
    class RayTracer
    {
        public Vector canvasPoint = new Vector();
        public RayTracer() { }

        public void CreateRay(double x1, double y1)
        {
            x1 = x1 / 640;
            y1 = y1 / 480;

            canvasPoint = new Vector (x1, y1, 0);
            Vector dirVector = new Vector(x1, y1, 1);

            Console.WriteLine("r(t) = <0, 0, -1> + t * <{0}, {1}, {2}>", dirVector.x, dirVector.y, dirVector.z);
        }
    }
}
