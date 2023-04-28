using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    internal class File : Entry
    {
        private string name;
        private int size;
        public File(int _size,string _name)
        {
            this.size = _size;
            this.name = _name;
        }

        public override void Accept(TheVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override string GetName()
        {
            return this.name;
        }

        public override int GetSize()
        {
            return this.size;
        }
    }
}
