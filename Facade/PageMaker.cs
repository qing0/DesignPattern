using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class PageMaker
    {
        public void MakePage(string mail,string htmlFileName)
        {
            List<Property> properties=MailReader.GetProperties("test.txt");
            Property p=properties.FirstOrDefault(p => p.Name == mail);
            if(p != null)
            {
                HtmlWriter htmlWriter = new HtmlWriter(htmlFileName);
                htmlWriter.Title("test");
                htmlWriter.Paragraph(p.Value);
                htmlWriter.MailTo(p.Name, p.Value);
                //htmlWriter.Link(mail, htmlFileName);
                htmlWriter.Close();

            }
        }
        public void MakeLinkPage(string htmlFileName)
        {
            List<Property> properties = MailReader.GetProperties("test.txt");
            HtmlWriter htmlWriter = new HtmlWriter(htmlFileName);
            htmlWriter.Title("test");
            foreach (var item in properties)
            {
                htmlWriter.Link(item.Name,item.Value);
              
              
            }
            htmlWriter.Close();
        }
    }
}
