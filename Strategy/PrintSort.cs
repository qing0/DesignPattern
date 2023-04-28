using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class PrintSort
    {
        private int[] _data;
        private Sorter _sorter;
        public PrintSort(int[] data,Sorter sorter)
        {
            this._sorter = sorter;
            this._data = data;
        }
        public void Print()
        {
            foreach(var item in _data)
            {
                Console.WriteLine(item);
            }
        }
        public void Execute()
        {
            Console.WriteLine("排序前");
            Print();
            _sorter.sort(_data);
            Console.WriteLine("排序前");
            Print();
        }
    }
}
