using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    /// <summary>
    /// 迭代器
    /// </summary>
    internal interface IIterator
    {
        public abstract bool HasNext();
        public abstract object Next();
    }
}
