using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfRespons
{
    internal class Trouble
    {
        int number;
        public Trouble(int _num)
        {
            this.number = _num;
        }
        public int GetNum()
        {
            return number;
        }
    }
}
