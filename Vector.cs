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
        public double size { get;}

        public Vector(double x, double y, double z) // konstruktor
        {
            this.x = x;
            this.y = y;
            this.z = z;
            size = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2));
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
    }
}
