using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    internal class CharChild : Template
    {
        private string str;
        public CharChild(string str)
        {
            this.str = str;
        }
        public override void Print()
        {
            Console.Write("<<");
        }

        public override void Start()
        {
            Console.Write(str);
        }

        public override void Stop()
        {
            Console.WriteLine(">>");
        }
    }
}
