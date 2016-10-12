using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cross
{
    interface IObject
    {
        Vector GetIntersection(Ray ray);
    }
}
