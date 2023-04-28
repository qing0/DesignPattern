using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstarctFactory
{
    internal class TablePage : Page
    {
        public TablePage(string title, string author) : base(title, author)
        {
        }

        protected override string MakeHtml()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"<html><head><title>{Title}</title></head><body><h1>{Title}</h1><table>");

            foreach (var pItem in content)
                stringBuilder.Append("<tr>"+pItem.MakeHtml()+"</tr>");

            stringBuilder.Append($"</table><hr><address>{Author}</address></body></html>");

            return stringBuilder.ToString();
        }
    }
}
