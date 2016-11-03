using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cross
{
    class RayTracer
    {
        public int a { get; set; }

        public RayTracer() { }       
        
        public RayTracer(int a) // platno
        {
            this.a = a;
        } 

        public Ray CreateRay(double x1, double y1)
        {
           
            x1 = (x1 / 640) * a;
            y1 = (y1 / 480) * a;

            Ray ray = new Ray();
            return ray = new Ray(0, 0, -1 ,x1 ,y1, 1);
        }

        public void Render(List<Sphere> sphere)
        {
            int unicode = 41;
            char character;
            string text;
           
            List<Pixel> arrayPixel = new List<Pixel>(); //pole pixelov (0 - 2500) pre konzolove platno

            int[,] consoleCanvas = new int [50, 50]; //2 rozmerne pole v konzole

            for (int k = 0; k < 50; k++) // naplnenie konzoloveho platna + pola pixelov
            {
                for (int l = 0; l < 50; l++)
                {
                    consoleCanvas[k, l] = 0;
                    arrayPixel.Add(new Pixel(l, k, 0));
                }
            }

            for (int i = 0; i < sphere.Count; i++)
            {
                for (int y = 0; y < 50; y++) //stlpce
                {
                    for (int x = 0; x < 50; x++) // riadky
                    {
                        if(consoleCanvas[y, x] == 0) //ak sa rovna 0, mozme dalej zistovat ci sa nachadza nejaky prisecnik gule
                        {
                            if (sphere[i].GetIntersection(CreateRay(x * 12.8, y * 9.6)) == null) //ak je volne ale aj tak sa nenachadza
                            {
                                consoleCanvas[y, x] = 0;                               
                            }
                            else //ak je volne policko a najde sa priesecnik
                            {
                                    Vector v = sphere[i].GetIntersection(CreateRay(x * 12.8, y * 9.6)); //dostanem poziciu priesecniku gule
                                    arrayPixel[y * 50 + x].intersectSize = Math.Sqrt(Math.Pow(v.x, 2) + Math.Pow(v.y, 2) + 1);
                                    //pre vypocet velkosti vektora na zaklade 2 bodov

                                    consoleCanvas[y, x] = i + 1; //priradim indexu v poli urcitu gul                              
                            } 
                        }

                          else
                          {
                            if (sphere[i].GetIntersection(CreateRay(x * 12.8, y * 9.6)) != null)
                            {                               
                                    Vector u = sphere[i].GetIntersection(CreateRay(x * 12.8, y * 9.6));
                                    double size = Math.Sqrt(Math.Pow(u.x, 2) + Math.Pow(u.y, 2) + 1);

                                    if (size < arrayPixel[y * 50 + x].intersectSize) //zistujem ci je novy bod blizsie k pozorovatelovi ako obsaedeny
                                    {
                                        arrayPixel[y * 50 + x].intersectSize = size; //priradenie priesecniku gule pixelu
                                        consoleCanvas[y, x] = i + 1; //priradenie priesecniku konzolovemu platnu
                                    }                              
                            }
                            
                          }
                        }
                        Console.WriteLine();                  
                    }
                }

            for(int y = 0; y < 50; y++) //vykreslenie priesecnikov pomocou ASCII
            {
                for(int x = 0; x < 50; x++)
                {
                    if(consoleCanvas[y,x] != 0)
                    {
                        unicode = unicode + consoleCanvas[y, x];
                        character = (char)unicode;
                        text = character.ToString();
                        Console.Write(text);
                    }
                    else Console.Write(" ");
                    
                    unicode = 41;
                }
                Console.WriteLine();
            }

            

        }
            
     }
}

