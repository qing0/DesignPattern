using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    internal class SizeVisitor : TheVisitor
    {
        public override void Visit(File file)
        {
            Console.WriteLine(file.GetName()+":"+file.GetSize());
        }

        public override void Visit(Directory directory)
        {
            Console.WriteLine(directory.GetName()+":"+directory.GetSize());
            foreach(var item in directory.entries)
            {
               item.Accept(this);
            }
        }
    }
}
