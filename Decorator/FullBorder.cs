using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class FullBorder : Border
    {
        char borderChar = '*';
        Display display;
        public FullBorder(Display _display) : base(_display)
        {
            this.display = _display;
        }

        public override int getColumns()
        {
            return 1 + display.getColumns() + 1;
        }

        public override int getRows()
        {
           return 1 + display.getRows() + 1;
        }

        public override string getRowText(int row)
        {
            if (row == 0)
            {
                return "-" + getBorderLine(display.getColumns()) + "-";
            }
            else if (row == display.getRows() + 1)
            {
                return "*"+getBorderLine(display.getColumns())+"*";
            }
            else
            {
                return "|"+ display.getRowText(row-1)+"|";
            }
        }
        private string getBorderLine(int length)
        {
            StringBuilder stringBuilder=new StringBuilder();
            for(int i = 0; i < length; i++)
            {
                stringBuilder.Append("+");
            }
            return stringBuilder.ToString();
        }
    }
}
