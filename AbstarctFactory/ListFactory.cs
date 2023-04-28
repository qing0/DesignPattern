using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstarctFactory
{
    internal class ListFactory : Factory
    {
        public override Link CreateLink(string captionStr, string url)
        {
            return new ConcreteLink(captionStr, url);
        }

        public override Page CreatePage(string title, string author)
        {
            return new ConcretePage(title, author);
        }

        public override Tray CreateTray(string captionStr)
        {
          return new ConcreteTray(captionStr);
        }
    }
}
