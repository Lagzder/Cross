using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Cross
{
    class Vector
    {
        public double x { get; set; }
        public double y { get; set; }
        public double z { get; set; }

        public double xt { get; set; }
        public double yt { get; set; }
        public double zt { get; set; }

        public double r { get; set; }

        public double size => Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2));

        public Vector(double x, double y, double z) // konstruktor
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public Vector(double x, double y, double z, double xt, double yt, double zt)
        {
            this.x = x;
            this.y = y;
            this.z = z;

            this.xt = xt;
            this.yt = yt;
            this.zt = zt;
        }

        public Vector (double x, double y, double z, double r)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.r = r;
        }

        public Vector() { }

        public Vector u(Vector v) //normalizovany
        {
            Vector u = new Vector();

            u.x = (1 / v.size * v.x);
            u.y = (1 / v.size * v.y);
            u.z = (1 / v.size * v.z);
            

            return u;
        }

        public static Vector operator +(Vector a, Vector b) //scitanie
        {
            Vector vector = new Vector();

            vector.x = a.x + b.x;
            vector.y = a.y + b.y;
            vector.z = a.z + b.z;

            return vector;
        }

        public static Vector operator -(Vector a, Vector b) //odcitanie
        {
            Vector vector = new Vector();

            vector.x = a.x - b.x;
            vector.y = a.y - b.y;
            vector.z = a.z - b.z;

            return vector;
        }

        public static double operator *(Vector a, Vector b) //skalarny sucin
        {
            return a.x * b.x + a.y * b.y + a.z * b.z;
        }

        public void test()
        {
            Console.WriteLine("1. vector:");
            string length1;
            string width1;
            string height1;

            length1 = Console.ReadLine();
            int x1 = Convert.ToInt32(length1);

            width1 = Console.ReadLine();
            int y1 = Convert.ToInt32(width1);

            height1 = Console.ReadLine();
            int z1 = Convert.ToInt32(height1);

            Vector vector1 = new Vector(x1, y1, z1);

            Console.WriteLine("2. vector:");
            string length2;
            string width2;
            string height2;

            length2 = Console.ReadLine();
            int x2 = Convert.ToInt32(length2);

            width2 = Console.ReadLine();
            int y2 = Convert.ToInt32(width2);

            height2 = Console.ReadLine();
            int z2 = Convert.ToInt32(height2);

            Vector vector2 = new Vector(x2, y2, z2);

            Vector add = new Vector();
            Vector sub = new Vector();
            double dotProduct;
            add = vector1 + vector2;
            sub = vector1 - vector2;
            dotProduct = (vector1 * vector2);

            Console.WriteLine("\n1. vector: \t\tsize = {0}\n\t\t\tUnit vector: x = {1}, y = {2}, z = {3}", vector1.size, u(vector1).x, u(vector1).y, u(vector1).z);
            Console.WriteLine("\n2. vector: \t\tsize = {0}\n\t\t\tUnit vector: x = {1}, y = {2}, z = {3}", vector2.size, u(vector2).x, u(vector2).y, u(vector2).z);
            Console.WriteLine("\nAddition:\t\tx = {0}, y = {1}, z = {2}", add.x, add.y, add.z);
            Console.WriteLine("Subtraction:\t\tx = {0}, y = {1}, z = {2}", sub.x, sub.y, sub.z);
            Console.WriteLine("Dot product =\t\t{0}", dotProduct);
        }

        /*******************************************************2. ZADANIE***************************************************************/

        public void line_sphere_intersection(Vector line, Vector sphere)
        {
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
            }
        }

            public void test2()
        {
            string x; string xt;            
            string y; string yt;
            string z; string zt;

            string x1;
            string y1;
            string z1;
            string r;

            Console.WriteLine("Enter the line by parametric form : x = x + n*t...");
            Console.WriteLine("x = {0} + {1}t", x = Console.ReadLine(), xt = Console.ReadLine());
            Console.WriteLine("y = {0} + {1}t", y = Console.ReadLine(), yt = Console.ReadLine());
            Console.WriteLine("z = {0} + {1}t", z = Console.ReadLine(), zt = Console.ReadLine());

            Console.WriteLine("Enter the coordinates(x, y, z) of sphere centre:");
            Console.WriteLine("x = {0}\ny = {1}\nz = {2}", x1 = Console.ReadLine(), y1 = Console.ReadLine(), z1 = Console.ReadLine());
            Console.WriteLine("Enter sphere radius:");
            Console.WriteLine("r = {0}", r = Console.ReadLine());

            Vector line = new Vector(Convert.ToDouble(x), Convert.ToDouble(y), Convert.ToDouble(z), Convert.ToDouble(xt), Convert.ToDouble(yt), Convert.ToDouble(zt));
            Vector sphere = new Vector(Convert.ToDouble(x1), Convert.ToDouble(y1), Convert.ToDouble(z1), Convert.ToDouble(r));

            line_sphere_intersection(line, sphere); 
        }

            
        
    }
}
