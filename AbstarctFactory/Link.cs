using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstarctFactory
{
    internal abstract class Link : Item
    {
        protected string url;
        protected Link(string captionStr, string url) : base(captionStr)
        {
            this.url = url;
        }
    }
}
