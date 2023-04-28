using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class SignalObserver : TheObserver
    {
        public void Update(Subject subject)
        {
            Thread.Sleep(100);
            Console.Write("SignalObserver:");
            for(int i=0;i<subject.GetNumber();i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
