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

        public double size => Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2));

        public Vector(double x, double y, double z) // konstruktor
        {
            this.x = x;
            this.y = y;
            this.z = z;
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
    }
}
