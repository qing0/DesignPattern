using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstarctFactory
{
    internal class TableTray : Tray
    {
        public TableTray(string captionStr) : base(captionStr)
        {
        }

        public override string MakeHtml()
        {
            StringBuilder stringBuilder= new StringBuilder();
            stringBuilder.Append("<td>");
            stringBuilder.Append($"<table><tr><td><b>{caption}</b></td></tr>");
            stringBuilder.Append("<tr>");

            foreach(var tItem in items)
            {
                stringBuilder.Append(tItem.MakeHtml());
            }

            stringBuilder.Append("</tr></table></td>");

            return stringBuilder.ToString();
        }
    }
}
