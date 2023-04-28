using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class SelectionSorter : Sorter
    {
        int[] data;
        public void sort(int[] _data)
        {
            this.data= _data;
            selectionSort();
        }
        private void selectionSort()
        {
            for (int i = 0; i < data.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < data.Length; j++)
                {
                    if (data[min] > data[j])
                    {
                        min = j;
                    }
                }
                int tem = data[min];
                data[min] = data[i];
                data[i] = tem;//最小值
            }
        }
    }
}
