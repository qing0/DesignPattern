using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    /// <summary>
    /// 实现层具体实现类
    /// </summary>
    internal class ConcreteDisplay : ImplDisplay
    {
        private string str;
        private int length;
        public ConcreteDisplay(string temStr)
        {
            this.str= temStr;
            this.length = this.str.Length;
        }
        public void Close()
        {
            PrintLine();
        }

        public void Open()
        {
            PrintLine();
        }

        public void Print()
        {
            Console.WriteLine("+"+str+"+");
        }
        private void PrintLine()
        {
            Console.Write("+"); 
            for(int i=0;i<length;i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("+");
        }
    }
}
