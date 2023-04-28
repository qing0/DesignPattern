using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstarctFactory
{
    internal class TableFactory : Factory
    {
        public TableFactory()
        {
        }

        public override Link CreateLink(string captionStr, string url)
        {
            return new TableLink(captionStr,url);
        }

        public override Page CreatePage(string title, string author)
        {
            return new TablePage(title, author);
        }

        public override Tray CreateTray(string captionStr)
        {
           return new TableTray(captionStr);
        }
    }
}
