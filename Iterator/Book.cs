using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    //书籍属性
    internal class Book
    {
        public string Name { get; set; }
        public Book(string name)
        {
            this.Name = name;
        }
        public string GetName()
        {
            return this.Name;
        }
    }
}
