using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    /// <summary>
    /// 实现层次接口
    /// </summary>
    internal interface ImplDisplay
    {
        public void Open();
        public void Print();
        public void Close();
    }
}
