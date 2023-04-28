using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Composite
{
    internal class Directory : Entry
    {
        string name;
        List<Entry> entries=new List<Entry>();
        public Directory(string _name)
        {
            this.name = _name;
        }

        public override string GetName()
        {
            return name;
        }

        public override int GetSize()
        {
            int sum = 0;
            foreach(var item in entries)
            {
                sum += item.GetSize();
            }
           return sum;
        }
        public override void Add(Entry entry)
        {
            entries.Add(entry);
            entry.parent= this;
        }

        public override void PrintPath()
        {
            Console.WriteLine("\\" + name);
            foreach(var item in entries)
            {
                item.PrintPath();
            }
        }
    }
}
