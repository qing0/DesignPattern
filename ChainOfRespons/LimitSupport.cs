using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfRespons
{
    internal class LimitSupport : Support
    {
        string name;
        int limit;

        public LimitSupport(string _name, int _limit):base(_name)
        {
            this.limit = _limit;
        }
        protected override bool Resolve(Trouble trouble)
        {
            if(limit<trouble.GetNum())
            {
                return true;
            }
            return false;
        }
    }
}
