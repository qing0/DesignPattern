using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstarctFactory
{
    internal abstract class Item
    {
        protected string caption;
        public Item(string captionStr)
        {
            this.caption = captionStr;
        }
        public abstract string MakeHtml();
    }
}
