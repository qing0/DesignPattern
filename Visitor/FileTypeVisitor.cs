using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    internal class FileTypeVisitor : TheVisitor
    {
        private string fileType;
        public List<Entry> entries=new List<Entry>();
        public FileTypeVisitor(string type)
        {
            this.fileType = type;
        }
        public override void Visit(File file)
        {
            if (file.GetName().EndsWith(fileType))
            {
                entries.Add(file);
            }
        }

        public override void Visit(Directory directory)
        {
            if(directory.GetName().EndsWith(fileType))
            {
                entries.Add(directory);
            }
            foreach(var item in directory.entries)
            {
                item.Accept(this);
            }
        }
        public void PrintFileTypes()
        {
            Console.WriteLine($"{fileType}类型文件如下:");
            foreach(var entry in entries)
            {
                Console.WriteLine(entry.GetName());
            }
        }
    }
}
