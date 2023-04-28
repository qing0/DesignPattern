using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    /// <summary>
    ///  适配器 将新的功能需求与旧的功能解耦
    /// 类适配器模式 通过继承进行适配 ,Banner是类，Print是接口
    /// 相对的对象适配器  通过委托进行适配  print也是类，不能继承多个类，只继承Print，添加一个字段，保存Banner的实例，
    /// 在重写print的方法时，具体处理交给了banner实例对象的方法
    ///
    /// </summary>
    internal class PrintBanner : Banner, Print
    {
        public PrintBanner(string str):base(str)
        {
        }
        public void PrintStrong()
        {
            PrintA();
        }

        public void PrintWeak()
        {
           PrintB();
        }
    }
}
