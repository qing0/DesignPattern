using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    /// <summary>
    /// 功能层次父类
    /// </summary>
    internal class Display
    {


        protected ImplDisplay implDisplay;
        public Display(ImplDisplay iDisplay)
        {
            this.implDisplay = iDisplay;
        }
        public  void  DisplayStr()
        {
            implDisplay.Open();
            implDisplay.Print();
            implDisplay.Close();
        }
    }
}
