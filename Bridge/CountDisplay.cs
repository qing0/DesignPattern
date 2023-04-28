using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    /// <summary>
    /// 功能层次子类
    /// </summary>
    internal class CountDisplay:Display
    {
        public CountDisplay(ImplDisplay iDisplay) : base(iDisplay)
        {
        }

        public void  MultiDisplay(int count )
        {
            this.implDisplay.Open();
            for(int i = 0; i < count; i++)
            {
                this.implDisplay.Print();
            }
            this.implDisplay.Close();
        }

        //public void RandomDisplay()
        //{
        //    this.implDisplay.Open();
        //    Random random=new Random();
        //    int value= random.Next(9);
        //    for(int i=0; i < value; i++)
        //    {
        //        this.implDisplay.Print();
        //    }
        //    this.implDisplay.Close();
            
        //}
    }
}
