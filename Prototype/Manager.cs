using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal class Manager
    {
        Dictionary<string,Product> dic=new Dictionary<string, Product> ();
        public void Register(string name,Product proto)
        {
            dic.Add(name, proto);
        }

        public Product Create(string name)
        {
            Product product= (Product)dic[name];
            return product.CreateClone();
        }
    }
}
