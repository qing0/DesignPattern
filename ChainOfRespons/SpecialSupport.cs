using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfRespons
{
    internal class SpecialSupport : Support
    {
        string name;
        int num;
        public SpecialSupport(string _name,int _num):base(_name)
        {
            this.num= _num;
        }
        protected override bool Resolve(Trouble trouble)
        {
            if(num==trouble.GetNum())
            {
                return true;
            }
            return false;
        }
    }
}
