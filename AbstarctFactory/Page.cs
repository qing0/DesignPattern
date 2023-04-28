using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstarctFactory
{
    internal abstract class Page
    {
        protected string Title;
        protected string Author;
        protected List<Item> content;
        public Page(string title,string author)
        {
            this.Title= title;
            this.Author= author;
            content = new List<Item>();
        }
        public void Add(Item item)
        {
            content.Add(item);
        }
        public void Output()
        {
            string fileName = Title + ".html";
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                sw.Write(this.MakeHtml());
                Console.WriteLine(fileName+"文件编写完成");
            }
        }
        protected abstract string MakeHtml();
    }
}
