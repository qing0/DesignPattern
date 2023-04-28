using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    /// <summary>
    /// 功能层次扩展 
    /// </summary>
    internal class IncreaseDisplay : CountDisplay
    {
        //递增步长
        int step;
        public IncreaseDisplay(ImplDisplay iDisplay,int stepTem) : base(iDisplay)
        {
            this.step= stepTem;
        }
        public void IncreaseDisplayStr(int level)
        {
            int count = 0;
            for(int i = 0; i < level; i++)
            {
                this.MultiDisplay(count);
                count += step;
            }
        }
    }
}
