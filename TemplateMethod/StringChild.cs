using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    internal class StringChild : Template
    {
        int width;
        string str;
        public StringChild(string str)
        {
            this.str = str;
            this.width = str.Length;
        }
        public override void Print()
        {
            Console.WriteLine(str);
        }

        public override void Start()
        {
            PrintLine();
        }

        public override void Stop()
        {
            PrintLine();
        }
        void PrintLine()
        {
            Console.Write("-");
            for(int i = 0; i < width; i++)
            {
                Console.Write("+");
            }
            Console.WriteLine("-");
        }
    }
}
