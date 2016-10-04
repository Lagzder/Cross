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

        public Sphere() { }

        public List<Vector> GetIntersection(Vector line, Sphere sphere)
        {
            List<Vector> intersections = new List<Vector>();

            double a = Math.Pow(line.xt, 2) + Math.Pow(line.yt, 2) + Math.Pow(line.zt, 2);
            double b = 2 * (line.xt * (line.x - sphere.x) + line.yt * (line.y - sphere.y) + line.zt * (line.z - sphere.z));
            double c = Math.Pow((line.x - sphere.x), 2) + Math.Pow((line.y - sphere.y), 2) + Math.Pow((line.z - sphere.z), 2) - Math.Pow(sphere.r, 2);

            double D = (b * b) - 4 * a * c;

            if (D < 0)
            {
                Console.WriteLine("No intersection");
            }

            if (D == 0)
            {
                double d = -b / 2 * a;

                double x0 = line.x + (d * line.xt);
                double y0 = line.y + (d * line.yt);
                double z0 = line.z + (d * line.zt);

                Console.WriteLine("Intersection in 1 point x: {0}, y: {1}, z: {2}", x0, y0, z0);

                intersections.Add(new Vector(x0, y0, z0));
                return intersections;
            }

            if (D > 0)
            {
                double d1 = (-b + Math.Sqrt(D)) / (2 * a);
                double d2 = (-b - Math.Sqrt(D)) / (2 * a);

                double x1 = line.x + (d1 * line.xt);
                double y1 = line.y + (d1 * line.yt);
                double z1 = line.z + (d1 * line.zt);

                double x2 = line.x + (d2 * line.xt);
                double y2 = line.y + (d2 * line.yt);
                double z2 = line.z + (d2 * line.zt);

                Console.WriteLine("Intersection in 2 points\nx1: {0}, y1: {1}, z1: {2}\nx2: {3}, y2: {4}, z2: {5}", x1, y1, z1, x2, y2, z2);

                intersections.Add(new Vector(x1, y1, z1));
                intersections.Add(new Vector(x2, y2, z2));

                return intersections;
            }

            return null;
        }
    }
}
