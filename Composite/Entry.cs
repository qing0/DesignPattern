using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    /// <summary>
    /// 嵌套
    /// </summary>
    internal abstract class Entry
    {
        public Entry parent;
        public abstract string GetName();
        public abstract int GetSize();

        public void  Print()
        {
            Console.WriteLine("name:"+GetName()+"size:"+GetSize().ToString());
           
        }
        public virtual void Add(Entry entry)
        {
            throw new Exception("不支持该操作");
        }
        public abstract void PrintPath();

        public void PrintFullPath()
        {
            StringBuilder str=new StringBuilder();
            Entry entry = this;
            do
            {
                str.Insert(0,"\\"+entry.GetName());
                entry = entry.parent;
            }while(entry!=null);
            Console.WriteLine(str);
        }
    }
}
