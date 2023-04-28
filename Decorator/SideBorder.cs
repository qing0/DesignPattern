using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class SideBorder : Border
    {
        char borderChar;
        Display display;
        public SideBorder(Display _display, char _borderChar) : base(_display)
        {
            this.borderChar = _borderChar;
            this.display = _display;    
        }

        public override int getColumns()
        {
            return 1+ display.getColumns() + 1;
        }

        public override int getRows()
        {
            return display.getRows();
        }

        public override string getRowText(int row)
        {
            return borderChar + display.getRowText(row) + borderChar;
        }
    }
}
