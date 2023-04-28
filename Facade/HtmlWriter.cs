using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class HtmlWriter
    {
        private StreamWriter writer;
       
        public HtmlWriter(string _fileName)
        {
             
            writer=new StreamWriter(_fileName);
        }
        public void Title(string title)
        {
            writer.WriteLine("<html><head><title>"+title+"</title></head><body>");
        }
        public void Paragraph(string userName)
        {
            writer.WriteLine("<p>welcome "+ userName + "！</p>");
        }
        public void Link(string href,string caption)
        {
            writer.WriteLine("<a href=\""+href+"\">"+caption+"</a>");
        }
        public void MailTo(string mailAddr,string userName)
        {
            Link("mailto:"+mailAddr,userName);
        }
        public void Close()
        {
            writer.WriteLine("</body></html>");
            writer.Close();
        }
    }
}
