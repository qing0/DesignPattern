using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    /// <summary>
    /// 具体组件 核心
    /// </summary>
    internal class StringDisplay : Display
    {
        string str;
        public StringDisplay(string _str)
        {
            this.str= _str;
        }
        public override int getColumns()
        {
            return this.str.Length;
        }

        public override int getRows()
        {
            return 1;
        }

        public override string getRowText(int row)
        {
            return str;
        }
    }
}
