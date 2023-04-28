using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class ConcereteSubject : Subject
    {
        Random random= new Random();
        int num;
        public override void Execute()
        {
            for(int i = 0; i < 20; i++)
            {
                num=random.Next(50);
                NotifyObservers();
            }
        }

        public override int GetNumber()
        {
            return num;
        }
    }
}
