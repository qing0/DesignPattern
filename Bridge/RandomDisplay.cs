using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class RandomDisplay : CountDisplay
    {
        public RandomDisplay(ImplDisplay iDisplay) : base(iDisplay)
        {
        }
        public void RandomDisplayStr()
        {
            this.MultiDisplay(new Random().Next(0, 10));
        }
    }
}
