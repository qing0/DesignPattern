using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal class File : Entry
    {
        string name;
        int size;
        public File(string _name,int _size)
        {
            this.name = _name;
            this.size = _size;
        }
        public override string GetName()
        {
           return name;
        }

        public override int GetSize()
        {
            return size;
        }

        public override void PrintPath()
        {
            Console.WriteLine("\\"+name);
        }
    }
}
