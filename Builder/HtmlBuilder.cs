using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class HtmlBuilder : TheBuilder
    {
        string fileName;
        private StreamWriter writer;

        public override void BuildDone()
        {
            writer.WriteLine("</body></html>");
            writer.Close(); 
        }

        public override void BuildItems(string[] items)
        {
            writer.WriteLine("<ul>");
            foreach(var item in items)
            {
                writer.WriteLine("<li>"+item+"</li>");
            }
            writer.WriteLine("</ul>");
        }

        public override void BuildString(string str)
        {
            writer.WriteLine("<p>"+ str+"</p>");
        }

        public override void BuildTitle(string title)
        {
            fileName=title+".html";
            writer=new StreamWriter(fileName);
            writer.WriteLine("<html><head><title>"+title+"</title></head><body>");
            writer.WriteLine("<h1>"+title+"</h1>");
        }
        public string GetResult()
        {
            return fileName;
        }
    }
}
