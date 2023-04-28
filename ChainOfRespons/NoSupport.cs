using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfRespons
{
    internal class NoSupport : Support
    {
        string name;
        public NoSupport(string _name): base(_name)
        {
            
        }
        protected override bool Resolve(Trouble trouble)
        {
            //Console.WriteLine($"{name}不解决{trouble.GetNum().ToString()}");
            return false;
        }
    }
}
