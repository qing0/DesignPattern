using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Mediator
{
    internal class BtnColleague : Button, Colleagues
    {
        FrameMediator mediator;
        public BtnColleague(string text)
        {
            this.Content = text;
        }
        public void SetColleagueEnabled(bool enabled)
        {
            this.IsEnabled= enabled;
        }

        public void SetMediator(FrameMediator mediator)
        {
            this.mediator= mediator;
        }
    }
}
