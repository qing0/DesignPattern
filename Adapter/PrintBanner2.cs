using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    /// <summary>
    /// 适配器
    /// 相对的对象适配器  通过委托进行适配
    /// 无法继承两个类，将print设置成类，将添加一个字段，保存Banner的实例，用banner的实例去调用方法
    /// 在重写print的方法时，具体处理交给了banner实例对象的方法
    /// </summary>
    internal class PrintBanner2 : Print2
    {
        private Banner banner;
        public PrintBanner2(string str)
        {
            banner=new Banner(str);
        }
        public override void PrinStrong()
        {
           this.banner.PrintA();
        }

        public override void PrintWeak()
        {
            this.banner.PrintB();
        }
    }
}
