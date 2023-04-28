using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{

    internal class Directory : Entry
    {
        public List<Entry> entries= new List<Entry>();
        private string name;
        public Directory(string _name)
        {
            this.name = _name;
        }

        public override string GetName()
        {
           return this.name;
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
        }

        public override void Accept(TheVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
