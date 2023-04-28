using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfRespons
{
    internal class OddSupport : Support
    {
        string name;
        public OddSupport(string _name):base(_name) { }
        protected override bool Resolve(Trouble trouble)
        {
            if (trouble.GetNum() % 2 == 1)
            {
                return true;
            }
            return false;
        }
    }
}
