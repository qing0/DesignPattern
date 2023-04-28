using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Bridge
{
    /// <summary>
    /// 实现层次
    /// </summary>
    internal class CharDisplayImpl : ImplDisplay
    {
        string start;
        string str;
        string end;
        public CharDisplayImpl(string startTem,string strTem,string endTem)
        {
            this.start = startTem;
            this.str= strTem;
            this.end = endTem;
        }
        public void Close()
        {
            Console.WriteLine(end);
        }

        public void Open()
        {
            Console.Write(start);
        }

        public void Print()
        {
            Console.Write(str);
        }
    }
}
