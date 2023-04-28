using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    /// <summary>
    /// 集合 包含迭代器
    /// </summary>
    internal interface Aggeragate
    {
        public abstract IIterator Iterator();
    }
}
