using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class IncrementSubject : Subject
    {
        int _start;
        int _end;
        int _step;
        int number;
        public IncrementSubject(int start,int end ,int step)
        {
            this._step = step;
            this._start = start;
            this._end = end;
            number = _start;
        }
        public override void Execute()
        {
            for(int i = _start; i < _end; i+=_step)
            {
                number = i;
                Thread.Sleep(100);
                NotifyObservers();
            }
        }

        public override int GetNumber()
        {

            return number;
        }
    }
}
