using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    internal class AddVisitor : ArrayList, Element
    {
        public void Accept(TheVisitor visitor)
        {
            foreach(Entry item in this)
            {
                item.Accept(visitor);
            }
        }
    }
}
