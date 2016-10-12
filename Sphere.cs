using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cross
{
    class Sphere : IObject
    {
        public double xc { get; set; }
        public double yc { get; set; }
        public double zc { get; set; }
        public double r  { get; set; }

        public Sphere(double xc, double yc, double zc, double r) // sphere
        {
            this.xc = xc;
            this.yc = yc;
            this.zc = zc;
            this.r = r;
        }

        public Sphere() { }

        public Vector GetIntersection(Ray ray)
        {
           
            double a = Math.Pow(ray.vector.x, 2) + Math.Pow(ray.vector.y, 2) + Math.Pow(ray.vector.z, 2); //xd, yd, zd
            double b = 2 * (ray.vector.x * (ray.point.x - xc) + ray.vector.y * (ray.point.y - yc) + ray.vector.z * (ray.point.z - zc));
            double c = Math.Pow((ray.point.x - xc), 2) + Math.Pow((ray.point.y - yc), 2) + Math.Pow((ray.point.z - zc), 2) -Math.Pow(r, 2);

            double D = (b * b) - 4 * a * c;
           
            if (D < 0)
            {
                Console.WriteLine("No intersection");
            }

            if (D == 0)
            {
                double t = -b / 2 * a;

                double x0 = ray.point.x + (t * ray.vector.x);
                double y0 = ray.point.y + (t * ray.vector.y);
                double z0 = ray.point.z + (t * ray.vector.z);

                Console.WriteLine("Intersection in 1 point x: {0}, y: {1}, z: {2}", x0, y0, z0);

                
            }

            if (D > 0)
            {
                double t0 = (-b + Math.Sqrt(D)) / (2 * a);
                double t1 = (-b - Math.Sqrt(D)) / (2 * a);
                
                if(t0 > 0 && t1 > 0)
                {
                    if (t0 < t1)
                    {
                        double x1 = ray.point.x + (t0 * ray.vector.x);
                        double y1 = ray.point.y + (t0 * ray.vector.y);
                        double z1 = ray.point.z + (t0 * ray.vector.z);
                        Console.WriteLine("Intersection\nx: {0}, y: {1}, z: {2}", x1, y1, z1);
                    }
                    else
                    {
                        double x1 = ray.point.x + (t1 * ray.vector.x);
                        double y1 = ray.point.x + (t1 * ray.vector.y);
                        double z1 = ray.point.x + (t1 * ray.vector.z);
                        Console.WriteLine("Intersection\nx: {0}, y: {1}, z: {2}", x1, y1, z1);
                    }
                }

                if(t0 < 0 && t1 > 0)
                {
                    double x1 = ray.point.x + (t1 * ray.vector.x);
                    double y1 = ray.point.x + (t1 * ray.vector.y);
                    double z1 = ray.point.x + (t1 * ray.vector.z);
                    Console.WriteLine("Intersection\nx: {0}, y: {1}, z: {2}", x1, y1, z1);
                }
                if(t1 < 0 && t0 > 0)
                {
                    double x1 = ray.point.x + (t0 * ray.vector.x);
                    double y1 = ray.point.y + (t0 * ray.vector.y);
                    double z1 = ray.point.z + (t0 * ray.vector.z);
                    Console.WriteLine("Intersection\nx: {0}, y: {1}, z: {2}", x1, y1, z1);
                }

                if(t1 < 0 && t0 < 0)
                {
                    Console.WriteLine("Intersections lower then position of origin point");
                }      
            }

            return null;
        }
    }
}
