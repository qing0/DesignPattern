using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    /// <summary>
    /// 组件
    /// </summary>
    internal abstract class Display
    {
        public abstract int getColumns();
        public abstract int getRows();

        public abstract string getRowText(int row);
        /// <summary>
        /// 模板方法
        /// </summary>
        /// <returns></returns>
        public void Show()
        {
            for(int i=0; i < getRows(); i++)
            {
                
                Console.WriteLine(getRowText(i));
            }
        }
    }
}
