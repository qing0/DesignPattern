using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal interface Product:ICloneable
    {
        public void Use(string str);

        public Product CreateClone();
    }
}
