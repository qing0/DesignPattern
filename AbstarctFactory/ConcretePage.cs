using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstarctFactory
{
    internal class ConcretePage : Page
    {
        public ConcretePage(string title, string author) : base(title, author)
        {
        }

        protected override string MakeHtml()
        {
            StringBuilder stringBuilder= new StringBuilder();
            stringBuilder.Append($"<html><head><title>{Title}</title></head><body><h1>{Title}</h1><ul>");

            foreach (var pItem in content)
                stringBuilder.Append(pItem.MakeHtml());

            stringBuilder.Append($"</ul><hr><address>{Author}</address></body></html>");

            return stringBuilder.ToString();
        }
    }
}
