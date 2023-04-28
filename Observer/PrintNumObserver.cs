using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class PrintNumObserver : TheObserver
    {
        public void Update(Subject subject)
        {
            Thread.Sleep(100);
            Console.WriteLine("printObserver:"+subject.GetNumber().ToString());
            
        }
    }
}
