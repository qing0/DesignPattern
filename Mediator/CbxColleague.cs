using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Mediator
{
    internal class CbxColleague : CheckBox, Colleagues
    {
        FrameMediator mediator;
        public CbxColleague(string text)
        {
            this.Content = text;
        }
        public void SetColleagueEnabled(bool enabled)
        {
            this.IsEnabled= enabled;
        }

        public void SetMediator(FrameMediator mediator)
        {
            this.mediator = mediator;
        }
        protected override void OnChecked(RoutedEventArgs e)
        {
            base.OnChecked(e);
            mediator.ColleagueChanged();
        }
    }
}
