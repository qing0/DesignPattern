using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    /// <summary>
    /// 被适配  被适配器从100伏特电压适配成12伏特电压
    /// 
    /// 笔记本电脑只要在直流 12 伏特电压下就能正常工作
    /// 但它并不知道这 12 伏特的电压是由适配器将100 伏特交流电压转换而成的。
    /// </summary>
    internal class Banner
    {
        public string Str{ get; set; }
        public Banner(string str)
        {
            Str = str;
        }
        public void PrintA()
        {
            Console.WriteLine(Str+"A");
        }
        public void PrintB()
        {
            Console.WriteLine(Str + "B");
        }
    }
}
