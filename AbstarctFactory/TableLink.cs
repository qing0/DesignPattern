using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstarctFactory
{
    internal class TableLink : Link
    {
        public TableLink(string captionStr, string url) : base(captionStr, url)
        {
        }

        public override string MakeHtml()
        {
            return $"<td><a href=\"{url}\">{caption}</a></td>";
        }
    }
}
