using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    /// <summary>
    /// 装饰器 继承组件，同时调用组件
    /// </summary>
    internal abstract class Border : Display
    {
        Display display;
        public Border(Display display)
        {
            this.display = display;
        }
     
    }
}
