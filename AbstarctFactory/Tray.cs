using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstarctFactory
{
    internal abstract class Tray : Item
    {
        protected List<Item> items; 
        protected Tray(string captionStr) : base(captionStr)
        {
            items=new List<Item>();
        }
        public void Add(Item item)
        {
            items.Add(item);
        }
    }
}
