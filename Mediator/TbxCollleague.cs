using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Mediator
{
    internal class TbxCollleague : TextBox, Colleagues
    {
        FrameMediator mediator;
        public TbxCollleague()
        {
            
        }
        public void SetColleagueEnabled(bool enabled)
        {
            this.IsEnabled= enabled;
        }

        public void SetMediator(FrameMediator mediator)
        {
            this.mediator = mediator;
        }
        protected override void OnTextChanged(TextChangedEventArgs e)
        {
            mediator.ColleagueChanged();

        }

    }
}
