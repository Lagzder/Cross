using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cross
{using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cross
{
    class Test
    {
        public void test1()
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
            Vector t = new Vector(); //pomocny

            Console.WriteLine("\n1. vector: \t\tsize = {0}\n\t\t\tUnit vector: x = {1}, y = {2}, z = {3}", vector1.size, t.u(vector1).x, t.u(vector1).y, t.u(vector1).z);
            Console.WriteLine("\n2. vector: \t\tsize = {0}\n\t\t\tUnit vector: x = {1}, y = {2}, z = {3}", vector2.size, t.u(vector2).x, t.u(vector2).y, t.u(vector2).z);
            Console.WriteLine("\nAddition:\t\tx = {0}, y = {1}, z = {2}", add.x, add.y, add.z);
            Console.WriteLine("Subtraction:\t\tx = {0}, y = {1}, z = {2}", sub.x, sub.y, sub.z);
            Console.WriteLine("Dot product =\t\t{0}", dotProduct);
        }

       public void test2()
       {
            string x0;
            string y0;
            string z0;

            string xd;
            string yd;
            string zd;

            string xc;
            string yc;
            string zc;
            string r;

            Console.WriteLine("Enter the coordinates of origin point");
            x0 = Console.ReadLine();
            y0 = Console.ReadLine();
            z0 = Console.ReadLine();

            Console.WriteLine("Enter the coordinates of Ray's vector");
            xd = Console.ReadLine();
            yd = Console.ReadLine();
            zd = Console.ReadLine();

            Ray ray = new Ray(Convert.ToDouble(x0), Convert.ToDouble(y0), Convert.ToDouble(z0), Convert.ToDouble(xd), Convert.ToDouble(yd), Convert.ToDouble(zd));

            Console.WriteLine("Enter the coordinates of sphere centre");
            xc = Console.ReadLine();
            yc = Console.ReadLine();
            zc = Console.ReadLine();

            Console.WriteLine("Enter the size of sphere radius");
            r = Console.ReadLine();

            Sphere sphere = new Sphere(Convert.ToDouble(xc), Convert.ToDouble(yc), Convert.ToDouble(zc), Convert.ToDouble(r));
            sphere.GetIntersection(ray);
        }
    }
}

    class Test
    {
        public void test1()
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
            Vector t = new Vector(); //pomocny

            Console.WriteLine("\n1. vector: \t\tsize = {0}\n\t\t\tUnit vector: x = {1}, y = {2}, z = {3}", vector1.size, t.u(vector1).x, t.u(vector1).y, t.u(vector1).z);
            Console.WriteLine("\n2. vector: \t\tsize = {0}\n\t\t\tUnit vector: x = {1}, y = {2}, z = {3}", vector2.size, t.u(vector2).x, t.u(vector2).y, t.u(vector2).z);
            Console.WriteLine("\nAddition:\t\tx = {0}, y = {1}, z = {2}", add.x, add.y, add.z);
            Console.WriteLine("Subtraction:\t\tx = {0}, y = {1}, z = {2}", sub.x, sub.y, sub.z);
            Console.WriteLine("Dot product =\t\t{0}", dotProduct);
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
            Sphere sphere = new Sphere(Convert.ToDouble(x1), Convert.ToDouble(y1), Convert.ToDouble(z1), Convert.ToDouble(r));
            Sphere t = new Sphere(); //pomocny

            t.GetIntersection(line, sphere);
        }
    }
}
