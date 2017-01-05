using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Cross
{
    class Vector
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public double size => Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2) + Math.Pow(Z, 2));

        public Vector(double x, double y, double z) // konstruktor
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public Vector() { }

        public Vector u(Vector v) //normalizovany
        {
            return new Vector((1 / v.size * v.X), (1 / v.size * v.Y), (1 / v.size * v.Z));
        }

        public static Vector operator +(Vector a, Vector b) //scitanie
        {
            return new Vector((a.X + b.X), (a.Y + b.Y), (a.Z + b.Z));
        }

        public static Vector operator -(Vector a, Vector b) //odcitanie
        {
            return new Vector((a.X - b.X), (a.Y - b.Y), (a.Z - b.Z));
        }

        public static double operator *(Vector a, Vector b) //skalarny sucin
        {
            return (a.X * b.X + a.Y * b.Y + a.Z * b.Z);
        }
    }
}
