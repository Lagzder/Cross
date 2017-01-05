using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cross
{
    class Sphere : IObject
    {
        Vector Centre = new Vector();
        public double R  { get; set; }

        public Sphere(Vector centre, double r) // sphere
        {
            this.Centre = centre;
            this.R = r;
        }

        public Sphere() { }

        public Vector GetIntersection(Ray ray)
        {
            Vector intPixel = new Vector();
            double a = Math.Pow(ray.vector.X, 2) + Math.Pow(ray.vector.Y, 2) + Math.Pow(ray.vector.Z, 2); //xd, yd, zd
            double b = 2 * (ray.vector.X * (ray.point.X - Centre.X) + ray.vector.Y * (ray.point.Y - Centre.Y) + ray.vector.Z * (ray.point.Z - Centre.Z));
            double c = Math.Pow((ray.point.X - Centre.X), 2) + Math.Pow((ray.point.Y - Centre.Y), 2) + Math.Pow((ray.point.Z - Centre.Z), 2) -Math.Pow(R, 2);

            double D = (b * b) - 4 * a * c;
           
            if (D < 0)
            {
                //Console.WriteLine("No intersection");
                return null;
            }

            if (D == 0)
            {
                double t = -b / 2 * a;

                double x0 = ray.point.X + (t * ray.vector.X);
                double y0 = ray.point.Y + (t * ray.vector.Y);
                double z0 = ray.point.Z + (t * ray.vector.Z);
                //Console.WriteLine("Intersection in 1 point x: {0}, y: {1}, z: {2}", x0, y0, z0);
                return intPixel = new Vector(x0, y0, z0);


            }

            if (D > 0)
            {
                double t0 = (-b + Math.Sqrt(D)) / (2 * a);
                double t1 = (-b - Math.Sqrt(D)) / (2 * a);
                
                if(t0 > 0 && t1 > 0)
                {
                    if (t0 < t1)
                    {
                        double x1 = ray.point.X + (t0 * ray.vector.X);
                        double y1 = ray.point.Y + (t0 * ray.vector.Y);
                        double z1 = ray.point.Z + (t0 * ray.vector.Z);
                        //Console.WriteLine("Intersection\nx: {0}, y: {1}, z: {2}", x1, y1, z1);
                        return intPixel = new Vector(x1, y1, z1);
                    }
                    else
                    {
                        double x1 = ray.point.X + (t1 * ray.vector.X);
                        double y1 = ray.point.X + (t1 * ray.vector.Y);
                        double z1 = ray.point.X + (t1 * ray.vector.Z);
                        //Console.WriteLine("Intersection\nx: {0}, y: {1}, z: {2}", x1, y1, z1);
                        return intPixel = new Vector(x1, y1, z1);
                    }
                }

                if(t0 < 0 && t1 > 0)
                {
                    double x1 = ray.point.X + (t1 * ray.vector.X);
                    double y1 = ray.point.X + (t1 * ray.vector.Y);
                    double z1 = ray.point.X + (t1 * ray.vector.Z);
                    //Console.WriteLine("Intersection\nx: {0}, y: {1}, z: {2}", x1, y1, z1);
                    return intPixel = new Vector(x1, y1, z1);
                }
                if(t1 < 0 && t0 > 0)
                {
                    double x1 = ray.point.X + (t0 * ray.vector.X);
                    double y1 = ray.point.Y + (t0 * ray.vector.Y);
                    double z1 = ray.point.Z + (t0 * ray.vector.Z);
                    //Console.WriteLine("Intersection\nx: {0}, y: {1}, z: {2}", x1, y1, z1);
                    return intPixel = new Vector(x1, y1, z1);
                }

                if(t1 < 0 && t0 < 0)
                {
                    //Console.WriteLine("Intersections lower then position of origin point");
                    return null;
                }      
            }

            return null;
        }
    }
}
