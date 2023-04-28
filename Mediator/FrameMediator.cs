using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Mediator
{
    internal abstract class FrameMediator:Window
    {
        string name;
        public FrameMediator(string _name) { this.name = _name; }

        public abstract void CreateColleague();

        public abstract void ColleagueChanged();

    }
}
