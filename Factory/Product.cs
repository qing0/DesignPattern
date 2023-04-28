using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    /// <summary>
    /// 框架
    /// 定义了生成的实例所拥有的接口，具体的处理交给具体实例决定
    /// </summary>
    internal abstract class Product
    {
        public abstract void Use();
    }
}
