using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class BubbleSorter : Sorter
    {
        int[] data;
        public void sort(int[] _data)
        {
            this.data = _data;
            BubbleSort();
        }
        private void BubbleSort()
        {
            //是否交换
            bool isSwap = true;
            for(int i=1;i<this.data.Length&&isSwap;i++)
            {
                isSwap= false;
                for(int j=this.data.Length-1;j>=i;j--) 
                {
                    if (data[j] < this.data[j-1])
                    {
                        //与前一个元素交换
                        Utils.swap(this.data,j, j-1);
                        isSwap = true;
                    }
                }
            }
        }
    }
}
