using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    internal abstract class Entry:Element
    {
        public abstract int GetSize();
        public abstract string GetName();

        public virtual void Add(Entry entry)
        {
            throw new Exception();
        }

        public abstract void Accept(TheVisitor visitor);
      
    }
}
