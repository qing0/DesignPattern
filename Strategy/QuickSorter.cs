using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    /// <summary>
    /// 快速排序
    /// </summary>
    internal class QuickSorter : Sorter
    {
        int[] data;
        public void sort(int[] _data)
        {
            this.data = _data;
            quickSort(0, this.data.Length-1);
        }
        public void quickSort(int start ,int end)
        {
            int savedStart = start;
            int savedEnd = end;
            do
            {
                int mid = data[(start + end) / 2];
                while (data[start] < mid)
                {
                    start++;
                }
                while (data[end] > mid)
                {
                    end--;
                }
                if (start<=end)
                {
                    Utils.swap(data,start, end);

                    start++;
                    end--;
                }
            }while(start<=end);
            if (savedStart < end)
            {
                quickSort(savedStart, end);
            }
            if (start < savedEnd)
            {
                quickSort(start,savedEnd);
            }
        }
    }
}
