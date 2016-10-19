using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cross
{
    class RayTracer
    {
        public RayTracer() { }

        public Ray CreateRay(double x1, double y1)
        {
            x1 = x1 / 640;
            y1 = y1 / 480;

            Ray ray = new Ray();
            return ray = new Ray(0, 0,-1 ,x1 ,y1 , 1);
        }

        public void Render(Sphere sphere)
        {
            for(int y = 0; y < 50; y++)
            {
                for(int x = 0; x <50; x++)
                {
                    if (sphere.GetIntersection(CreateRay(x * 12.8, y * 9.6)) == null) // pre zobrazenie 50 x 50 v konzole
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }                      
                }
                Console.WriteLine();
            }
        }
    }
}
