using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    /// <summary>
    /// 模板方法 保存具体流程方法，每个步骤交给子类实现
    /// </summary>
    internal abstract class Template
    {
        public abstract void Start();
        public abstract void Print();
        public abstract void Stop();

        public void Display()
        {
            Start();
            for(int i = 0; i < 5; i++)
            {
                Print();
            }
            Stop();
        }
    }
}
