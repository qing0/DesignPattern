using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    /// <summary>
    ///  要适配成的目标
    /// 新的功能需求
    /// </summary>
    internal abstract class Print2
    {
        public abstract void PrintWeak();
        public abstract void PrinStrong();
    }
}
