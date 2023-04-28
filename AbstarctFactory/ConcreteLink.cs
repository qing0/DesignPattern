using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstarctFactory
{
    internal class ConcreteLink : Link
    {
        public ConcreteLink(string captionStr, string url) : base(captionStr, url)
        {
        }

        public override string MakeHtml()
        {
            return $"<li><a href=\"{url}\">{caption}</a></li>";
        }
    }
}
