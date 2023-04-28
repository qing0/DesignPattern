using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    internal class ListVisitor : TheVisitor
    {
        private string curDir = "";
        public override void Visit(File file)
        {
            Console.WriteLine(curDir+"\\"+file.GetName());
        }

        public override void Visit(Directory directory)
        {
            Console.WriteLine(curDir+"\\"+directory.GetName());
            //记录旧的curDir
            string dirTem = curDir;
            curDir=curDir+"\\"+directory.GetName();
            //visit方法参数分别为FIle 和Directory,不能直接调用this.Visit(entry)
            //需要将FIle、Directory分别实现visit接口
            foreach(var item in directory.entries)
            {
                item.Accept(this);
            }
            //复原
            curDir= dirTem;
        }
    }
}
