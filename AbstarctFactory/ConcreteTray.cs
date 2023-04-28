using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstarctFactory
{
    internal class ConcreteTray : Tray
    {
        public ConcreteTray(string captionStr) : base(captionStr)
        {
        }

        public override string MakeHtml()
        {
            StringBuilder stringBuilder= new StringBuilder();
            stringBuilder.Append($"<li>{caption}<ul>");
            foreach (var tItem in items)
                stringBuilder.Append(tItem.MakeHtml());

            stringBuilder.Append($"</ul></li>");

            return stringBuilder.ToString();

        }
    }
}
