using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class InsertSorter : Sorter
    {
        int[] data;
        public void sort(int[] _data)
        {
            this.data=_data;
        }
        private void InsertSort()
        {

        }
    }
}
